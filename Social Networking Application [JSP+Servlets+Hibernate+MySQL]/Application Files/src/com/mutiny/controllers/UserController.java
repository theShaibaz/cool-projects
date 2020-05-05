package com.mutiny.controllers;

import java.io.File;
import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.mutiny.dao.UserDao;

@WebServlet("/UserController")
@SuppressWarnings({"serial","rawtypes"})
public class UserController extends HttpServlet {
       
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		 
		String action = request.getParameter("action");
		HttpSession session = request.getSession(); 
		  
		int userId = HelperController.getUserId(session);  
		 
		if(action.equalsIgnoreCase("searchUsers")) {
			
			String username = request.getParameter("username");
			List users = UserDao.getUsers(username, userId);
			
			session.setAttribute("userList", users);
			session.setAttribute("searchUsersString", username);
			response.sendRedirect("views/search-users.jsp");
		}
		else if(action.equalsIgnoreCase("privateChat")) {
			
			int otherUserId = Integer.parseInt(request.getParameter("otherUserId"));
			session.setAttribute("otherUserId", otherUserId);
			response.sendRedirect("views/private-chat.jsp");
		}
		else if(action.equalsIgnoreCase("showUserProfile")) {
			
			int profileId = Integer.parseInt(request.getParameter("profileId"));
			session.setAttribute("profileId", profileId);
			response.sendRedirect("views/user-profile.jsp");
		}
		
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String action = request.getParameter("action");
		HttpSession session = request.getSession();
		 
		int userId = HelperController.getUserId(session);
		
		if(action.equalsIgnoreCase("searchUsers")) {
			
			String username = request.getParameter("username");
			List users = UserDao.getUsers(username, userId);
			
			session.setAttribute("userList", users);
			session.setAttribute("searchUsersString", username);
			response.sendRedirect("views/search-users.jsp");
		}
		else if(action.equalsIgnoreCase("addPrivateMessage")) {
			
			int otherUserId = Integer.parseInt(request.getParameter("otherUserId"));
			String messageText = request.getParameter("messageText");
			String epoch = HelperController.getEpoch();
			UserDao.addAddPrivateMessage(otherUserId, userId, messageText, epoch);
			response.sendRedirect("views/private-chat.jsp");
		}
		else if(action.equalsIgnoreCase("updateProfile")) {
			
			List<String> data = HelperController.uploadFile(request, response);
			UserDao.updateProfile(userId, data.get(0), new File(data.get(1)));
			session.setAttribute("profileId", userId);
			response.sendRedirect("views/user-profile.jsp");
		}
	}

	public static String getProfilePicture(int userId) {
		
		return HelperController.generatePath(UserDao.getProfilePicture(userId));
	}
	
}
