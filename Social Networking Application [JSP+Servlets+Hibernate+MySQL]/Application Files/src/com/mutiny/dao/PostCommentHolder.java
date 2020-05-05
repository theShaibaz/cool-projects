package com.mutiny.dao;

public class PostCommentHolder {

	private int commentId;
	private int postId;
	private int commentBy;
	private String commentContent;
	private String commentOn;
	
	public PostCommentHolder() {
		super();
	}

	public PostCommentHolder(int commentId, int postId, int commentBy, String commentContent, String commentOn) {
		super();
		this.commentId = commentId;
		this.postId = postId;
		this.commentBy = commentBy;
		this.commentContent = commentContent;
		this.commentOn = commentOn;
	}

	public int getCommentId() {
		return commentId;
	}

	public void setCommentId(int commentId) {
		this.commentId = commentId;
	}

	public int getPostId() {
		return postId;
	}

	public void setPostId(int postId) {
		this.postId = postId;
	}

	public int getCommentby() {
		return commentBy;
	}

	public void setCommentby(int commentby) {
		this.commentBy = commentby;
	}

	public String getCommentContent() {
		return commentContent;
	}

	public void setCommentContent(String commentContent) {
		this.commentContent = commentContent;
	}

	public String getCommentOn() {
		return commentOn;
	}

	public void setCommentOn(String commentOn) {
		this.commentOn = commentOn;
	}

	@Override
	public String toString() {
		return "PostCommentHolder [commentId=" + commentId + ", postId=" + postId + ", commentby=" + commentBy
				+ ", commentContent=" + commentContent + ", commentOn=" + commentOn + "]";
	}
}
