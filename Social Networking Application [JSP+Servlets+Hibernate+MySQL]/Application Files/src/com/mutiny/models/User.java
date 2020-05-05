package com.mutiny.models;

import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import org.hibernate.annotations.LazyCollection;
import org.hibernate.annotations.LazyCollectionOption;

@Entity
@Table(name = "tbl_users")
public class User {

	@Id
	@Column(name = "user_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int userId;
	
	@Column(name = "username")
	private String username;
	
	@Column(name = "password")
	private String password;

	@OneToOne(mappedBy = "userId", cascade = CascadeType.ALL)
	private UserProfile userProfile;
	
	@OneToMany(mappedBy = "userId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<Friend> friends;
	
	@OneToMany(mappedBy = "createdBy", cascade = CascadeType.ALL)
	private List<Community> communitiesCreated;
	
	@ManyToMany(cascade = CascadeType.ALL)
	@JoinTable(name = "tbl_user_communities", 
			   joinColumns = @JoinColumn(name = "user_id"),
			   inverseJoinColumns = @JoinColumn(name = "community_id"))
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<Community> communities;
	
	@OneToMany(mappedBy = "postedBy", cascade = CascadeType.ALL)
	private List<TextPost> textPosts;
	
	@OneToMany(mappedBy = "likedBy", cascade = CascadeType.ALL)
	private List<TextPostLike> textPostLikes;
	
	@OneToMany(mappedBy = "commentBy", cascade = CascadeType.ALL)
	private List<TextPostComment> textPostComments;
	
	@OneToMany(mappedBy = "postedBy", cascade = CascadeType.ALL)
	private List<MediaPost> mediaPosts;
	
	@OneToMany(mappedBy = "likedBy", cascade = CascadeType.ALL)
	private List<MediaPostLike> mediaPostLikes;
	
	@OneToMany(mappedBy = "commentBy", cascade = CascadeType.ALL)
	private List<MediaPostComment> mediaPostComments;
	
	@OneToMany(mappedBy = "postedBy", cascade = CascadeType.ALL)
	private List<VideoPost> videoPosts;
	
	@OneToMany(mappedBy = "likedBy", cascade = CascadeType.ALL)
	private List<VideoPostLike> videoPostLikes;
	
	@OneToMany(mappedBy = "commentBy", cascade = CascadeType.ALL)
	private List<VideoPostComment> videoPostComments;
	
	@OneToMany(mappedBy = "fromUserId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<PrivateMessage> privateMessagesSent;
	
	@OneToMany(mappedBy = "toUserId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<PrivateMessage> privateMessagesReceived;
	
	@OneToMany(mappedBy = "fromUserId", cascade = CascadeType.ALL)
	private List<CommunityMessage> communityMessagesSent;
	
	@OneToMany(mappedBy = "fromUserId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<FriendRequest> friendsRequestsSent;
	
	@OneToMany(mappedBy = "toUserId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<FriendRequest> friendsRequestsReceived;
	
	
	@OneToMany(mappedBy = "userId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<Notification> notifications;
	
	public User() { 
		super();
	}

	public User(String username, String password) {
		super();
		this.username = username;
		this.password = password;
	}

	public int getUserId() {
		return userId;
	}

	public void setUserId(int userId) {
		this.userId = userId;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public UserProfile getUserProfile() {
		return userProfile;
	}

	public void setUserProfile(UserProfile userProfile) {
		this.userProfile = userProfile;
	}

	public List<Friend> getFriends() {
		return friends;
	}

	public void setFriends(List<Friend> friends) {
		this.friends = friends;
	}

	public List<Community> getCommunitiesCreated() {
		return communitiesCreated;
	}

	public void setCommunitiesCreated(List<Community> communitiesCreated) {
		this.communitiesCreated = communitiesCreated;
	}

	public List<Community> getCommunities() {
		return communities;
	}

	public void setCommunities(List<Community> communities) {
		this.communities = communities;
	}

	public List<TextPost> getTextPosts() {
		return textPosts;
	}

	public void setTextPosts(List<TextPost> textPosts) {
		this.textPosts = textPosts;
	}

	public List<TextPostLike> getTextPostLikes() {
		return textPostLikes;
	}

	public void setTextPostLikes(List<TextPostLike> textPostLikes) {
		this.textPostLikes = textPostLikes;
	}

	public List<TextPostComment> getTextPostComments() {
		return textPostComments;
	}

	public void setTextPostComments(List<TextPostComment> textPostComments) {
		this.textPostComments = textPostComments;
	}

	public List<MediaPost> getMediaPosts() {
		return mediaPosts;
	}

	public void setMediaPosts(List<MediaPost> mediaPosts) {
		this.mediaPosts = mediaPosts;
	}

	public List<MediaPostLike> getMediaPostLikes() {
		return mediaPostLikes;
	}

	public void setMediaPostLikes(List<MediaPostLike> mediaPostLikes) {
		this.mediaPostLikes = mediaPostLikes;
	}

	public List<MediaPostComment> getMediaPostComments() {
		return mediaPostComments;
	}

	public void setMediaPostComments(List<MediaPostComment> mediaPostComments) {
		this.mediaPostComments = mediaPostComments;
	}
	
	public List<VideoPost> getVideoPosts() {
		return videoPosts;
	}

	public void setVideoPosts(List<VideoPost> videoPosts) {
		this.videoPosts = videoPosts;
	}

	public List<VideoPostLike> getVideoPostLikes() {
		return videoPostLikes;
	}

	public void setVideoPostLikes(List<VideoPostLike> videoPostLikes) {
		this.videoPostLikes = videoPostLikes;
	}

	public List<VideoPostComment> getVideoPostComments() {
		return videoPostComments;
	}

	public void setVideoPostComments(List<VideoPostComment> videoPostComments) {
		this.videoPostComments = videoPostComments;
	}

	public List<PrivateMessage> getPrivateMessagesSent() {
		return privateMessagesSent;
	}

	public void setPrivateMessagesSent(List<PrivateMessage> privateMessagesSent) {
		this.privateMessagesSent = privateMessagesSent;
	}

	public List<PrivateMessage> getPrivateMessagesReceived() {
		return privateMessagesReceived;
	}

	public void setPrivateMessagesReceived(List<PrivateMessage> privateMessagesReceived) {
		this.privateMessagesReceived = privateMessagesReceived;
	}

	public List<CommunityMessage> getCommunityMessagesSent() {
		return communityMessagesSent;
	}

	public void setCommunityMessagesSent(List<CommunityMessage> communityMessagesSent) {
		this.communityMessagesSent = communityMessagesSent;
	}

	public List<FriendRequest> getFriendsRequestsSent() {
		return friendsRequestsSent;
	}

	public void setFriendsRequestsSent(List<FriendRequest> friendsRequestsSent) {
		this.friendsRequestsSent = friendsRequestsSent;
	}

	public List<FriendRequest> getFriendsRequestsReceived() {
		return friendsRequestsReceived;
	}

	public void setFriendsRequestsReceived(List<FriendRequest> friendsRequestsReceived) {
		this.friendsRequestsReceived = friendsRequestsReceived;
	}

	public List<Notification> getNotifications() {
		return notifications;
	}

	public void setNotifications(List<Notification> notifications) {
		this.notifications = notifications;
	}

	@Override
	public String toString() {
		return "Users [userId=" + userId + ", username=" + username + "]";
	}

}
