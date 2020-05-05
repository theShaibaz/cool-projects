package com.mutiny.models;

import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.hibernate.annotations.LazyCollection;
import org.hibernate.annotations.LazyCollectionOption;

@Entity
@Table(name = "tbl_video_posts")
public class VideoPost {

	@Id
	@Column(name = "post_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int postId;
	
	@JoinColumn(name = "posted_by")
	@ManyToOne(cascade = CascadeType.ALL)
	private User postedBy;
	
	@Column(name = "post_content")
	private byte[] postContent;
	
	@Column(name = "post_caption")
	private String postCaption;
	
	@Column(name = "post_date")
	private String postDate;
	
	@OneToMany(mappedBy = "postId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<VideoPostLike> likes;
	
	@OneToMany(mappedBy = "postId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<VideoPostComment> comments;
	
	public VideoPost() {
		super();
	}

	public VideoPost(User postedBy, byte[] postContent, String postCaption, String postDate) {
		super();
		this.postedBy = postedBy;
		this.postContent = postContent;
		this.postCaption = postCaption;
		this.postDate = postDate;
	}

	public int getPostId() {
		return postId;
	}

	public void setPostId(int postId) {
		this.postId = postId;
	}

	public User getPostedBy() {
		return postedBy;
	}

	public void setPostedBy(User postedBy) {
		this.postedBy = postedBy;
	}

	public byte[] getPostContent() {
		return postContent;
	}

	public void setPostContent(byte[] postContent) {
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

	public List<VideoPostLike> getLikes() {
		return likes;
	}

	public void setLikes(List<VideoPostLike> likes) {
		this.likes = likes;
	}

	public List<VideoPostComment> getComments() {
		return comments;
	}

	public void setComments(List<VideoPostComment> comments) {
		this.comments = comments;
	}

	@Override
	public String toString() {
		return "MediaPost [postId=" + postId + ", postedBy=" + postedBy + ", postContent=" + postContent
				+ ", postCaption=" + postCaption + ", postDate=" + postDate + "]";
	}

}
