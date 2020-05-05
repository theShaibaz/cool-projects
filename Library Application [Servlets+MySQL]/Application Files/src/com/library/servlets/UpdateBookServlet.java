package com.library.servlets;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.library.application.ApplicationHelper;

public class UpdateBookServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		int isbn =  Integer.parseInt(req.getParameter("isbn")); 
		String bookname = req.getParameter("bookname"); 
		int genre = Integer.parseInt(req.getParameter("genre")); 
		String author = req.getParameter("author"); 
		String publisher = req.getParameter("publisher"); 
		int price = Integer.parseInt(req.getParameter("price")); 
		int ratings = Integer.parseInt(req.getParameter("ratings")); 
		
		HttpSession session = req.getSession();
		int id = (int)(session.getAttribute("id"));
		
		try {
			
			ApplicationHelper.updateBook(isbn, bookname, genre, author, publisher, price, ratings, id);
			resp.sendRedirect("doAdmin");
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
}
