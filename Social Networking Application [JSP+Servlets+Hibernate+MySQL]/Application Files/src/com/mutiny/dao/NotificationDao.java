package com.mutiny.dao;

import java.util.List;
import java.util.ListIterator;

import org.hibernate.Session;
import org.hibernate.Transaction;

import com.mutiny.models.NotificationType;
import com.mutiny.models.User;
import com.mutiny.models.Notification;

@SuppressWarnings({"unchecked"})
public class NotificationDao {

	private NotificationDao() {
		
	} 
	
	public static NotificationType getNotificationType(String notificationType) {
		
		Session session = Utility.FACTORY.openSession();
		 
		String hqlQuery = "from NotificationType nt where nt.typeName = '" + notificationType + "'";
		List<NotificationType> result = session.createQuery(hqlQuery).getResultList();
		
		session.close();
		return result.get(0);
	}	
	
	public static Notification getNotification(int notificationId) {
		
		Session session = Utility.FACTORY.openSession();
		
		Notification notification = session.get(Notification.class, notificationId);
		
		session.close();
		return notification;
	}
	
	public static List<Notification> getNotifications(int userId) {
		
		User user = UserDao.getUser(userId);

		List<Notification> notifications = user.getNotifications();
		ListIterator<Notification> iterator = notifications.listIterator();
		
		while(iterator.hasNext()) {
			
			Notification next = iterator.next();
			if(next.getIsRead().equals("1") 
			|| next.getNotificationType().getTypeName().equalsIgnoreCase("private message")
			|| next.getNotificationType().getTypeName().equalsIgnoreCase("community message")) {
				iterator.remove();
			}
		}
		
		notifications.sort((notificationOne,notificationTwo)-> 
		notificationOne.getNotificationDate().compareTo(notificationTwo.getNotificationDate()) * -1);
		
		return notifications;
	}
	
	public static List<Notification> getMessageNotifications(int userId) {
		
		User user = UserDao.getUser(userId);
		
		List<Notification> notifications = user.getNotifications();
		ListIterator<Notification> iterator = notifications.listIterator();
		
		while(iterator.hasNext()) {
			
			Notification next = iterator.next();
			if(next.getIsRead().equals("1") 
			|| !next.getNotificationType().getTypeName().equalsIgnoreCase("private message")
			&& !next.getNotificationType().getTypeName().equalsIgnoreCase("community message")) {
				iterator.remove();
			}
		}
		
		notifications.sort((notificationOne,notificationTwo)->
		notificationOne.getNotificationDate().compareTo(notificationTwo.getNotificationDate()) * -1);
		
		return notifications;
	}
	
	public static void readNotification(int notificationId) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		Notification notification = getNotification(notificationId);
		notification.setIsRead("1");
		session.update(notification);
		
		transaction.commit();
		session.close();
	}
	
	public static void readNotifications(int userId) {
		
		User user = UserDao.getUser(userId);
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		List<Notification> notifications = user.getNotifications();
		ListIterator<Notification> iterator = notifications.listIterator();
		
		while(iterator.hasNext()) {
			
			Notification next = iterator.next();
			if(next.getIsRead().equals("0") 
			   && !next.getNotificationType().getTypeName().equalsIgnoreCase("private message")
			   && !next.getNotificationType().getTypeName().equalsIgnoreCase("community message")) {
				next.setIsRead("1");
			}
		}
		
		user.setNotifications(notifications);
		session.update(user);
		
		transaction.commit();
		session.close();
	}
	
	public static void readMessageNotifications(int userId) {
		
		User user = UserDao.getUser(userId);
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		List<Notification> notifications = user.getNotifications();
		ListIterator<Notification> iterator = notifications.listIterator();
		
		while(iterator.hasNext()) {
			
			Notification next = iterator.next();
			if(next.getIsRead().equals("0") 
			   && next.getNotificationType().getTypeName().equalsIgnoreCase("private message")
			   || next.getNotificationType().getTypeName().equalsIgnoreCase("community message")) {
				next.setIsRead("1");
			}
		}
		
		user.setNotifications(notifications);
		session.update(user);
		
		transaction.commit();
		session.close();
	}
	
	public static void addNotification(User user, User otherUser, String notificationType, String text, String isRead, String date) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		Notification notification = new Notification(text, isRead, date);
		NotificationType type = getNotificationType(notificationType);
		notification.setUserId(user);
		notification.setOtherUserId(otherUser);
		notification.setNotificationType(type);
		session.save(notification);
		
		transaction.commit();
		session.close();
	}
	
}
