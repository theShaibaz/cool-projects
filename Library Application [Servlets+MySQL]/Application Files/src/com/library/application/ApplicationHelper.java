package com.library.application;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Date;
import java.util.Scanner;

import com.library.database.DatabaseConnection;
import com.library.database.DatabaseOperations;
import com.library.database.LogFile;
import com.mysql.cj.protocol.Resultset;

public class ApplicationHelper {

	private ApplicationHelper() {
		
	}
	
	public static Scanner input = new Scanner(System.in);
	
	public static String htmlBegin = "<html lang=\"en\">";
	public static String headBegin = "<head>";
	public static String bodyBegin = "<body>";
	public static String bootstrapCss = "<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\">";
	public static String bootstrapJQuery = "<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>"; 
	public static String bootstrapJs = "<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js\"></script>";
	public static String fontAwesomeCss = "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">";
	public static String htmlEnd = "</html>";
	public static String headEnd = "</head>";
	public static String bodyEnd = "</body>";
	
	public static void startApplication() {
		
		DatabaseConnection.connectDB();
		LogFile.writeLog("[ " + new Date().toString() + " ] : MySQL Server Started");
	}
	
	public static String authenticateUser(String username, String password) {
		
		return DatabaseOperations.getUser(username, password);
		
	}
	
	public static ResultSet getAllBooks() {
		
		return DatabaseOperations.getBooks();
		
	}
	
	public static ResultSet getBook(int id) {
		
		return DatabaseOperations.getBook(id);
		
	}
	
	public static ResultSet getGenres() {
		
		return DatabaseOperations.getGenres();
		
	}
	
	public static void addBook(int isbn, String name, int genre, String author, String publisher, int price, int ratings) throws SQLException {
		
		DatabaseOperations.insertBook(isbn, name, genre, author, publisher, price, ratings);
		
	}
	
	public static void updateBook(int isbn, String name, int genre, String author, String publisher, int price, int ratings, int id) throws SQLException {
		
		DatabaseOperations.updateBook(isbn, name, genre, author, publisher, price, ratings, id);
		
	}
	
	public static void deleteBook(int id) throws SQLException {
		
		DatabaseOperations.deleteBook(id);
		
	}
	
	public static void addGenre(String genreName) throws SQLException {
		
		DatabaseOperations.insertGenre(genreName);
		
	}
	
	public static ResultSet getBooksByGenre(int genreId) {
		
		return DatabaseOperations.getBooksByGenre(genreId);
		
	}
	
	public static void closeDB() {
		
		DatabaseConnection.closeDB();
		LogFile.writeLog("[ " + new Date().toString() + " ] : MySQL Server Stopped");
	}
}
