package com.mutiny.dao;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.ListIterator;

import org.hibernate.Session;
import org.hibernate.Transaction;

import com.mutiny.controllers.HelperController;
import com.mutiny.models.Friend;
import com.mutiny.models.MediaPost;
import com.mutiny.models.MediaPostComment;
import com.mutiny.models.MediaPostLike;
import com.mutiny.models.TextPost;
import com.mutiny.models.TextPostComment;
import com.mutiny.models.TextPostLike;
import com.mutiny.models.User;
import com.mutiny.models.VideoPost;
import com.mutiny.models.VideoPostComment;
import com.mutiny.models.VideoPostLike;

@SuppressWarnings({"unchecked"})
public class PostDao {

	private PostDao() {
		 
	}
	 
	public static TextPost getTextPost(int postId) {
		 
		Session session = Utility.FACTORY.openSession();
		
		TextPost textPost = session.get(TextPost.class, postId);
		
		session.close();
		return textPost;
	}
	
	public static MediaPost getMediaPost(int postId) {
		
		Session session = Utility.FACTORY.openSession();
		
		MediaPost mediaPost = session.get(MediaPost.class, postId);
		
		session.close();
		return mediaPost;
	}
	
	public static VideoPost getVideoPost(int postId) {
		
		Session session = Utility.FACTORY.openSession();
		
		VideoPost videoPost = session.get(VideoPost.class, postId);
		
		session.close();
		return videoPost;
	}
	
	public static PostHolder getTextPost(int postId, int userId) {
		
		TextPost post = getTextPost(postId);
		
		int pId = post.getPostId();
		int uId = post.getPostedBy().getUserId();
		String pContent = post.getPostContent();
		String pCaption = post.getPostCaption();
		String pDate = post.getPostDate();
		String pType = "text";
		
		int likes = post.getLikes().size();
		int comments = post.getComments().size();
		
		List<TextPostLike> postLikes = post.getLikes();
		ListIterator<TextPostLike> likeIterator = postLikes.listIterator();
		int userLiked = 0;
		while(likeIterator.hasNext()) {
			
			TextPostLike like = likeIterator.next();
			if(like.getLikedBy().getUserId() == userId) {
				userLiked = 1;
				break;
			}
		}
		
		PostHolder userPost = new PostHolder(pId, uId, pContent, pCaption, pDate, pType, likes, comments, userLiked);
		
		return userPost;
	}
	
	public static PostHolder getMediaPost(int postId, int userId) {
		
		MediaPost post = getMediaPost(postId);
		
		int pId = post.getPostId();
		int uId = post.getPostedBy().getUserId();
		byte[] pContent = post.getPostContent();
		String pCaption = post.getPostCaption();
		String pDate = post.getPostDate();
		String pType = "media";
		
		String path = HelperController.DEFAULT_PATH + "media_" + pId + ".jpg";
		FileOutputStream fos = null;
		
		try {
			fos = new FileOutputStream(path);
			fos.write(pContent);
			fos.close();
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		int likes = post.getLikes().size();
		int comments = post.getComments().size();
		
		List<MediaPostLike> postLikes = post.getLikes();
		ListIterator<MediaPostLike> likeIterator = postLikes.listIterator();
		int userLiked = 0;
		while(likeIterator.hasNext()) {
			
			MediaPostLike like = likeIterator.next();
			if(like.getLikedBy().getUserId() == userId) {
				userLiked = 1;
				break;
			}
		}
		
		PostHolder userPost = new PostHolder(pId, uId, path, pCaption, pDate, pType, likes, comments, userLiked);
		
		return userPost;
	}
	
	public static PostHolder getVideoPost(int postId, int userId) {
		
		VideoPost post = getVideoPost(postId);
		
		int pId = post.getPostId();
		int uId = post.getPostedBy().getUserId();
		byte[] pContent = post.getPostContent();
		String pCaption = post.getPostCaption();
		String pDate = post.getPostDate();
		String pType = "media";
		
		String path = HelperController.DEFAULT_PATH + "media_" + pId + ".mp4";
		FileOutputStream fos = null;
		
		try {
			fos = new FileOutputStream(path);
			fos.write(pContent);
			fos.close();
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		int likes = post.getLikes().size();
		int comments = post.getComments().size();
		
		List<VideoPostLike> postLikes = post.getLikes();
		ListIterator<VideoPostLike> likeIterator = postLikes.listIterator();
		int userLiked = 0;
		while(likeIterator.hasNext()) {
			
			VideoPostLike like = likeIterator.next();
			if(like.getLikedBy().getUserId() == userId) {
				userLiked = 1;
				break;
			}
		}
		
		PostHolder userPost = new PostHolder(pId, uId, path, pCaption, pDate, pType, likes, comments, userLiked);
		
		return userPost;
	}
	
	public static List<PostCommentHolder> getTextPostComments(int pId) {
		
		TextPost textPost = getTextPost(pId);
		List<TextPostComment> comments = textPost.getComments();
		 
		List<PostCommentHolder> postComments = new ArrayList<PostCommentHolder>();
		for (TextPostComment textPostComment : comments) {
			
			int commentId = textPostComment.getCommentId();
			int postId = textPostComment.getPostId().getPostId();
			int commentBy = textPostComment.getCommentBy().getUserId();
			String commentContent = textPostComment.getCommentContent();
			String commentOn = textPostComment.getCommentOn();
			
			PostCommentHolder postCommentHolder = new PostCommentHolder(commentId, postId, commentBy, commentContent, commentOn);
			postComments.add(postCommentHolder);
		}
		
		return postComments;
	}
	
	public static List<PostCommentHolder> getMediaPostComments(int pId) {
		
		MediaPost mediaPost = getMediaPost(pId);
		List<MediaPostComment> comments = mediaPost.getComments();
		
		List<PostCommentHolder> postComments = new ArrayList<PostCommentHolder>();
		for (MediaPostComment mediaPostComment : comments) {
			
			int commentId = mediaPostComment.getCommentId();
			int postId = mediaPostComment.getPostId().getPostId();
			int commentBy = mediaPostComment.getCommentBy().getUserId();
			String commentContent = mediaPostComment.getCommentContent();
			String commentOn = mediaPostComment.getCommentOn();
			
			PostCommentHolder postCommentHolder = new PostCommentHolder(commentId, postId, commentBy, commentContent, commentOn);
			postComments.add(postCommentHolder);
		}
		
		return postComments;
	}
	
	public static List<PostCommentHolder> getVideoPostComments(int pId) {
		
		VideoPost videoPost = getVideoPost(pId);
		List<VideoPostComment> comments = videoPost.getComments();
		
		List<PostCommentHolder> postComments = new ArrayList<PostCommentHolder>();
		for (VideoPostComment videoPostComment : comments) {
			
			int commentId = videoPostComment.getCommentId();
			int postId = videoPostComment.getPostId().getPostId();
			int commentBy = videoPostComment.getCommentBy().getUserId();
			String commentContent = videoPostComment.getCommentContent();
			String commentOn = videoPostComment.getCommentOn();
			
			PostCommentHolder postCommentHolder = new PostCommentHolder(commentId, postId, commentBy, commentContent, commentOn);
			postComments.add(postCommentHolder);
		}
		
		return postComments;
	}
	
	public static List<PostHolder> getUserPosts(int userId) {
		
		User user = UserDao.getUser(userId);
		
		String ids = user.getUserId() + "";
		return getAllPosts(ids, userId);
	}
	
	public static List<PostHolder> getFriendPosts(int userId) {
		
		User user = UserDao.getUser(userId);
		
		String ids = "";
		List<Friend> friends = user.getFriends();
		
		for (Friend friend : friends) {
			ids += friend.getFriendId().getUserId() + ",";
		}
		ids += userId;
		
		return getAllPosts(ids, userId);
	}
	
	private static List<PostHolder> getAllPosts(String ids, int userId) {
		
		Session session = Utility.FACTORY.openSession();
		
		List<PostHolder> allPosts = new ArrayList<PostHolder>();
		
		String hqlQuery = "from TextPost tp where tp.postedBy in (" + ids + ")";
		List<TextPost> textPosts = session.createQuery(hqlQuery).getResultList();
		
		for(TextPost testPost : textPosts) {
			
			int pId = testPost.getPostId();
			int uId = testPost.getPostedBy().getUserId();
			String pContent = testPost.getPostContent();
			String pCaption = testPost.getPostCaption();
			String pDate = testPost.getPostDate();
			String pType = "text";
			
			int likes = testPost.getLikes().size();
			int comments = testPost.getComments().size();
			
			List<TextPostLike> postLikes = testPost.getLikes();
			int userLiked = 0;
			for(TextPostLike postLike : postLikes) {
				
				if(postLike.getLikedBy().getUserId() == userId) {
					userLiked = 1;
					break;
				}
			}
			
			PostHolder userPost = new PostHolder(pId, uId, pContent, pCaption, pDate, pType, likes, comments, userLiked);
			allPosts.add(userPost);
		}
		
		hqlQuery = "from MediaPost mp where mp.postedBy in (" + ids + ")";
		List<MediaPost> mediaPosts = session.createQuery(hqlQuery).getResultList();
		
		for(MediaPost mediaPost : mediaPosts) {
			
			int pId = mediaPost.getPostId();
			int uId = mediaPost.getPostedBy().getUserId();
			byte[] pContent = mediaPost.getPostContent();
			String pCaption = mediaPost.getPostCaption();
			String pDate = mediaPost.getPostDate();
			String pType = "media";
			
			String path = HelperController.DEFAULT_PATH + "media_" + pId + ".jpg";
			FileOutputStream fos = null;
			
			try {
				fos = new FileOutputStream(path);
				fos.write(pContent);
				fos.close();
			} 
			catch (FileNotFoundException e) {
				e.printStackTrace();
			} 
			catch (IOException e) {
				e.printStackTrace();
			}
			
			int likes = mediaPost.getLikes().size();
			int comments = mediaPost.getComments().size();
			
			List<MediaPostLike> postLikes = mediaPost.getLikes();
			int userLiked = 0;
			for(MediaPostLike postLike : postLikes) {
				
				if(postLike.getLikedBy().getUserId() == userId) {
					userLiked = 1;
					break;
				}

			}
			
			PostHolder userPost = new PostHolder(pId, uId, path, pCaption, pDate, pType, likes, comments, userLiked);
			allPosts.add(userPost);
		}
		
		hqlQuery = "from VideoPost vp where vp.postedBy in (" + ids + ")";
		List<VideoPost> videoPosts = session.createQuery(hqlQuery).getResultList();
		
		for(VideoPost videoPost : videoPosts) {
			
			int pId = videoPost.getPostId();
			int uId = videoPost.getPostedBy().getUserId();
			byte[] pContent = videoPost.getPostContent();
			String pCaption = videoPost.getPostCaption();
			String pDate = videoPost.getPostDate();
			String pType = "video";
			
			String path = HelperController.DEFAULT_PATH + "video_" + pId + ".mp4";
			FileOutputStream fos = null;
			
			try {
				fos = new FileOutputStream(path);
				fos.write(pContent);
				fos.close();
			} 
			catch (FileNotFoundException e) {
				e.printStackTrace();
			} 
			catch (IOException e) {
				e.printStackTrace();
			}
			
			int likes = videoPost.getLikes().size();
			int comments = videoPost.getComments().size();
			
			List<VideoPostLike> postLikes = videoPost.getLikes();
			int userLiked = 0;
			for(VideoPostLike postLike : postLikes) {
				
				if(postLike.getLikedBy().getUserId() == userId) {
					userLiked = 1;
					break;
				}
			}
			
			PostHolder userPost = new PostHolder(pId, uId, path, pCaption, pDate, pType, likes, comments, userLiked);
			allPosts.add(userPost);
		}
		
		allPosts.sort((postOne,postTwo)-> postOne.getPostDate().compareTo(postTwo.getPostDate()) * -1);
		
		session.close();
		return allPosts;
	}
	
	public static void addTextPost(int postedBy, String postContent, String postCaption, String postDate) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = UserDao.getUser(postedBy);
		
		TextPost textPost = new TextPost(user, postContent, postCaption, postDate);
		session.save(textPost);
		
		transaction.commit();
		session.close();
	}
	
	public static void addMediaPost(int postedBy, File postContent, String postCaption, String postDate) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = UserDao.getUser(postedBy);
		
		byte[] bfile = new byte[(int) postContent.length()];
		FileInputStream fis;
		try {
			fis = new FileInputStream(postContent);
			fis.read(bfile);
			fis.close();
			
			MediaPost mediaPost = new MediaPost(user, bfile, postCaption, postDate);
			session.save(mediaPost);
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		transaction.commit();
		session.close();
	}
	
	public static void addVideoPost(int postedBy, File postContent, String postCaption, String postDate) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		User user = UserDao.getUser(postedBy);
		 
		byte[] bfile = new byte[(int) postContent.length()];
		FileInputStream fis;
		try {
			fis = new FileInputStream(postContent);
			fis.read(bfile);
			fis.close();
			
			VideoPost mediaPost = new VideoPost(user, bfile, postCaption, postDate);
			session.save(mediaPost);
		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		
		transaction.commit();
		session.close();
	}
	
	public static void addTextPostLike(int postId, int likedBy, String likedOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		TextPost post = getTextPost(postId);
		User user = UserDao.getUser(likedBy);
		
		TextPostLike textPostLike = new TextPostLike(post, user, likedOn);
		session.save(textPostLike);
		
		transaction.commit();
		session.close();
	}
	
	public static void addMediaPostLike(int postId, int likedBy, String likedOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		MediaPost post = getMediaPost(postId);
		User user = UserDao.getUser(likedBy);
		
		MediaPostLike mediaPostLike = new MediaPostLike(post, user, likedOn);
		session.save(mediaPostLike);
		
		transaction.commit();
		session.close();
	}
	
	public static void addVideoPostLike(int postId, int likedBy, String likedOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		VideoPost post = getVideoPost(postId);
		User user = UserDao.getUser(likedBy);
		
		VideoPostLike videoPostLike = new VideoPostLike(post, user, likedOn);
		session.save(videoPostLike);
		
		transaction.commit();
		session.close();
	}
	
	public static void addTextPostComment(int postId, int commentBy, String comment, String commentOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		TextPost post = getTextPost(postId);
		User user = UserDao.getUser(commentBy);
		
		TextPostComment textPostComment = new TextPostComment(post, user, comment, commentOn);
		session.save(textPostComment);
		
		transaction.commit();
		session.close();
	}
	
	public static void addMediaPostComment(int postId, int commentBy, String comment, String commentOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		MediaPost post = getMediaPost(postId);
		User user = UserDao.getUser(commentBy);
		
		MediaPostComment mediaPostComment = new MediaPostComment(post, user, comment, commentOn);
		session.save(mediaPostComment);
		
		transaction.commit();
		session.close();
	}
	
	public static void addVideoPostComment(int postId, int commentBy, String comment, String commentOn) {
		
		Session session = Utility.FACTORY.openSession();
		Transaction transaction = session.beginTransaction();
		
		VideoPost post = getVideoPost(postId);
		User user = UserDao.getUser(commentBy);
		
		VideoPostComment videoPostComment = new VideoPostComment(post, user, comment, commentOn);
		session.save(videoPostComment);
		
		transaction.commit();
		session.close();
	}
}
