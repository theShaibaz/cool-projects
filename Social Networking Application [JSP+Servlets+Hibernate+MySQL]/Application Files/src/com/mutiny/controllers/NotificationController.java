package com.mutiny.controllers;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.mutiny.dao.NotificationDao;

@WebServlet("/NotificationController")
@SuppressWarnings({"serial"})
public class NotificationController extends HttpServlet {
 
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
 
		String action = request.getParameter("action");
		HttpSession session = request.getSession(); 
		int userId = HelperController.getUserId(session);
		
		if(action.equalsIgnoreCase("readNotifications")) {
			
			NotificationDao.readNotifications(userId);
			response.sendRedirect("views/notifications.jsp");
		}
		else if(action.equalsIgnoreCase("readMessageNotifications")) {
			
			NotificationDao.readMessageNotifications(userId);
			response.sendRedirect("views/message-notifications.jsp");
		}
		else if(action.equalsIgnoreCase("readNotification")) {
			
			int notificationId = Integer.parseInt(request.getParameter("notificationId"));
			NotificationDao.readNotification(notificationId);
			String page = request.getParameter("page");
			
			if(page.equalsIgnoreCase("friendRequests")) {
				
				response.sendRedirect("views/friend-requests.jsp");
			}
			else if(page.equalsIgnoreCase("userProfile")) {
				
				int profileId = Integer.parseInt(request.getParameter("profileId"));
				session.setAttribute("profileId", profileId);
				response.sendRedirect("views/user-profile.jsp");
			}
			else if(page.equalsIgnoreCase("communityChat")) {
				
				int communityId = Integer.parseInt(request.getParameter("communityId"));
				session.setAttribute("communityId", communityId);
				response.sendRedirect("views/community-chat.jsp");
			}
			else if(page.equalsIgnoreCase("privateChat")) {
				
				int otherUserId = Integer.parseInt(request.getParameter("otherUserId"));
				session.setAttribute("otherUserId", otherUserId);
				response.sendRedirect("views/private-chat.jsp");
			}
		}
		
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
 
	}
	
}
