package com.library.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.library.application.ApplicationHelper;

public class DisplayBooksServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		PrintWriter writer = resp.getWriter();
		
		int genreId = Integer.parseInt(req.getParameter("genre"));
		
		ResultSet booksByGenre = ApplicationHelper.getBooksByGenre(genreId);
	
		
		try {
			
			int count = 0;
			
			writer.print("<br><br><br>");
			
			writer.print(ApplicationHelper.bootstrapCss);
			writer.print(ApplicationHelper.bootstrapJQuery);
			writer.print(ApplicationHelper.bootstrapJs);
			writer.print(ApplicationHelper.fontAwesomeCss);
			
			writer.print("<a href=\"doUser\">");
			writer.print("<input type=\"button\" class=\"col-md-2 offset-md-1 btn btn-secondary form-control\" value=\"Go Back\">");
			writer.print("</a>");
			
			writer.print("<br><br><br>");
			
			writer.print("<div class=\"table-responsive container col-md-10\"> ");
			writer.print("<table class=\"table\">");
			writer.print("<thead>");
			writer.print("<tr>");
			
			writer.print("<th>#</th>");
			writer.print("<th>ISBN</th>");
			writer.print("<th>BOOK NAME</th>");
			writer.print("<th>GENRE</th>");
			writer.print("<th>AUTHOR</th>");
			writer.print("<th>PUBLISHER</th>");
			writer.print("<th>PRICE</th>");
			writer.print("<th>RATINGS</th>");
			writer.print("<th></th>");
			writer.print("<th></th>");
			
			writer.print("</tr>");
			writer.print("</thead>");
			
			writer.print("<tbody>");
			
			while(booksByGenre.next()) {
				
				writer.print("<tr>");
				
				writer.print("<td>" + ++count + "</td>");
				writer.print("<td>" + booksByGenre.getString("isbn") + "</td>");
				writer.print("<td>" + booksByGenre.getString("name") + "</td>");
				writer.print("<td>" + booksByGenre.getString("genre_name") + "</td>");
				writer.print("<td>" + booksByGenre.getString("author") + "</td>");
				writer.print("<td>" + booksByGenre.getString("publisher") + "</td>");
				writer.print("<td>" + booksByGenre.getString("price") + "</td>");
				writer.print("<td>" + booksByGenre.getString("ratings") + "</td>");
				
				writer.print("</tr>");
				
			}
			
			writer.print("</tbody>");
			writer.print("</table>");
			writer.print("</div>");
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
}
