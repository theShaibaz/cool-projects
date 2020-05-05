package com.myntra.database;

import java.sql.ResultSet;
import java.sql.SQLException;

public class DatabaseOperations {

	private DatabaseOperations() {
		
	}
	
	public static int userId = 0;
	public static String userName = null;
	
	//	HELPER QUERIES
	
	private static String userLoginQuery = "SELECT * FROM `TBL_USER` WHERE `USERNAME` = ? AND `PASSWORD` = ?";
	
	private static String selectCategoriesQuery = "SELECT `CATEGORY_NAME` FROM `TBL_CATEGORIES";
	
	private static String selectSubCategoriesQuery = "SELECT `SUB_CATEGORY_NAME` FROM `TBL_SUB_CATEGORIES` "
	+ "WHERE `CATEGORY_ID` = (SELECT `CATEGORY_ID` FROM `TBL_CATEGORIES` WHERE `CATEGORY_NAME` = ?)";
	
	private static String selectProductsQuery = "SELECT `PRODUCT_NAME`,`PRODUCT_PRICE` FROM `TBL_PRODUCT`"
	+ "WHERE `SUB_CATEGORY_ID` = (SELECT `SUB_CATEGORY_ID` FROM `TBL_SUB_CATEGORIES` WHERE `SUB_CATEGORY_NAME` = ?)";
	
	private static String selectFromCartQuery = "SELECT `ID`,`PRODUCT_NAME`,`PRODUCT_PRICE`,`QUANTITY`,`TOTAL_PRICE`"
	+ "FROM `TBL_CART` INNER JOIN `TBL_PRODUCTS` ON `TBL_CART`.`PRODUCT_ID` = `TBL_PRODUCTS`.`PRODUCT_ID`"
	+ "WHERE `USER_ID` = ?";
	
	private static String insertIntoCartQuery = "INSERT INTO `TBL_CART` (`USER_ID`,`PRODUCT_ID`,`QUANTITY`,`TOTAL_PRICE`) "
	+ "VALUES(?,?,?,?)";
	
	private static String updateIntoCartQuery = "UPDATE `TBL_CART` SET `QUANTITY` = ? WHERE `USER_ID` = ? AND `PRODUCT_ID` = ?";
	
	private static String deleteFromCartQuery = "DELETE FROM `TBL_CART` WHERE `USER_ID` = ? AND `PRODUCT_ID` = ?";
	
	private static String clearUserCartQuery = "DELETE FROM `TBL_CART` WHERE `USER_ID` = ?";
	
	//	HELPER METHODS
	
	public static boolean userLogin(String username, String password) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(userLoginQuery);
		DatabaseConnection.preparedStatement.setString(1, username);
		DatabaseConnection.preparedStatement.setString(2, password);
		DatabaseConnection.resultSet = DatabaseConnection.preparedStatement.executeQuery();
		
		if(DatabaseConnection.resultSet.next()) {
			userId = DatabaseConnection.resultSet.getInt("USER_ID");
			userName = DatabaseConnection.resultSet.getString("USERNAME");
			return true;
		}
		else {
			return false;
		}
		
	}
	
	public static ResultSet selectCategories() {
		
		try {
			return DatabaseConnection.statement.executeQuery(selectCategoriesQuery);
		} 
		catch (SQLException e) {
			e.printStackTrace();
			return null;
		}
	}
	
	public static ResultSet selectSubCategories(String categoryName) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(selectSubCategoriesQuery);
		DatabaseConnection.preparedStatement.setString(1, categoryName);
		return DatabaseConnection.preparedStatement.executeQuery();
	}
	
	public static ResultSet selectProducts(String subCategoryName) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(selectProductsQuery);
		DatabaseConnection.preparedStatement.setString(1, subCategoryName);
		return DatabaseConnection.preparedStatement.executeQuery();
	}
	
	public static ResultSet selectFromCart(int userId) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(selectFromCartQuery);
		DatabaseConnection.preparedStatement.setInt(1, userId);
		return DatabaseConnection.preparedStatement.executeQuery();
	}
	
	public static void addToCart(int userId, int productId, int quantity, int totalPrice) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(insertIntoCartQuery);
		DatabaseConnection.preparedStatement.setInt(1, userId);
		DatabaseConnection.preparedStatement.setInt(2, productId);
		DatabaseConnection.preparedStatement.setInt(3, quantity);
		DatabaseConnection.preparedStatement.setInt(4, totalPrice);
		DatabaseConnection.preparedStatement.addBatch();
	}
	
	public static void updateCart(int userId, int productId, int newQuantity) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(updateIntoCartQuery);
		DatabaseConnection.preparedStatement.setInt(1, userId);
		DatabaseConnection.preparedStatement.setInt(2, productId);
		DatabaseConnection.preparedStatement.setInt(3, newQuantity);
		DatabaseConnection.preparedStatement.addBatch();
	}
	
	public static void deleteFromCart(int userId, int productId) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(deleteFromCartQuery);
		DatabaseConnection.preparedStatement.setInt(1, userId);
		DatabaseConnection.preparedStatement.setInt(2, productId);
		DatabaseConnection.preparedStatement.executeUpdate();
	}
	
	public static void clearUserCart(int userId) throws SQLException {
		
		DatabaseConnection.preparedStatement = DatabaseConnection.dbConnection.prepareStatement(clearUserCartQuery);
		DatabaseConnection.preparedStatement.executeUpdate();
	}
	
}
