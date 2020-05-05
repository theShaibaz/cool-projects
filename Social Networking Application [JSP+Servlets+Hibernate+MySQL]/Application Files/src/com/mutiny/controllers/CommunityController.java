package com.mutiny.controllers;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.mutiny.dao.CommunityDao;

@WebServlet("/CommunityController")
@SuppressWarnings({"serial"})
public class CommunityController extends HttpServlet {
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		String action = request.getParameter("action");
		HttpSession session = request.getSession();
		
		if(action.equalsIgnoreCase("communityChat")) {
			
			int communityId = Integer.parseInt(request.getParameter("communityId"));
			session.setAttribute("communityId", communityId);
			response.sendRedirect("views/community-chat.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		String action = request.getParameter("action");
		HttpSession session = request.getSession();
		 
		int userId = HelperController.getUserId(session);
		
		if(action.equalsIgnoreCase("addCommunityMessage")) {
			
			int communityId = Integer.parseInt(request.getParameter("communityId"));
			String messageText = request.getParameter("messageText");
			String epoch = HelperController.getEpoch();
			CommunityDao.addCommunityMessage(userId, communityId, messageText, epoch);
			response.sendRedirect("views/community-chat.jsp");
		}
		else if(action.equalsIgnoreCase("addCommunity")) {
			
			List<String> communityData = HelperController.uploadFile(request, response);
			String communityName = communityData.get(0);
			String description = communityData.get(1);
			File communityPicture = new File(communityData.get(2));
			String[] memberIds = communityData.get(3).split(",");
			String epoch = HelperController.getEpoch();
			
			List<Integer> members = new ArrayList<Integer>();
			for(String data: memberIds) {
				members.add(Integer.parseInt(data));
			}
			
			int communityId = CommunityDao.addCommunity(communityName, description, epoch, userId, members, communityPicture);
			session.setAttribute("communityId", communityId);
			response.sendRedirect("views/community-chat.jsp");
		}
	}  
	
	public static String getCommunityPicture(int communityId) {
		
		return HelperController.generatePath(CommunityDao.getCommunityPicture(communityId));
	}
	
}
