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

public class AddBookUIServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		PrintWriter writer = resp.getWriter();
		
		writer.print("<br>");
		
		writer.print(ApplicationHelper.bootstrapCss);
		writer.print(ApplicationHelper.bootstrapJQuery);
		writer.print(ApplicationHelper.bootstrapJs);
		writer.print(ApplicationHelper.fontAwesomeCss);
		
		writer.print("<br><br><br>");
		
		writer.print("<form action=\"doAddBook\">");
		writer.print("<div class=\"container col-md-6\">");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"isbn\">ISBN</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"isbn\" name=\"isbn\">");
		writer.print("</div>");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"genre\">Genre</label>");
		writer.print("<select class=\"form-control\" id=\"genre\" name=\"genre\">");
		
		ResultSet genres = ApplicationHelper.getGenres();
		
		try {
			
			while(genres.next()) {
				
				writer.print("<option value = '" + genres.getInt(1) + "' > " + genres.getString(2) + " </option>");
				
			}
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		writer.print("</select>");
		writer.print("</div>");
		writer.print("</div>");
		writer.print("<br>");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"bookname\">Book Name</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"bookname\" name=\"bookname\">");
		writer.print("</div>");
		writer.print("</div>");
		writer.print("<br>");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"author\">Author</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"author\" name=\"author\">");
		writer.print("</div>");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"publisher\">Publisher</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"publisher\" name=\"publisher\">");
		writer.print("</div></div>");
		writer.print("<br>");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"price\">Price</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"price\" name=\"price\">");
		writer.print("</div>");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"ratings\">Ratings</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"ratings\" name=\"ratings\">");
		writer.print("</div></div>");
		writer.print("<br>");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<input type=\"submit\" class=\"btn btn-primary form-control\" id=\"addbook\" name=\"addbook\"\r\n value=\"Add Book\">");
		writer.print("</div>");
		writer.print("<div class=\"col\">");
		writer.print("<input type=\"reset\" class=\"btn btn-secondary form-control\" id=\"reset\" name=\"reset\" value=\"Clear\">");
		writer.print("</div></div>");
		
		writer.print("<br>");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<a href=\"doAdmin\">");
		writer.print("<input type=\"button\" class=\"btn btn-secondary form-control\" value=\"Go Back\">");
		writer.print("</a>");
		writer.print("</div></div></div>");
		
		writer.print("</form>");
		
	}
	
}
