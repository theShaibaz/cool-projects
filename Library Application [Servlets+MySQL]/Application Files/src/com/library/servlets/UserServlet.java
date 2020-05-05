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

public class UserServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		PrintWriter writer = resp.getWriter();
		
		ResultSet genres = ApplicationHelper.getGenres();
		
		writer.print("<br><br><br>");
		
		writer.print(ApplicationHelper.bootstrapCss);
		writer.print(ApplicationHelper.bootstrapJQuery);
		writer.print(ApplicationHelper.bootstrapJs);
		writer.print(ApplicationHelper.fontAwesomeCss);
		
		writer.print("<br><br><br>");
		
		writer.print("<form action=\"doDisplayBooks\">");
		writer.print("<div class=\"container col-md-6\">");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		
		writer.print("<label for=\"genre\">Genre</label>");
		writer.print("<select class=\"form-control\" id=\"genre\" name=\"genre\">");
		
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
		writer.print("<input type=\"submit\" class=\"btn btn-primary form-control\" value=\"Show Books\">");
		writer.print("</div>");
		writer.print("</div></div>");
		
	}
	
}
