package com.library.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.library.application.ApplicationHelper;

public class AuthenticateServlet extends HttpServlet{
	
	static {
		
		ApplicationHelper.startApplication();
		
	}

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		PrintWriter writer = resp.getWriter();
		resp.setContentType("text/html");
		
		String username = req.getParameter("username");
		String password = req.getParameter("password");
		
		String userType = ApplicationHelper.authenticateUser(username, password);
		
		if(userType != null) {
			
			if(userType.equalsIgnoreCase("admin")) {

				resp.sendRedirect("doAdmin");
			}
			else if(userType.equalsIgnoreCase("user")) {
				
				resp.sendRedirect("doUser");
			}
			
		}
		else {
			
			RequestDispatcher dispatcher = req.getRequestDispatcher("index.html");
			dispatcher.include(req, resp);
			writer.print("<br><br><br>");
			writer.print("<h6 class=\"offset-md-5 text-danger\">Invalid username or password</h6>");
			
		}
		
	}
	
}
