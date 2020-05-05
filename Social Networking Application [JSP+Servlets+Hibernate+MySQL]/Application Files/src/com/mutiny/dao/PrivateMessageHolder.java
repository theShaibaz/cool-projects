package com.mutiny.dao;

public class PrivateMessageHolder {

	private int messageId;
	private int senderUserId;
	private int receiverUserId;
	private int otherUserId;
	private String messageContent;
	private String messagedOn;
	
	public PrivateMessageHolder() {
		super();
	}
	
	public PrivateMessageHolder(int messageId, int senderUserId, int receiverUserId, int otherUserId, String messageContent,
			String messagedOn) {
		super();
		this.messageId = messageId;
		this.senderUserId = senderUserId;
		this.receiverUserId = receiverUserId;
		this.otherUserId = otherUserId;
		this.messageContent = messageContent;
		this.messagedOn = messagedOn;
	}
	
	public int getMessageId() {
		return messageId;
	}
	
	public void setMessageId(int messageId) {
		this.messageId = messageId;
	}
	
	public int getSenderUserId() {
		return senderUserId;
	}
	
	public void setSenderUserId(int senderUserId) {
		this.senderUserId = senderUserId;
	}
	
	public int getReceiverUserId() {
		return receiverUserId;
	}
	
	public void setReceiverUserId(int receiverUserId) {
		this.receiverUserId = receiverUserId;
	}
	
	public int getOtherUserId() {
		return otherUserId;
	}
	
	public void setOtherUserId(int otherUserId) {
		this.otherUserId = otherUserId;
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
		return "PrivateMessageHolder [messageId=" + messageId + ", senderUserId=" + senderUserId 
				+ ", receiverUserId=" + receiverUserId 
				+ ", otherUserId=" + otherUserId + ", messageContent=" + messageContent + ", messagedOn=" + messagedOn + "]";
	}
}
