package com.mutiny.models;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "tbl_user_notifications")
public class Notification {

	@Id
	@Column(name = "notification_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int notificationId;

	@JoinColumn(name = "user_id")
	@ManyToOne(cascade = CascadeType.ALL)
	private User userId;
	
	@JoinColumn(name = "other_user_id")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User otherUserId;

	@JoinColumn(name = "notification_type")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private NotificationType notificationType;
	
	@Column(name = "notification_text")
	private String notificationText;
	
	@Column(name = "is_read")
	private String isRead;
	
	@Column(name = "notification_date")
	private String notificationDate;

	public Notification() {
		super();
	}

	public Notification(String notificationText, String isRead,
			String notificationDate) {
		super();
		this.notificationText = notificationText;
		this.isRead = isRead;
		this.notificationDate = notificationDate;
	}

	public int getNotificationId() {
		return notificationId;
	}

	public void setNotificationId(int notificationId) {
		this.notificationId = notificationId;
	}

	public User getUserId() {
		return userId;
	}

	public void setUserId(User userId) {
		this.userId = userId;
	}

	public User getOtherUserId() {
		return otherUserId;
	}

	public void setOtherUserId(User otherUserId) {
		this.otherUserId = otherUserId;
	}

	public NotificationType getNotificationType() {
		return notificationType;
	}

	public void setNotificationType(NotificationType notificationType) {
		this.notificationType = notificationType;
	}

	public String getNotificationText() {
		return notificationText;
	}

	public void setNotificationText(String notificationText) {
		this.notificationText = notificationText;
	}

	public String getIsRead() {
		return isRead;
	}

	public void setIsRead(String isRead) {
		this.isRead = isRead;
	}

	public String getNotificationDate() {
		return notificationDate;
	}

	public void setNotificationDate(String notificationDate) {
		this.notificationDate = notificationDate;
	}

	@Override
	public String toString() {
		return "UserNotification [notificationId=" + notificationId + ", userId=" + userId + ", notificationType="
				+ notificationType + ", notificationText=" + notificationText + ", isRead=" + isRead
				+ ", notificationDate=" + notificationDate + "]";
	}
	
}
