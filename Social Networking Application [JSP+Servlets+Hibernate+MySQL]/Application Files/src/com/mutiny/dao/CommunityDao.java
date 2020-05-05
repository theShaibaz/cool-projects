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
import com.mutiny.models.Community;
import com.mutiny.models.CommunityMessage;
import com.mutiny.models.User;

@SuppressWarnings({"rawtypes","unchecked"})
public class CommunityDao {

	private CommunityDao() {
		 
	} 
	
	public static Community getCommunity(int communityId) {
		
		Session session = Utility.FACTORY.openSession();
		
		Community community = session.get(Community.class, communityId);
		
		session.close();
		return community;
	}
	   
	public static Community getCommunity(String communityName) {
		
		Session session = Utility.FACTORY.openSession();
		
		String hqlQuery = "from Community c where c.communityName = '" + communityName + "'";
		List<Community> result = session.createQuery(hqlQuery).getResultList();
		
		session.close();
		return result.get(0);
	}
	
	public static String getCommunityName(int communityId) {
		
		return getCommunity(communityId).getCommunityName();
	}
	
	public static int getCommunityId(String communityName) {
		
		return getCommunity(communityName).getCommunityId();
	}
	
	public static List<Community> getCommunities(int userId) {
		
		return UserDao.getUser(userId).getCommunities();
	}
	
	public static int addCommunity(String communityName, String communityDesc, String createdOn, int createdBy,
			List<Integer> memberIds, File communityPicture) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		int returnCommunityId = -1;
		
		User admin = UserDao.getUser(createdBy);
		
		ArrayList<User> members = new ArrayList<User>();
		for (Integer userId : memberIds) {
			
			User temp = UserDao.getUser(userId);
			members.add(temp);
		}
		members.add(admin);
		
		byte[] bfile = new byte[(int) communityPicture.length()];
		FileInputStream fis;
		
		try {
			fis = new FileInputStream(communityPicture);
			fis.read(bfile);
			fis.close();
			
			Community community = new Community(communityName, communityDesc, bfile, members.size(), createdOn, admin);
			community.setUsers(members);
			session.save(community);
			
			transaction.commit();
			session.close();
			
			String text = admin.getUsername() + " added you to community \"" + communityName + "\"";
			String epoch = HelperController.getEpoch();
			
			for(User member : members) {
				
				if(admin.getUserId() != member.getUserId()) {
					NotificationDao.addNotification(member, admin, "Added to Community", text, "0", epoch);
				}
			}
			
			returnCommunityId = getCommunity(communityName).getCommunityId();
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		return returnCommunityId;
	} 
	
	public static String getCommunityPicture(int communityId) {
		
		Community community = getCommunity(communityId);
		
		String filePath = HelperController.DEFAULT_PATH + "community_" + community.getCommunityId() + ".jpg";
		byte[] picture = community.getCommunityPicture();
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
	
	public static List<CommunityMessage> getCommunityMessages(int communityId) {
		
		List<CommunityMessage> communityMessages = getCommunity(communityId).getMessages();
		
		communityMessages.sort((messageOne,messageTwo)-> messageOne.getMessagedOn().compareTo(messageTwo.getMessagedOn()) * -1);
		
		return communityMessages;
	}
	
	public static List<List> getCommunityMessageList(int userId) {
		
		User user = UserDao.getUser(userId);
		
		List<Community> communities = user.getCommunities();
		ArrayList<List> communityMessages = new ArrayList<List>();

		for(Community community : communities) {
			
			List<CommunityMessage> messages = community.getMessages();
			if(messages.size() > 0) {
				messages.sort((messageOne,messageTwo)-> messageOne.getMessagedOn().compareTo(messageTwo.getMessagedOn()) * -1);
				communityMessages.add(new ArrayList<CommunityMessage>(messages));
			}
		}
		
		communityMessages.sort((listOne,listTwo)->
		((CommunityMessage)listOne.get(0)).getMessagedOn().compareTo(((CommunityMessage)listTwo.get(0)).getMessagedOn()) * -1);
		
		return communityMessages;
	}
	
	public static void addCommunityMessage(int fromUserId, int communityId, String messageContent, String messagedOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = UserDao.getUser(fromUserId);
		Community community = getCommunity(communityId);
		
		CommunityMessage communityMessage = new CommunityMessage(user, community, messageContent, messagedOn);
		session.save(communityMessage);
		
		transaction.commit();
		session.close();
		
		String epoch = HelperController.getEpoch();
		String text = user.getUsername() + " sent a message in community \"" + community.getCommunityName() + "\"";
		
		List<User> members = community.getUsers();
		for(User member : members) {
			
			if(member.getUserId() != user.getUserId()) {
				NotificationDao.addNotification(member, user, "community message", text, "0", epoch);
			}
		}
	}
	
}
