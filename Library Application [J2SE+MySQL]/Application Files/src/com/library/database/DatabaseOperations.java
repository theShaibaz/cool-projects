package com.library.database;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.Map.Entry;
import java.util.Set;


public class DatabaseOperations {

	private DatabaseOperations() {
		
	}
	
	private static HashMap<String, Integer> bookEntries = new HashMap<String, Integer>() ;

	private static String selectBooksQuery = "SELECT * FROM `TBL_BOOK_INFO`";
	
	public static String insertBookQuery = "INSERT INTO `TBL_BOOK_INFO` (`ISBN`,`NAME`,`AUTHOR`,`PUBLISHER`,`PRICE`,`RATINGS`)"
	+ "VALUES (?,?,?,?,?,?)";
	
	private static String deleteSameBooksQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `NAME` = ? AND (`PRICE` < ? OR `RATINGS` < ?)";
	
	private static String deleteBooksPublisherQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `PUBLISHER` = ?";
	private static String deleteBooksAuthorQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `AUTHOR` = ?";
	private static String deleteBooksNameQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `NAME` = ?";
	private static String deleteBooksIsbnQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `ISBN` = ?";
	private static String deleteBooksPriceQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `PRICE` = ?";
	private static String deleteBooksRatingsQuery = "DELETE FROM `TBL_BOOK_INFO` WHERE `RATINGS` = ?";
	
	private static String updateBookPriceIncQuery = "UPDATE `TBL_BOOK_INFO` SET `PRICE` = PRICE + PRICE * (30 / 100) "
	+ "WHERE `RATINGS` >= 7";
	
	private static String updateBookPriceDecQuery = "UPDATE `TBL_BOOK_INFO` SET `PRICE` = PRICE - PRICE * (15 / 100) "
	+ "WHERE `RATINGS` <= 4";
	
	private static String updateBookPriceQuery = "UPDATE `TBL_BOOK_INFO` SET `PRICE` = ? WHERE `RATINGS` = ?";
	
	private static String updateBookPricePercentQuery = "UPDATE `TBL_BOOK_INFO` "
	+ "SET `PRICE` = PRICE + PRICE * (? / 100) WHERE `RATINGS` = ?";
	
	public static ResultSet displayBooks() {
		
		try {
			return DatabaseConnection.statement.executeQuery(selectBooksQuery);
		} 
		catch (SQLException e) {
			e.printStackTrace();
			return null;
		}
		
	}
	
	public static void insertBook(int isbn, String name, String author, String publisher, int price, int ratings) throws SQLException {
		
		DatabaseConnection.preparedStatement.setInt(1, isbn);
		DatabaseConnection.preparedStatement.setString(2, name);
		DatabaseConnection.preparedStatement.setString(3, author);
		DatabaseConnection.preparedStatement.setString(4, publisher);
		DatabaseConnection.preparedStatement.setInt(5, price);
		DatabaseConnection.preparedStatement.setInt(6, ratings);
		DatabaseConnection.preparedStatement.addBatch();
	}
	
	public static void deleteSameBooks() {
		
		try {
			DatabaseConnection.resultSet = DatabaseConnection.statement.executeQuery(selectBooksQuery);
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteSameBooksQuery);
			
			while(DatabaseConnection.resultSet.next()) {
				
				int count = 0;
				String bookName = DatabaseConnection.resultSet.getString("NAME");
				
				if(bookEntries.containsKey(bookName)) {
					count = bookEntries.get(bookName);
					bookEntries.put(bookName, ++count);
				}
				else {
					bookEntries.put(bookName, 1);
				}
				
			}
			
			Set<Entry<String, Integer>> bookEntrySet = bookEntries.entrySet();
			for (Entry<String, Integer> bookEntry : bookEntrySet) {
				
				if(bookEntry.getValue() > 1) {
					
					String maxPriceQuery = "SELECT MAX(`PRICE`) FROM `TBL_BOOK_INFO` WHERE `NAME` = '" + bookEntry.getKey() + "'";
					DatabaseConnection.resultSet = DatabaseConnection.statement.executeQuery(maxPriceQuery);
					DatabaseConnection.resultSet.next();
					int maxPrice = DatabaseConnection.resultSet.getInt(1);
					
					String maxRatingsQuery = "SELECT MAX(`RATINGS`) FROM `TBL_BOOK_INFO` WHERE `NAME` = '" + bookEntry.getKey() + "'"
					+ " AND `PRICE` = " + maxPrice;
					DatabaseConnection.resultSet = DatabaseConnection.statement.executeQuery(maxRatingsQuery);
					DatabaseConnection.resultSet.next();
					int maxRatings = DatabaseConnection.resultSet.getInt(1);
					
					DatabaseConnection.preparedStatement.setString(1, bookEntry.getKey());
					DatabaseConnection.preparedStatement.setInt(2, maxPrice);
					DatabaseConnection.preparedStatement.setInt(3, maxRatings);
					DatabaseConnection.preparedStatement.addBatch();
				}
				
			}
			
			DatabaseConnection.preparedStatement.executeBatch();
			DatabaseConnection.dbConnection.commit();
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static int deleteBooks(String columnName, String columnValue) throws SQLException {
		
		if(columnName.equalsIgnoreCase("PUBLISHER")) {
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBooksPublisherQuery);
		}
		else if(columnName.equalsIgnoreCase("AUTHOR")) {
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBooksAuthorQuery);
		}
		else if(columnName.equalsIgnoreCase("NAME")) {
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBooksNameQuery);
		}
		else if(columnName.equalsIgnoreCase("ISBN")) {
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBooksIsbnQuery);
		}
		else if(columnName.equalsIgnoreCase("PRICE")) {
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBooksPriceQuery);
		}
		else if(columnName.equalsIgnoreCase("RATINGS")) {
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBooksRatingsQuery);
		}
		
		DatabaseConnection.preparedStatement.setString(1, columnValue);
		int rowCount = DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();
		return rowCount;
	}
	
	public static int updateBookPrice() {
		
		try {
			int rowCount = 0;
			
			rowCount += DatabaseConnection.statement.executeUpdate(updateBookPriceIncQuery);
			rowCount += DatabaseConnection.statement.executeUpdate(updateBookPriceDecQuery);
			
			DatabaseConnection.dbConnection.commit();
			return rowCount;
		} 
		catch (SQLException e) {
			e.printStackTrace();
			return 0;
		}
		
	}
	
	public static int updateBookPrice(int ratings, float percent) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(updateBookPricePercentQuery);
		DatabaseConnection.preparedStatement.setFloat(1, percent);
		DatabaseConnection.preparedStatement.setInt(2, ratings);
		int rowCount = DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();
		
		return rowCount;
	}
	
	public static int updateBookPrice(int ratings, int newPrice) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(updateBookPriceQuery);
		DatabaseConnection.preparedStatement.setInt(1, newPrice);
		DatabaseConnection.preparedStatement.setInt(2, ratings);
		int rowCount = DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();
		return rowCount;
	}
}
