package com.mutiny.controllers;
 
import java.io.File;
import java.io.IOException;
import java.text.ParseException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.mutiny.dao.UserDao;
import com.mutiny.models.User;

@WebServlet("/LoginController")
@SuppressWarnings("serial")
public class LoginController extends HttpServlet {

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String action = request.getParameter("action");
		
		if(action.equalsIgnoreCase("logout")) {
			logout(request,response);
		}
	}
	  
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String action = request.getParameter("action");
		
		if(action.equalsIgnoreCase("sign-up")) {
			signUp(request, response);
		}
		else if(action.equalsIgnoreCase("login")) {
			login(request, response);
		}
	} 
	
	private void signUp(HttpServletRequest request, HttpServletResponse response) {
		
		try {
			
			String username = request.getParameter("username");
			String password = request.getParameter("password");
			String gender = request.getParameter("gender");
			String lastLogin = HelperController.getEpoch();
			String joinedOn = HelperController.getEpoch();
			String isOnline = "1";
			String birthdate = HelperController.dateToEpoch(request.getParameter("birthdate"));
			
			File profilePicture = null;
			if(gender.equalsIgnoreCase("m")) {
				profilePicture = new File(HelperController.AVATAR_PATH + "male.png");
			}
			else if(gender.equalsIgnoreCase("f")) {
				profilePicture = new File(HelperController.AVATAR_PATH + "female.png");
			}
			else if(gender.equalsIgnoreCase("o")) {
				profilePicture = new File(HelperController.AVATAR_PATH + "other.png");
			}
			
			User user = UserDao.addUser(username, password, birthdate, gender, lastLogin, joinedOn, isOnline, profilePicture);
			
			HttpSession session = request.getSession();
			session.setAttribute("userId", user.getUserId());
			session.setAttribute("username", user.getUsername());
			
			response.sendRedirect("views/user-home.jsp");
			
		} 
		catch (ParseException | IOException e) {
			e.printStackTrace();
		}
		
	}
	
	private void login(HttpServletRequest request, HttpServletResponse response) {
		
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		
		User user = UserDao.authenticate(username, password);
		
		try {
			
			if(user != null) {
				
				HttpSession session = request.getSession();
				session.setAttribute("userId", user.getUserId());
				session.setAttribute("username", user.getUsername());
				
				UserDao.setIsOnline(user.getUserId(), "1");
				response.sendRedirect("views/user-home.jsp");
			}
			else {
				response.sendRedirect("views/login.jsp");
			}
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	private void logout(HttpServletRequest request, HttpServletResponse response) {

		HttpSession session = request.getSession();
		int userId = HelperController.getUserId(session);
		
		UserDao.setIsOnline(userId, "0");
		String epoch = HelperController.getEpoch();
		UserDao.setLastLogin(userId, epoch);
		
		try {
			response.sendRedirect("views/login.jsp");
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
	}
}
