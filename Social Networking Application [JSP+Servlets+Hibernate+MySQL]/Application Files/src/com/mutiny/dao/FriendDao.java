package com.mutiny.dao;

import java.util.List;
import java.util.ListIterator;

import org.hibernate.Session;
import org.hibernate.Transaction;

import com.mutiny.controllers.HelperController;
import com.mutiny.models.Friend;
import com.mutiny.models.FriendRequest;
import com.mutiny.models.User;

public class FriendDao {

	private FriendDao() {
		 
	} 
	  
	public static List<Friend> getFriends(int userId) {
		
		return UserDao.getUser(userId).getFriends();
	}
	
	public static boolean areFriends(int userId, int profileId) {
		
		List<Friend> friends = getFriends(userId);
		
		for(Friend friend : friends) {
			
			if(friend.getFriendId().getUserId() == profileId) {
				return true;
			}
		}
		
		return false;
	}
	
	public static FriendRequest getFriendRequest(int requestId) {
		
		Session session = Utility.FACTORY.openSession();
		
		FriendRequest friendRequest = session.get(FriendRequest.class, requestId);
		
		session.close();
		return friendRequest;
	}
	
	public static List<FriendRequest> getFriendRequestsReceived(int userId) {
		
		User user = UserDao.getUser(userId);
		
		List<FriendRequest> friendsRequests = user.getFriendsRequestsReceived();
		ListIterator<FriendRequest> iterator = friendsRequests.listIterator();
		
		while(iterator.hasNext()) {
			
			FriendRequest next = iterator.next();
			if(next.getIsPending().equals("0")) {
				iterator.remove();
			}
		}
		
		return friendsRequests;
	}
	
	public static List<FriendRequest> getFriendRequestsSent(int userId) {
		
		User user = UserDao.getUser(userId);
		
		List<FriendRequest> friendsRequests = user.getFriendsRequestsSent();
		ListIterator<FriendRequest> iterator = friendsRequests.listIterator();
		
		while(iterator.hasNext()) {
			
			FriendRequest next = iterator.next();
			if(next.getIsPending().equals("0")) {
				iterator.remove();
			}
		}
		
		return friendsRequests;
	}
	
	public static void addFriendRequest(int fromUserId, int toUserId, String requestDate) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User fromUser = UserDao.getUser(fromUserId);
		User toUser = UserDao.getUser(toUserId);
		
		FriendRequest friendRequest = new FriendRequest(fromUser, toUser, requestDate, "1", null);
		session.save(friendRequest);
		
		transaction.commit();
		session.close();
		
		String epoch = HelperController.getEpoch();
		String text = fromUser.getUsername() + " has sent you friend request";
		NotificationDao.addNotification(toUser, fromUser, "Friend Request", text, "0", epoch);
		
	}
	 
	public static void updateFriendRequest(int requestId, String result) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		FriendRequest friendRequest = getFriendRequest(requestId);
		friendRequest.setIsPending("0");
		friendRequest.setRequestResult(result);
		session.update(friendRequest);
		
		if(result.equalsIgnoreCase("A")) {
			
			User fromUserId = friendRequest.getFromUserId();
			User toUserId = friendRequest.getToUserId();
			String epoch = HelperController.getEpoch();
			
			Friend userFriend = new Friend(fromUserId, toUserId, epoch);
			session.save(userFriend);
			
			userFriend = new Friend(toUserId,fromUserId, epoch);
			session.save(userFriend);
			
			transaction.commit();
			session.close();
			
			String text = toUserId.getUsername() + " has accepted your friend request";
			NotificationDao.addNotification(fromUserId, toUserId, "Request Accept", text, "0", epoch);
		}
		else {
			
			transaction.commit();
			session.close();
		}
		
	}
}
