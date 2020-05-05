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

public class AdminServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		PrintWriter writer = resp.getWriter();
		
		ResultSet allBooks = ApplicationHelper.getAllBooks();
		
		try {
			
			int count = 0;
			
			writer.print("<br><br><br>");
			
			writer.print(ApplicationHelper.bootstrapCss);
			writer.print(ApplicationHelper.bootstrapJQuery);
			writer.print(ApplicationHelper.bootstrapJs);
			writer.print(ApplicationHelper.fontAwesomeCss);
			
			writer.print("<a href=\"doAddBookUI\">");
			writer.print("<input type=\"button\" class=\"col-md-2 offset-md-1 btn btn-success form-control\" value=\"Add New Book\">");
			writer.print("</a>");
			
			writer.print("<a href=\"doAddGenreUI\">");
			writer.print("<input type=\"button\" class=\"col-md-2 offset-md-6 btn btn-warning form-control\" value=\"Add New Genre\">");
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
			
			while(allBooks.next()) {
				
				writer.print("<tr>");
				
				writer.print("<td>" + ++count + "</td>");
				writer.print("<td>" + allBooks.getString("isbn") + "</td>");
				writer.print("<td>" + allBooks.getString("name") + "</td>");
				writer.print("<td>" + allBooks.getString("genre_name") + "</td>");
				writer.print("<td>" + allBooks.getString("author") + "</td>");
				writer.print("<td>" + allBooks.getString("publisher") + "</td>");
				writer.print("<td>" + allBooks.getString("price") + "</td>");
				writer.print("<td>" + allBooks.getString("ratings") + "</td>");
				writer.print("<td><a href=\"doUpdateBookUI?id=" + allBooks.getString("id") + "\"><i class=\"fa fa-pencil\" aria-hidden=\"true\"></i></a></td>");
				writer.print("<td><a href=\"doDeleteBook?id=" + allBooks.getString("id") + "\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a></td>");
				
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
