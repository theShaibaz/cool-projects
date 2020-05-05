package com.mutiny.controllers;

import java.io.File;
import java.io.IOException;
import java.util.Iterator;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
import org.apache.commons.io.output.DeferredFileOutputStream;

import com.mutiny.dao.PostCommentHolder;
import com.mutiny.dao.PostDao;
import com.mutiny.dao.PostHolder;

@WebServlet("/PostController")
@SuppressWarnings({"serial", "unused"})
public class PostController extends HttpServlet {

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		 
		String action = request.getParameter("action");
		HttpSession session = request.getSession(); 
		
		if(action.equalsIgnoreCase("postComments")) {
			
			String postType = request.getParameter("postType");
			int postId = Integer.parseInt(request.getParameter("postId"));
			session.setAttribute("postType", postType);
			session.setAttribute("postId", postId);
			response.sendRedirect("views/post-comments.jsp");
		}
		else if(action.equalsIgnoreCase("addLike")) {
			
			String postType = request.getParameter("postType");
			int postId = Integer.parseInt(request.getParameter("postId"));
			int userId = HelperController.getUserId(session);
			addPostLike(userId, postId, postType);
			
			String page = request.getParameter("page");
			
			if(page.equalsIgnoreCase("userHome")) {
				response.sendRedirect("views/user-home.jsp");
			}
			else if(page.equalsIgnoreCase("postComments")) {
				response.sendRedirect("views/post-comments.jsp");
			}
			else if(page.equalsIgnoreCase("userProfile")) {
				response.sendRedirect("views/user-profile.jsp");
			}
			
		}
		
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String action = request.getParameter("action");
		HttpSession session = request.getSession();
		
		if(action.equalsIgnoreCase("addComment")) {
			
			int userId = HelperController.getUserId(session);
			String comment = request.getParameter("commentText");
			String postType = request.getParameter("postType");
			int postId = Integer.parseInt(request.getParameter("postId"));
			
			addPostComment(userId, postId, postType, comment);
			response.sendRedirect("views/post-comments.jsp");
		}
		else if(action.equalsIgnoreCase("addPost")) {
			
			int userId = HelperController.getUserId(session);
			String postType = request.getParameter("postType");
			String caption = request.getParameter("caption");
			String postContent = request.getParameter("postContent");
			
			if(!postType.equalsIgnoreCase("text")) {
				
				List<String> data = HelperController.uploadFile(request, response);
				addPost(userId, postType, data.get(1), data.get(0));
			}
			else {
				
				addPost(userId, postType, postContent, caption);
			}
			
			response.sendRedirect("views/user-home.jsp");
		}
	}

	public static PostHolder getPost(String postType, int postId, HttpSession session) {
		
		PostHolder post = null;
		
		int userId = HelperController.getUserId(session);
		
		if(postType.equalsIgnoreCase("text")) {
			post = PostDao.getTextPost(postId,userId);
		}
		else if(postType.equalsIgnoreCase("media")) {
			post = PostDao.getMediaPost(postId,userId);
		}
		else if(postType.equalsIgnoreCase("video")) {
			post = PostDao.getVideoPost(postId,userId);
		}
		
		return post;
	}
	
	public static List<PostCommentHolder> getPostComments(int postId, String postType) {
		
		List<PostCommentHolder> comments = null;
		
		if(postType.equalsIgnoreCase("text")) {
			comments = PostDao.getTextPostComments(postId);
		}
		else if(postType.equalsIgnoreCase("media")) {
			comments = PostDao.getMediaPostComments(postId);
		}
		else if(postType.equalsIgnoreCase("video")) {
			comments = PostDao.getVideoPostComments(postId);
		}
		
		comments.sort((commentOne,commentTwo) -> commentOne.getCommentOn().compareTo(commentTwo.getCommentOn()) * -1);
		
		return comments;
	}
	
	public static void addPost(int postedBy, String postType, String postContent, String postCaption) {
		
		String epoch = HelperController.getEpoch();
		
		if(postType.equalsIgnoreCase("text")) {
			PostDao.addTextPost(postedBy, postContent, postCaption, epoch);
		}
		else if(postType.equalsIgnoreCase("media")) {
			PostDao.addMediaPost(postedBy, new File(postContent), postCaption, epoch);
		}
		else if(postType.equalsIgnoreCase("video")) {
			PostDao.addVideoPost(postedBy, new File(postContent), postCaption, epoch);
		}
	}
	
	public static void addPostLike(int userId, int postId, String postType) {
		
		String epoch = HelperController.getEpoch();
		
		if(postType.equalsIgnoreCase("text")) {
			PostDao.addTextPostLike(postId, userId, epoch);
		}
		else if(postType.equalsIgnoreCase("media")) {
			PostDao.addMediaPostLike(postId, userId, epoch);
		}
		else if(postType.equalsIgnoreCase("video")) {
			PostDao.addVideoPostLike(postId, userId, epoch);
		}
	}
	
	public static void addPostComment(int userId, int postId, String postType, String comment) {
		
		String epoch = HelperController.getEpoch();
		
		if(postType.equalsIgnoreCase("text")) {
			PostDao.addTextPostComment(postId, userId, comment, epoch);
		}
		else if(postType.equalsIgnoreCase("media")) {
			PostDao.addMediaPostComment(postId, userId, comment, epoch);
		}
		else if(postType.equalsIgnoreCase("video")) {
			PostDao.addVideoPostComment(postId, userId, comment, epoch);
		}
	}

}
