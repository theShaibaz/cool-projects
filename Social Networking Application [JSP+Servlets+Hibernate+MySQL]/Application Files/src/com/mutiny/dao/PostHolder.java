package com.mutiny.dao;

public class PostHolder {

	private int postId;
	private int postedBy;
	private String postContent;
	private String postCaption;
	private String postDate;
	private String postType;
	 
	private int postLikes;
	private int postComments;
	private int userLiked;
	
	public PostHolder() {
		super();
	}
	
	public PostHolder(int postId, int postedBy, String postContent, String postCaption, String postDate,
			String postType, int postLikes, int postComments, int userLiked) {
		super();
		this.postId = postId;
		this.postedBy = postedBy;
		this.postContent = postContent;
		this.postCaption = postCaption;
		this.postDate = postDate;
		this.postType = postType;
		this.postLikes = postLikes;
		this.postComments = postComments;
		this.userLiked = userLiked;
	}



	public int getPostId() {
		return postId;
	}

	public void setPostId(int postId) {
		this.postId = postId;
	}

	public int getPostedBy() {
		return postedBy;
	}

	public void setPostedBy(int postedBy) {
		this.postedBy = postedBy;
	}

	public String getPostContent() {
		return postContent;
	}

	public void setPostContent(String postContent) {
		this.postContent = postContent;
	}

	public String getPostCaption() {
		return postCaption;
	}

	public void setPostCaption(String postCaption) {
		this.postCaption = postCaption;
	}

	public String getPostDate() {
		return postDate;
	}

	public void setPostDate(String postDate) {
		this.postDate = postDate;
	}

	public String getPostType() {
		return postType;
	}

	public void setPostType(String postType) {
		this.postType = postType;
	}

	public int getPostLikes() {
		return postLikes;
	}

	public void setPostLikes(int postLikes) {
		this.postLikes = postLikes;
	}

	public int getPostComments() {
		return postComments;
	}

	public void setPostComments(int postComments) {
		this.postComments = postComments;
	}
	
	public int getUserLiked() {
		return userLiked;
	}

	public void setUserLiked(int userLiked) {
		this.userLiked = userLiked;
	}

	@Override
	public String toString() {
		return "UserPosts [postId=" + postId + ", postedBy=" + postedBy + ", postContent=" + postContent
				+ ", postCaption=" + postCaption + ", postDate=" + postDate + ", postType=" + postType + "]";
	}
}
