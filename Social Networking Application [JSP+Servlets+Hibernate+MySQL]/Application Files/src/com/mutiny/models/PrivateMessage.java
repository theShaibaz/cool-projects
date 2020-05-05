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
@Table(name = "tbl_private_messages")
public class PrivateMessage {

	@Id
	@Column(name = "message_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int messageId;
	
	@JoinColumn(name = "to_user_id")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User toUserId;
	
	@JoinColumn(name = "from_user_id")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User fromUserId;
	
	@Column(name = "message_content")
	private String messageContent;
	
	@Column(name = "messaged_on")
	private String messagedOn;

	public PrivateMessage() {
		super();
	}

	public PrivateMessage(User toUserId, User fromUserId, String messageContent, String messagedOn) {
		super();
		this.toUserId = toUserId;
		this.fromUserId = fromUserId;
		this.messageContent = messageContent;
		this.messagedOn = messagedOn;
	}

	public int getMessageId() {
		return messageId;
	}

	public void setMessageId(int messageId) {
		this.messageId = messageId;
	}

	public User getToUserId() {
		return toUserId;
	}

	public void setToUserId(User toUserId) {
		this.toUserId = toUserId;
	}

	public User getFromUserId() {
		return fromUserId;
	}

	public void setFromUserId(User fromUserId) {
		this.fromUserId = fromUserId;
	}

	public String getMessageContent() {
		return messageContent;
	}

	public void setMessageContent(String messageContent) {
		this.messageContent = messageContent;
	}

	public String getMessagedOn() {
		return messagedOn;
	}

	public void setMessagedOn(String messagedOn) {
		this.messagedOn = messagedOn;
	}

	@Override
	public String toString() {
		return "PrivateMessage [messageId=" + messageId + ", toUserId=" + toUserId + ", fromUserId=" + fromUserId
				+ ", messageContent=" + messageContent + ", messagedOn=" + messagedOn + "]";
	}

}
