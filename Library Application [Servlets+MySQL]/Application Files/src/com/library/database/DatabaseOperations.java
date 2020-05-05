package com.library.database;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.Map.Entry;
import java.util.Set;


public class DatabaseOperations {

	private DatabaseOperations() {
		
	}
	
	private static String selectUserQuery = "SELECT * FROM `TBL_USERS` WHERE `USERNAME` = ? AND `PASSWORD` = ?";
	
	private static String selectBooksQuery = "SELECT `TBL_BOOKS`.`ID`,`ISBN`,`NAME`,`GENRE_NAME`,`AUTHOR`,"
	+ "`PUBLISHER`,`PRICE`,`RATINGS` FROM `TBL_BOOKS` INNER JOIN `TBL_GENRE` "
	+ "ON `TBL_BOOKS`.`GENRE` = `TBL_GENRE`.`ID`";
	
	private static String selectBookQuery = "SELECT * FROM `TBL_BOOKS` WHERE `ID` = ?";
	
	private static String selectGenreQuery = "SELECT * FROM `TBL_GENRE`";
	
	public static String insertBookQuery = "INSERT INTO `TBL_BOOKS` (`ISBN`,`NAME`,`GENRE`,`AUTHOR`,`PUBLISHER`,`PRICE`,`RATINGS`)"
	+ "VALUES (?,?,?,?,?,?,?)";
	
	private static String updateBookQuery = "UPDATE `TBL_BOOKS` SET "
	+ "`ISBN` = ?, `NAME` = ?, `GENRE` = ?, `AUTHOR` = ?, `PUBLISHER` = ?, `PRICE` = ?, `RATINGS` = ? "
	+ "WHERE `ID` = ?";
	
	private static String deleteBookQuery = "DELETE FROM `TBL_BOOKS` WHERE `ID` = ?";
	
	private static String insertGenreQuery = "INSERT INTO `TBL_GENRE` (`GENRE_NAME`) VALUES (?)";
	
	private static String selectBooksByGenreQuery = "SELECT `TBL_BOOKS`.`ID`,`ISBN`,`NAME`,`GENRE_NAME`,`AUTHOR`," 
	+ " `PUBLISHER`,`PRICE`,`RATINGS` FROM `TBL_BOOKS` INNER JOIN `TBL_GENRE` "  
	+ " ON `TBL_BOOKS`.`GENRE` = `TBL_GENRE`.`ID` WHERE `TBL_BOOKS`.`GENRE` = ?";
	
	
	
	public static String getUser(String username, String password) {
		
		try {
			
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(selectUserQuery);
			DatabaseConnection.preparedStatement.setString(1, username);
			DatabaseConnection.preparedStatement.setString(2, password);
			DatabaseConnection.resultSet = DatabaseConnection.preparedStatement.executeQuery();
			
			if(DatabaseConnection.resultSet.next()) {
				return DatabaseConnection.resultSet.getInt("is_admin") == 1 ? "admin" : "user";
			}
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return null;
	}
	
	public static ResultSet getBooks() {
		
		try {
			return DatabaseConnection.statement.executeQuery(selectBooksQuery);
		} 
		catch (SQLException e) {
			e.printStackTrace();
			return null;
		}
		
	}
	
	public static ResultSet getBook(int id) {
		
		try {
			
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(selectBookQuery);
			DatabaseConnection.preparedStatement.setInt(1, id);
			return DatabaseConnection.preparedStatement.executeQuery();
		} 
		catch (SQLException e) {
			e.printStackTrace();
			return null;
		}
		
	}
	
	public static ResultSet getGenres() {
		
		try {
			
			return DatabaseConnection.statement.executeQuery(selectGenreQuery);
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return null;
	}
	
	public static void insertBook(int isbn, String name, int genre, String author, String publisher, int price, int ratings) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(insertBookQuery);
		DatabaseConnection.preparedStatement.setInt(1, isbn);
		DatabaseConnection.preparedStatement.setString(2, name);
		DatabaseConnection.preparedStatement.setInt(3, genre);
		DatabaseConnection.preparedStatement.setString(4, author);
		DatabaseConnection.preparedStatement.setString(5, publisher);
		DatabaseConnection.preparedStatement.setInt(6, price);
		DatabaseConnection.preparedStatement.setInt(7, ratings);
		DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();
	}
	
	public static void updateBook(int isbn, String name, int genre, String author, String publisher, int price, int ratings, int id) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(updateBookQuery);
		DatabaseConnection.preparedStatement.setInt(1, isbn);
		DatabaseConnection.preparedStatement.setString(2, name);
		DatabaseConnection.preparedStatement.setInt(3, genre);
		DatabaseConnection.preparedStatement.setString(4, author);
		DatabaseConnection.preparedStatement.setString(5, publisher);
		DatabaseConnection.preparedStatement.setInt(6, price);
		DatabaseConnection.preparedStatement.setInt(7, ratings);
		DatabaseConnection.preparedStatement.setInt(8, id);
		DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();

	}
	
	public static void deleteBook(int id) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteBookQuery);
		DatabaseConnection.preparedStatement.setInt(1, id);
		DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();
	}
	
	public static void insertGenre(String genreName) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(insertGenreQuery);
		DatabaseConnection.preparedStatement.setString(1, genreName);
		DatabaseConnection.preparedStatement.executeUpdate();
		DatabaseConnection.dbConnection.commit();
	}
	
	public static ResultSet getBooksByGenre(int genreId) {
		
		try {
			
			DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(selectBooksByGenreQuery);
			DatabaseConnection.preparedStatement.setInt(1, genreId);
			return DatabaseConnection.preparedStatement.executeQuery();
		} 
		catch (SQLException e) {
			e.printStackTrace();
			return null;
		}
		
	}

}
