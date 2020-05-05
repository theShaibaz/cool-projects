package com.library.servlets;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.library.application.ApplicationHelper;

public class AddGenreUIServlet extends HttpServlet{

	@Override
	protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		PrintWriter writer = resp.getWriter();
		
		writer.print("<br><br><br>");
		
		writer.print(ApplicationHelper.bootstrapCss);
		writer.print(ApplicationHelper.bootstrapJQuery);
		writer.print(ApplicationHelper.bootstrapJs);
		writer.print(ApplicationHelper.fontAwesomeCss);
		
		writer.print("<br><br><br>");
		
		writer.print("<form action=\"doAddGenre\">");
		writer.print("<div class=\"container col-md-6\">");
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<label for=\"genre\">Genre Name</label>");
		writer.print("<input type=\"text\" class=\"form-control\" id=\"genre\" name=\"genre\">");
		writer.print("</div>");
		writer.print("</div>");
		writer.print("<br>");
		
		writer.print("<div class=\"row\">");
		writer.print("<div class=\"col\">");
		writer.print("<input type=\"submit\" class=\"btn btn-primary form-control\" value=\"Add Genre\">");
		writer.print("</div>");
		writer.print("<div class=\"col\">");
		writer.print("<a href=\"doAdmin\">");
		writer.print("<input type=\"button\" class=\"btn btn-secondary form-control\" value=\"Go Back\">");
		writer.print("</a>");
		writer.print("</div></div></div>");
		
	}
	
}
