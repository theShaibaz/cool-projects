package com.mutiny.controllers;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.text.ParseException;
import java.text.SimpleDateFormat;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
 
@SuppressWarnings({"serial","rawtypes"})
@WebServlet("/HelperController")
public class HelperController extends HttpServlet {
        
	public static final String DEFAULT_PATH = "C:\\apache-tomcat-8.5.50\\wtpwebapps\\Mutiny-JSP-Hibernate\\views\\temp\\";
	public static final String AVATAR_PATH = "C:\\apache-tomcat-8.5.50\\wtpwebapps\\Mutiny-JSP-Hibernate\\views\\images\\users\\";
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
 
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

	}

	public static String generatePath(String tempPath) {
		
		return "temp/" + tempPath.substring(tempPath.lastIndexOf('\\') + 1);
	}
	
	public static String epochToDate(String timestamp) {
		
      	return new SimpleDateFormat("E, dd MMM yyyy HH:mm").format(new Date(Long.parseLong(timestamp) * 1000));
	}
	
	public static String dateToEpoch(String date) throws ParseException{
		
      	return new java.text.SimpleDateFormat("yyyy-MM-dd").parse(date).getTime() / 1000 + "";
	}
	
	public static String getEpoch() {
		
		return System.currentTimeMillis()/1000 + "";
	}
	
	public static int getUserId(HttpSession session) {
		
		return (int)session.getAttribute("userId");
	}
	
	public static String getUsername(HttpSession session) {
		
		return (String)session.getAttribute("username");
	}
	
	public static List<String> uploadFile(HttpServletRequest request, HttpServletResponse response) {
		
		File file ;
		int maxFileSize = 100000 * 1024;
		int maxMemSize = 100000 * 1024;
		String filePath = DEFAULT_PATH;
	
		List<String> data = new ArrayList<String>();
		String memberIds = "";
		
		String contentType = request.getContentType();
		if ((contentType.indexOf("multipart/form-data") >= 0)) {
	
			DiskFileItemFactory factory = new DiskFileItemFactory();
			factory.setSizeThreshold(maxMemSize);
			factory.setRepository(new File(DEFAULT_PATH));
			ServletFileUpload upload = new ServletFileUpload(factory);
			upload.setSizeMax( maxFileSize );
			try{ 
				List fileItems = upload.parseRequest(request);
			    Iterator i = fileItems.iterator();
			    while ( i.hasNext () ) 
			    {
			    	FileItem fi = (FileItem)i.next();
			        if ( !fi.isFormField () )  {
			            String fileName = fi.getName();
			            file = new File( filePath + fileName) ;
			            fi.write( file ) ;
			            data.add(file.getAbsolutePath());
			         }
			        else {
			        	if(fi.getFieldName().equalsIgnoreCase("friends")) {
			        		memberIds += fi.getString() + ",";
			        	}
			        	else {
			        		data.add(fi.getString());
			        	}
			        }
			    }
			}
			catch(Exception ex) {
			    System.out.println(ex);
			}
		}
		else{
			//File Not Uploaded
		}
		
		if (memberIds.length() > 0) {
			data.add(memberIds.substring(0, memberIds.length()-1));
		}
		return data;
	}
}
