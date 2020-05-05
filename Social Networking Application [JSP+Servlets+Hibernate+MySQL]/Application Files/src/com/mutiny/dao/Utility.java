package com.mutiny.dao;

import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import com.mutiny.models.Community;
import com.mutiny.models.CommunityMessage;
import com.mutiny.models.FriendRequest;
import com.mutiny.models.MediaPost;
import com.mutiny.models.MediaPostComment;
import com.mutiny.models.MediaPostLike;
import com.mutiny.models.NotificationType;
import com.mutiny.models.PrivateMessage;
import com.mutiny.models.TextPost;
import com.mutiny.models.TextPostComment;
import com.mutiny.models.TextPostLike;
import com.mutiny.models.User;
import com.mutiny.models.Friend;
import com.mutiny.models.Notification;
import com.mutiny.models.UserProfile;
import com.mutiny.models.VideoPost;
import com.mutiny.models.VideoPostComment;
import com.mutiny.models.VideoPostLike;

public class Utility {

	private Utility() {
		
	}
	
	public static final SessionFactory FACTORY;
	
	static { 
		 
		Configuration config = new Configuration();
		config.configure();
		config.addAnnotatedClass(User.class);
		config.addAnnotatedClass(UserProfile.class);
		config.addAnnotatedClass(Friend.class);
		config.addAnnotatedClass(TextPost.class);
		config.addAnnotatedClass(TextPostLike.class);
		config.addAnnotatedClass(TextPostComment.class);
		config.addAnnotatedClass(MediaPost.class);
		config.addAnnotatedClass(MediaPostLike.class);
		config.addAnnotatedClass(MediaPostComment.class);
		config.addAnnotatedClass(VideoPost.class);
		config.addAnnotatedClass(VideoPostLike.class);
		config.addAnnotatedClass(VideoPostComment.class);
		config.addAnnotatedClass(PrivateMessage.class);
		config.addAnnotatedClass(FriendRequest.class);
		config.addAnnotatedClass(Community.class);
		config.addAnnotatedClass(CommunityMessage.class);
		config.addAnnotatedClass(NotificationType.class);
		config.addAnnotatedClass(Notification.class);
		FACTORY = config.buildSessionFactory();
	}
	
}
