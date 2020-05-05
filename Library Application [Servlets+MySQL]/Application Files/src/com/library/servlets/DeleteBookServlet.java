package com.library.servlets;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.library.application.ApplicationHelper;

public class DeleteBookServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		int id = Integer.parseInt(req.getParameter("id"));
		
		
		try {
			
			ApplicationHelper.deleteBook(id);
			resp.sendRedirect("doAdmin");
			
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
}
