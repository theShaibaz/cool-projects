package com.library.main;

import java.sql.SQLException;
import java.util.Date;
import java.util.Scanner;

import com.library.database.DatabaseConnection;
import com.library.database.DatabaseOperations;
import com.library.database.LogFile;

public class ApplicationHelper {

	private ApplicationHelper() {
		
	}
	
	public static Scanner input = new Scanner(System.in);
	
	public static void startApplication() {
		
		DatabaseConnection.connectDB();
		LogFile.writeLog("[ " + new Date().toString() + " ] : MySQL Server Started");
	}
	
	public static void displayBooks() {
		
		DatabaseConnection.resultSet = DatabaseOperations.displayBooks();
		LogFile.writeLog("[ " + new Date().toString() + " ] : User Fetched All Books");
		
		try {
			
			System.out.printf("%5s %-30s %-20s %-20s %5s %5s", "ISBN","NAME","AUTHOR","PUBLISHER","PRICE","RATINGS");
			while(DatabaseConnection.resultSet.next()) {
				
				int isbn = DatabaseConnection.resultSet.getInt("ISBN");
				String name = DatabaseConnection.resultSet.getString("NAME");
				String author = DatabaseConnection.resultSet.getString("AUTHOR");
				String publisher = DatabaseConnection.resultSet.getString("PUBLISHER");
				int price = DatabaseConnection.resultSet.getInt("PRICE");
				int ratings = DatabaseConnection.resultSet.getInt("RATINGS");
				
				System.out.printf("\n%5s %-30s %-20s %-20s %5s %5s", isbn,name,author,publisher,price,ratings);
			}
			
			System.out.println();
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void addBooks() {
		
		String choice = null;
		
		try {
			
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(DatabaseOperations.insertBookQuery);
			
			do {
				
				input.nextLine();
				System.out.print("\nEnter book details [ISBN,NAME,AUTHOR,PUBLISHER,PRICE,RATINGS] : ");
				String bookDetails[] = input.nextLine().split(","); 
				
				int isbn = Integer.parseInt(bookDetails[0]);
				String name = bookDetails[1];
				String author = bookDetails[2];
				String publisher = bookDetails[3];
				int price = Integer.parseInt(bookDetails[4]);
				int ratings = Integer.parseInt(bookDetails[5]);
				
				DatabaseOperations.insertBook(isbn, name, author, publisher, price, ratings);
				
				System.out.print("\nWant to add another book ? [Y|N] : ");
				choice = input.next();
				
			}while(choice.equalsIgnoreCase("YES"));
			
			int[] rowCount = DatabaseConnection.preparedStatement.executeBatch();
			DatabaseConnection.dbConnection.commit();
			LogFile.writeLog("[ " + new Date().toString() + " ] : User Added " + rowCount.length + " Books");
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void deleteSameBooks() {
		
		DatabaseOperations.deleteSameBooks();
		LogFile.writeLog("[ " + new Date().toString() + " ] : User Deleted Repeated Books");
	}
	
	public static void deleteBooks(String columnName, String columnValue) {
		
		try {
			int rowCount = DatabaseOperations.deleteBooks(columnName,columnValue);
			LogFile.writeLog("[ " + new Date().toString() + " ] : User Deleted " + rowCount + " Books");
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void deleteBooks(String columnName, int columnValue) {
		
		try {
			int rowCount = DatabaseOperations.deleteBooks(columnName, columnValue + "");
			LogFile.writeLog("[ " + new Date().toString() + " ] : User Deleted " + rowCount + " Books");
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void updatePrice() {
		
		int rowCount = DatabaseOperations.updateBookPrice();
		LogFile.writeLog("[ " + new Date().toString() + " ] : User Updated " + rowCount + " Books");
	}
	
	public static void updatePrice(int ratings, float percent) {
		
		try {
			int rowCount = DatabaseOperations.updateBookPrice(ratings, percent);
			LogFile.writeLog("[ " + new Date().toString() + " ] : User Updated " + rowCount + " Books");
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void updatePrice(int ratings, int newPrice) {
		
		try {
			int rowCount = DatabaseOperations.updateBookPrice(ratings, newPrice);
			LogFile.writeLog("[ " + new Date().toString() + " ] : User Updated " + rowCount + " Books");
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void closeDB() {
		
		DatabaseConnection.closeDB();
		LogFile.writeLog("[ " + new Date().toString() + " ] : MySQL Server Stopped");
	}
}
