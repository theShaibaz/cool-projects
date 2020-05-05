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
@Table(name = "tbl_text_post_likes")
public class TextPostLike {

	@Id
	@Column(name = "like_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int likeId;
	
	@JoinColumn(name = "post_id")
	@ManyToOne(cascade = CascadeType.ALL)
	private TextPost postId;
	
	@JoinColumn(name = "liked_by")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User likedBy;

	@Column(name = "liked_on")
	private String likedOn;
	
	public TextPostLike() {
		super();
	}

	public TextPostLike(TextPost postId, User likedBy, String likedOn) {
		super();
		this.postId = postId;
		this.likedBy = likedBy;
		this.likedOn = likedOn;
	}

	public int getLikeId() {
		return likeId;
	}

	public void setLikeId(int likeId) {
		this.likeId = likeId;
	}

	public TextPost getPostId() {
		return postId;
	}

	public void setPostId(TextPost postId) {
		this.postId = postId;
	}

	public User getLikedBy() {
		return likedBy;
	}

	public void setLikedBy(User likedBy) {
		this.likedBy = likedBy;
	}

	public String getLikedOn() {
		return likedOn;
	}

	public void setLikedOn(String likedOn) {
		this.likedOn = likedOn;
	}

	@Override
	public String toString() {
		return "TextPostLike [likeId=" + likeId + ", postId=" + postId + ", likedBy=" + likedBy + ", likedOn="
				+ likedOn + "]";
	}

}
