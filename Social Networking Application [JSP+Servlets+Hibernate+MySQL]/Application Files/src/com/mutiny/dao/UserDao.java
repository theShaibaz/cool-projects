package com.mutiny.dao;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Session;
import org.hibernate.Transaction;

import com.mutiny.controllers.HelperController;
import com.mutiny.models.FriendRequest;
import com.mutiny.models.MediaPostLike;
import com.mutiny.models.PrivateMessage;
import com.mutiny.models.TextPostLike;
import com.mutiny.models.User;
import com.mutiny.models.UserProfile;
import com.mutiny.models.VideoPostLike;

@SuppressWarnings({"rawtypes","unchecked"})
public class UserDao {

	private UserDao() {
		 
	} 
  
	public static User getUser(int userId) {
		
		Session session = Utility.FACTORY.openSession();
		
		User user = session.get(User.class, userId); 
		  
		session.close();
		return user;
	} 
	
	public static String getUsername(int userId) {
		
		return getUser(userId).getUsername();
	}
	
	public static boolean getUserPostLike(int userId, String postType, int postId) {
		
		if(postType.equalsIgnoreCase("text")) {
			
			List<TextPostLike> likes = PostDao.getTextPost(postId).getLikes();
			for(TextPostLike like : likes) {
				
				if(like.getLikedBy().getUserId() == userId) {
					return true;
				}
			}
		}
		else if(postType.equalsIgnoreCase("media")) {
			
			List<MediaPostLike> likes = PostDao.getMediaPost(postId).getLikes();
			for(MediaPostLike like : likes) {
				
				if(like.getLikedBy().getUserId() == userId) {
					return true;
				}
			}
		}	
		else if(postType.equalsIgnoreCase("video")) {
			
			List<VideoPostLike> likes = PostDao.getVideoPost(postId).getLikes();
			for(VideoPostLike like : likes) {
				
				if(like.getLikedBy().getUserId() == userId) {
					return true;
				}
			}
		}
		return false;
	}
	
	public static String getUserStatus(int userId) {
		
		return getUser(userId).getUserProfile().getStatus();
	}
	  
	public static User getUser(String username, String password) {
		
		Session session = Utility.FACTORY.openSession();
		
		String hqlQuery = "from User u where u.username = '" + username + "' and u.password = '" + password + "'";
		List result = session.createQuery(hqlQuery).getResultList();
		
		session.close();
		return (User) result.get(0);
	}
	
	public static List<SearchUserHolder> getUsers(String pattern, int userId) {
		
		Session session = Utility.FACTORY.openSession();
		
		String hqlQuery = "from User u where u.username like '" + pattern + "%'";
		List<User> users = session.createQuery(hqlQuery).getResultList();
		 
		ArrayList<SearchUserHolder> searchUsers = new ArrayList<SearchUserHolder>();
		
		for(User user : users) {
			
			String requestResult = "Strangers";
			List<FriendRequest> friendsRequestsReceived = user.getFriendsRequestsReceived();
			
			for(FriendRequest friendRequest : friendsRequestsReceived) {
				
				if(friendRequest.getFromUserId().getUserId() == userId) {
					
					if(friendRequest.getIsPending().equalsIgnoreCase("1")) {
						requestResult = "Request Sent";
					}
					else if(friendRequest.getIsPending().equalsIgnoreCase("0")) {
						if(friendRequest.getRequestResult().equalsIgnoreCase("A")) {
							requestResult = "Request Accepted";
						}
						else if(friendRequest.getRequestResult().equalsIgnoreCase("D")) {
							requestResult = "Request Declined";
						}
					}
				}
			}
			
			searchUsers.add(new SearchUserHolder(user.getUserId(), requestResult));
		}
		
		session.close();
		return searchUsers;
	}
	
	public static boolean isRequestSent(int userId, int profileId) {
		
		List<FriendRequest> friendsRequestsSent = getUser(userId).getFriendsRequestsSent();
		
		boolean requestResult = false;
		
		for(FriendRequest friendRequest : friendsRequestsSent) {
			
			if(friendRequest.getFromUserId().getUserId() == userId) {
				
				if(friendRequest.getIsPending().equalsIgnoreCase("1")) {
					requestResult = true;
					break;
				}
			}
		}
		
		return requestResult;
	}
	
	public static User authenticate(String username, String password) {
		
//		try {
//			Class.forName("com.mutiny.dao.Utility");
//		} catch (ClassNotFoundException e) {
//			e.printStackTrace();
//		}
		
		Session session = Utility.FACTORY.openSession();
		
		String hqlQuery = "from User u where u.username = '" + username + "' and u.password = '" + password + "'";
		List users = session.createQuery(hqlQuery).getResultList();
		
		User user = null;
		if(users.size() != 0) {
			
			user = (User) users.get(0);
			if(!user.getPassword().equals(password)) {
				user = null;
			}
		}

		session.close();
		return user;
	}
	
	public static User addUser(String username, String password, String birthdate, String gender, String lastLogin, String joinedOn, String isOnline, 
			File profilePicture) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		UserProfile userProfile = new UserProfile(birthdate, gender, lastLogin, joinedOn, isOnline);
		userProfile.setStatus("I am " + username);
		
		byte[] bfile = new byte[(int) profilePicture.length()];
		FileInputStream fis;
		try {
			fis = new FileInputStream(profilePicture);
			fis.read(bfile);
			fis.close();
			
			userProfile.setProfilePicture(bfile);
		}  
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		User user = new User(username, password);
		userProfile.setUserId(user);
		session.save(userProfile);
		
		transaction.commit();
		session.close();
		return user;
	}
	
	public static UserProfile getProfile(int userId) {
		
		return getUser(userId).getUserProfile();
	}
	
	public static void setIsOnline(int userId, String isOnline) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		UserProfile userProfile = getUser(userId).getUserProfile();
		userProfile.setIsOnline(isOnline);
		session.update(userProfile);
		
		transaction.commit();
		session.close();
	}
	
	public static void setLastLogin(int userId, String lastLogin) {
	
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		UserProfile userProfile = getUser(userId).getUserProfile();
		userProfile.setLastLogin(lastLogin);
		session.update(userProfile);
		
		transaction.commit();
		session.close();
	}
	
	public static void updateProfile(int userId, File profilePicture) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = getUser(userId);
		
		byte[] bfile = new byte[(int) profilePicture.length()];
		FileInputStream fis = null;
		
		try {
			fis = new FileInputStream(profilePicture);
			fis.read(bfile);
			fis.close();
			
			UserProfile profile = user.getUserProfile();
			profile.setProfilePicture(bfile);
			session.update(profile);
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		transaction.commit();
		session.close();
	}
	
	public static void updateProfile(int userId, String status) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = getUser(userId);
		
		UserProfile profile = user.getUserProfile();
		profile.setStatus(status);
		session.update(profile);
		
		transaction.commit();
		session.close();
	}
	
	public static void updateProfile(int userId, String status, File profilePicture) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = getUser(userId);
		
		UserProfile profile = user.getUserProfile();
		profile.setStatus(status);
		
		byte[] bfile = new byte[(int) profilePicture.length()];
		FileInputStream fis = null;
		
		try {
			fis = new FileInputStream(profilePicture);
			fis.read(bfile);
			fis.close();
			
			profile.setProfilePicture(bfile);
			session.update(profile);
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		transaction.commit();
		session.close();
	}
	
	public static String getProfilePicture(int userId) {
		
		User user = getUser(userId);
		
		String filePath = HelperController.DEFAULT_PATH + "user_" + user.getUserId() + ".jpg";
		byte[] picture = user.getUserProfile().getProfilePicture();
		FileOutputStream fos = null;
		 
		try {
			fos = new FileOutputStream(filePath);
			fos.write(picture);
			fos.close();
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		return filePath;
	}
	
	public static List<List> getPrivateMessageList(int userId) {
		
		User user = getUser(userId);
		
		List<PrivateMessage> messagesSent = user.getPrivateMessagesSent();
		List<PrivateMessage> messagesReceived = user.getPrivateMessagesReceived();
		
		List<PrivateMessageHolder> privateMessages = new ArrayList<PrivateMessageHolder>();
		
		for (PrivateMessage privateMessage : messagesSent) {
			int messageId = privateMessage.getMessageId();
			int senderUserId = privateMessage.getFromUserId().getUserId();
			int receiverUserId = privateMessage.getToUserId().getUserId();
			int otherUserId = privateMessage.getToUserId().getUserId();
			String messageContent = privateMessage.getMessageContent();
			String messagedOn = privateMessage.getMessagedOn();
			
			PrivateMessageHolder messageHolder = new PrivateMessageHolder(messageId, senderUserId, receiverUserId, otherUserId, messageContent, messagedOn);
			privateMessages.add(messageHolder);
		}
		
		for (PrivateMessage privateMessage : messagesReceived) {
			int messageId = privateMessage.getMessageId();
			int senderUserId = privateMessage.getFromUserId().getUserId();
			int receiverUserId = privateMessage.getToUserId().getUserId();
			int otherUserId = privateMessage.getFromUserId().getUserId();
			String messageContent = privateMessage.getMessageContent();
			String messagedOn = privateMessage.getMessagedOn();
			
			PrivateMessageHolder messageHolder = new PrivateMessageHolder(messageId, senderUserId, receiverUserId, otherUserId, messageContent, messagedOn);
			privateMessages.add(messageHolder);
		}
		
		privateMessages.sort((messageOne,messageTwo)->
			messageOne.getOtherUserId() == messageTwo.getOtherUserId() ? 
			messageOne.getMessagedOn().compareTo(messageTwo.getMessagedOn()) * -1 : 
			(messageOne.getOtherUserId() - messageTwo.getOtherUserId()) * -1
		);
		
		List<List> privateMessageList = new ArrayList<List>();
		if(privateMessages.size() > 0) {
			
			PrivateMessageHolder messageHolderOne = privateMessages.get(0);
			int otherUserId = messageHolderOne.getOtherUserId();
			
			List<PrivateMessageHolder> tempMessageList = new ArrayList<PrivateMessageHolder>();
			
			for(PrivateMessageHolder privateMessage : privateMessages) {
				
				if(privateMessage.getOtherUserId() == otherUserId) {
					tempMessageList.add(privateMessage);
				}
				else {
					privateMessageList.add(new ArrayList<PrivateMessageHolder>(tempMessageList));
					tempMessageList.clear();
					tempMessageList.add(privateMessage);
					otherUserId = privateMessage.getOtherUserId();
				}
			}
			
			if(tempMessageList.size() > 0) {
				privateMessageList.add(new ArrayList<PrivateMessageHolder>(tempMessageList));
				tempMessageList.clear();
			}
		}
		
		privateMessageList.sort((listOne,listTwo)->
			((PrivateMessageHolder) listOne.get(0)).getMessagedOn().
			compareTo(((PrivateMessageHolder) listTwo.get(0)).getMessagedOn()) * -1
		);
		
		return privateMessageList;
		
	}
	
	public static List<PrivateMessage> getPrivateMessages(int userId, int otherUserId) {
		
		Session session = Utility.FACTORY.openSession();
		
		String hqlQuery = "from PrivateMessage pm where pm.fromUserId = '" + userId + "' and pm.toUserId = '"  + otherUserId + "'"
						+ "or pm.fromUserId = '" + otherUserId + "' and pm.toUserId = '" + userId + "'";
		List<PrivateMessage> privateMessages = session.createQuery(hqlQuery).getResultList();
		
		privateMessages.sort((messageOne,messageTwo)-> messageOne.getMessagedOn().compareTo(messageTwo.getMessagedOn()) * -1);
		
		session.close();
		return privateMessages;
	}
	
	public static void addAddPrivateMessage(int toUserId, int fromUserId, String messageContent, String messagedOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User fromUser = getUser(fromUserId);
		User toUser = getUser(toUserId);
		
		PrivateMessage privateMessage = new PrivateMessage(toUser, fromUser, messageContent, messagedOn);
		session.save(privateMessage);
		
		transaction.commit();
		session.close();
		
		String text = fromUser.getUsername() + " sent you a message";
		String epoch = HelperController.getEpoch();
		NotificationDao.addNotification(toUser, fromUser, "private message", text, "0", epoch);
	}
	
}
