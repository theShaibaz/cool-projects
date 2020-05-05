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
@Table(name = "tbl_user_friends")
public class Friend {

	@Id
	@Column(name = "user_friend_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int userFriendId;
	
	@JoinColumn(name = "user_id")
	@ManyToOne(cascade = CascadeType.ALL)
	private User userId;
	
	@JoinColumn(name = "friend_id")
	@ManyToOne(cascade = CascadeType.ALL)
	private User friendId;
	
	@Column(name = "friends_since")
	private String friendsSince;
	
	public Friend() {
		super();
	}

	public Friend(User userId, User friendId, String friendsSince) {
		super();
		this.userId = userId;
		this.friendId = friendId;
		this.friendsSince = friendsSince;
	}

	public int getUserFriendId() {
		return userFriendId;
	}

	public void setUserFriendId(int userFriendId) {
		this.userFriendId = userFriendId;
	}

	public User getUserId() {
		return userId;
	}

	public void setUserId(User userId) {
		this.userId = userId;
	}

	public User getFriendId() {
		return friendId;
	}

	public void setFriendId(User friendId) {
		this.friendId = friendId;
	}

	public String getFriendsSince() {
		return friendsSince;
	}

	public void setFriendsSince(String friendsSince) {
		this.friendsSince = friendsSince;
	}

	@Override
	public String toString() {
		return "UserFriend [userFriendId=" + userFriendId + ", userId=" + userId + ", friendId=" + friendId
				+ ", friendsSince=" + friendsSince + "]";
	}

}
