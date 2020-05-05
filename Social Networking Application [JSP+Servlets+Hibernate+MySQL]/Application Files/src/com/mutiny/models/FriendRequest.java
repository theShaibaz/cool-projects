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
@Table(name = "tbl_friend_requests")
public class FriendRequest {

	@Id
	@Column(name = "request_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int requestId;
	
	@JoinColumn(name = "from_user_id")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User fromUserId;
	
	@JoinColumn(name = "to_user_id")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User toUserId;
	
	@Column(name = "request_date")
	private String requestDate;
	
	@Column(name = "is_pending")
	private String isPending;
	
	@Column(name = "request_result")
	private String requestResult;
	
	public FriendRequest() {
		super();
	}

	public FriendRequest(User fromUserId, User toUserId, String requestDate, String isPending, String requestResult) {
		super();
		this.fromUserId = fromUserId;
		this.toUserId = toUserId;
		this.requestDate = requestDate;
		this.isPending = isPending;
		this.requestResult = requestResult;
	}

	public int getRequestId() {
		return requestId;
	}

	public void setRequestId(int requestId) {
		this.requestId = requestId;
	}

	public User getFromUserId() {
		return fromUserId;
	}

	public void setFromUserId(User fromUserId) {
		this.fromUserId = fromUserId;
	}

	public User getToUserId() {
		return toUserId;
	}

	public void setToUserId(User toUserId) {
		this.toUserId = toUserId;
	}

	public String getRequestDate() {
		return requestDate;
	}

	public void setRequestDate(String requestDate) {
		this.requestDate = requestDate;
	}

	public String getIsPending() {
		return isPending;
	}

	public void setIsPending(String isPending) {
		this.isPending = isPending;
	}

	public String getRequestResult() {
		return requestResult;
	}

	public void setRequestResult(String requestResult) {
		this.requestResult = requestResult;
	}

	@Override
	public String toString() {
		return "FriendRequest [requestId=" + requestId + ", fromUserId=" + fromUserId + ", toUserId=" + toUserId
				+ ", requestDate=" + requestDate + ", isPending=" + isPending + ", requestResult=" + requestResult
				+ "]";
	}

}
