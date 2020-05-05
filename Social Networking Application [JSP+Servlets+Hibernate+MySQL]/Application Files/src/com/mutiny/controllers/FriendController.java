package com.mutiny.controllers;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.mutiny.dao.FriendDao;

@WebServlet("/FriendController")
@SuppressWarnings({"serial"})
public class FriendController extends HttpServlet {

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		 
		String action = request.getParameter("action");
		HttpSession session = request.getSession();
		
		int userId = HelperController.getUserId(session); 
		 
		if(action.equalsIgnoreCase("addFriendRequest")) {
			
			int toUserId = Integer.parseInt(request.getParameter("toUserId"));
			String epoch = HelperController.getEpoch();
			FriendDao.addFriendRequest(userId, toUserId, epoch);
			 
			String page = request.getParameter("page");
			if(page != null && page.equalsIgnoreCase("userProfile")) {
				response.sendRedirect("views/user-profile.jsp");
			}
			else {
				String searchUsersString = (String)session.getAttribute("searchUsersString");
				response.sendRedirect("/Mutiny-JSP-Hibernate/UserController?action=searchUsers&username=" + searchUsersString);
			}
		}
		else if(action.equalsIgnoreCase("acceptFriendRequest")) {
			
			int requestId = Integer.parseInt(request.getParameter("requestId"));
			FriendDao.updateFriendRequest(requestId, "A");
			response.sendRedirect("views/friend-requests.jsp");
		}
		else if(action.equalsIgnoreCase("declineFriendRequest")) {
			
			int requestId = Integer.parseInt(request.getParameter("requestId"));
			FriendDao.updateFriendRequest(requestId, "D");
			response.sendRedirect("views/friend-requests.jsp");
		}
		else if(action.equalsIgnoreCase("showFriendRequest")) {
			
			response.sendRedirect("views/friend-requests.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
	} 
	
}
