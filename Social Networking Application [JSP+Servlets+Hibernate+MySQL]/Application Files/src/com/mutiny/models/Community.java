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
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.hibernate.annotations.LazyCollection;
import org.hibernate.annotations.LazyCollectionOption;

@Entity
@Table(name = "tbl_Communities")
public class Community {

	@Id
	@Column(name = "community_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int communityId;
	
	@Column(name = "community_name")
	private String communityName;
	
	@Column(name = "community_picture")
	private byte[] communityPicture;
	
	@Column(name = "community_desc")
	private String communityDesc;
	
	@Column(name = "members_count")
	private int membersCount;
	
	@Column(name = "created_on")
	private String createdOn;
	
	@JoinColumn(name = "created_by")
	@ManyToOne(cascade = CascadeType.PERSIST)
	private User createdBy;
	
	@ManyToMany(cascade = CascadeType.PERSIST)
	@JoinTable(name = "tbl_user_communities", 
			   joinColumns = @JoinColumn(name = "community_id"),
			   inverseJoinColumns = @JoinColumn(name = "user_id"))
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<User> Users;

	@OneToMany(mappedBy = "communityId", cascade = CascadeType.ALL)
	@LazyCollection(LazyCollectionOption.FALSE)
	private List<CommunityMessage> messages;
	
	public Community() {
		super();
	}

	public Community(String communityName, String communityDesc, byte[] communityPicture, int membersCount, String createdOn, User createdBy) {
		super();
		this.communityName = communityName;
		this.communityDesc = communityDesc;
		this.communityPicture = communityPicture;
		this.membersCount = membersCount;
		this.createdOn = createdOn;
		this.createdBy = createdBy;
	}

	public int getCommunityId() {
		return communityId;
	}

	public void setCommunityId(int communityId) {
		this.communityId = communityId;
	}

	public String getCommunityName() {
		return communityName;
	}

	public void setCommunityName(String communityName) {
		this.communityName = communityName;
	}

	public String getCommunityDesc() {
		return communityDesc;
	}

	public void setCommunityDesc(String communityDesc) {
		this.communityDesc = communityDesc;
	}

	public int getMembersCount() {
		return membersCount;
	}

	public void setMembersCount(int membersCount) {
		this.membersCount = membersCount;
	}

	public String getCreatedOn() {
		return createdOn;
	}

	public void setCreatedOn(String createdOn) {
		this.createdOn = createdOn;
	}

	public User getCreatedBy() {
		return createdBy;
	}

	public void setCreatedBy(User createdBy) {
		this.createdBy = createdBy;
	}

	public List<User> getUsers() {
		return Users;
	}

	public void setUsers(List<User> User) {
		this.Users = User;
	}

	public List<CommunityMessage> getMessages() {
		return messages;
	}

	public void setMessages(List<CommunityMessage> messages) {
		this.messages = messages;
	}

	public byte[] getCommunityPicture() {
		return communityPicture;
	}

	public void setCommunityPicture(byte[] communityPicture) {
		this.communityPicture = communityPicture;
	}

	@Override
	public String toString() {
		return "Community [communityId=" + communityId + ", communityName=" + communityName + ", communityDesc="
				+ communityDesc + ", membersCount=" + membersCount + ", createdOn=" + createdOn + ", createdBy="
				+ createdBy + "]";
	}

}
