package com.mutiny.models;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import javax.persistence.Table;

@Entity
@Table(name = "tbl_user_profiles")
public class UserProfile {

	@Id
	@Column(name = "profile_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int profileId;
	
	@JoinColumn(name = "user_id")
	@OneToOne(cascade = CascadeType.ALL)
	private User userId;
	
	@Column(name = "birthdate")
	private String birthdate;
	
	@Column(name = "gender")
	private String gender;
	
	@Column(name = "status")
	private String status;
	
	@Column(name = "profile_picture")
	private byte[] profilePicture;
	
	@Column(name = "last_login")
	private String lastLogin;
	
	@Column(name = "joined_on")
	private String joinedOn;
	
	@Column(name = "is_online")
	private String isOnline;
	
	public UserProfile() {
		super();
	}

	public UserProfile(String birthdate, String gender, String lastLogin, String joinedOn, String isOnline) {
		super();
		this.birthdate = birthdate;
		this.gender = gender;
		this.lastLogin = lastLogin;
		this.joinedOn = joinedOn;
		this.isOnline = isOnline;
	}

	public int getProfileId() {
		return profileId;
	}

	public void setProfileId(int profileId) {
		this.profileId = profileId;
	}

	public User getUserId() {
		return userId;
	}

	public void setUserId(User userId) {
		this.userId = userId;
	}

	public String getBirthdate() {
		return birthdate;
	}

	public void setBirthdate(String birthdate) {
		this.birthdate = birthdate;
	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public String getStatus() {
		return status;
	}

	public void setStatus(String status) {
		this.status = status;
	}

	public byte[] getProfilePicture() {
		return profilePicture;
	}

	public void setProfilePicture(byte[] profilePicture) {
		this.profilePicture = profilePicture;
	}

	public String getLastLogin() {
		return lastLogin;
	}

	public void setLastLogin(String lastLogin) {
		this.lastLogin = lastLogin;
	}

	public String getJoinedOn() {
		return joinedOn;
	}

	public void setJoinedOn(String joinedOn) {
		this.joinedOn = joinedOn;
	}

	public String getIsOnline() {
		return isOnline;
	}

	public void setIsOnline(String isOnline) {
		this.isOnline = isOnline;
	}

	@Override
	public String toString() {
		return "UserProfile [profileId=" + profileId + ", userId=" + userId + ", birthdate=" + birthdate + ", gender="
				+ gender + ", status=" + status + ", profilePicture=" + profilePicture + ", lastLogin=" + lastLogin
				+ ", joinedOn=" + joinedOn + ", isOnline=" + isOnline + "]";
	}

}
