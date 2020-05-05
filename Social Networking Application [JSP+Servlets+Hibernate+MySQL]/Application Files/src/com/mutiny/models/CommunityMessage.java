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
@Table(name = "tbl_community_messages")
public class CommunityMessage {

	@Id
	@Column(name = "message_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int messageId;
	
	@JoinColumn(name = "from_user_id")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User fromUserId;
	
	@JoinColumn(name = "community_id")
	@ManyToOne(cascade = CascadeType.ALL)
	private Community communityId;
	
	@Column(name = "message_content")
	private String messageContent;
	
	@Column(name = "messaged_on")
	private String messagedOn;

	public CommunityMessage() {
		super();
	}

	public CommunityMessage(User fromUserId, Community communityId, String messageContent, String messagedOn) {
		super();
		this.fromUserId = fromUserId;
		this.communityId = communityId;
		this.messageContent = messageContent;
		this.messagedOn = messagedOn;
	}

	public int getMessageId() {
		return messageId;
	}

	public void setMessageId(int messageId) {
		this.messageId = messageId;
	}

	public User getFromUserId() {
		return fromUserId;
	}

	public void setFromUserId(User fromUserId) {
		this.fromUserId = fromUserId;
	}

	public Community getCommunityId() {
		return communityId;
	}

	public void setCommunityId(Community communityId) {
		this.communityId = communityId;
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
		return "CommunityMessage [messageId=" + messageId + ", fromUserId=" + fromUserId + ", communityId="
				+ communityId + ", messageContent=" + messageContent + ", messagedOn=" + messagedOn + "]";
	}

}
