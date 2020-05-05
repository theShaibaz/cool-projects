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
@Table(name = "tbl_video_post_comments")
public class VideoPostComment {

	@Id
	@Column(name = "comment_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int commentId;
	
	@JoinColumn(name = "post_id")
	@ManyToOne(cascade = CascadeType.ALL)
	private VideoPost postId;
	
	@JoinColumn(name = "comment_by")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User commentBy;
	
	@Column(name = "comment_content")
	private String commentContent;
	
	@Column(name = "comment_on")
	private String commentOn;

	public VideoPostComment() {
		super();
	}

	public VideoPostComment(VideoPost postId, User commentBy, String commentContent, String commentOn) {
		super();
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

	public VideoPost getPostId() {
		return postId;
	}

	public void setPostId(VideoPost postId) {
		this.postId = postId;
	}

	public User getCommentBy() {
		return commentBy;
	}

	public void setCommentBy(User commentBy) {
		this.commentBy = commentBy;
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
		return "MediaPostComment [commentId=" + commentId + ", postId=" + postId + ", commentBy=" + commentBy
				+ ", commentContent=" + commentContent + ", commentOn=" + commentOn + "]";
	}

}
