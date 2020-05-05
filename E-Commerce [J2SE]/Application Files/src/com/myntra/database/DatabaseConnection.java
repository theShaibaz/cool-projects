package com.myntra.database;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ResourceBundle;

public class DatabaseConnection {

	private DatabaseConnection() {

	}
	
	public static Connection dbConnection = null;
	public static Statement statement = null;
	public static PreparedStatement preparedStatement = null;
	public static ResultSet resultSet = null;
	
	public static Connection connectDB() {
		
		ResourceBundle bundle = ResourceBundle.getBundle("com.myntra.database.db_myntra");
		String url = bundle.getString("url");
		String username = bundle.getString("username");
		String password = bundle.getString("password");
		
		try {
			
			dbConnection = DriverManager.getConnection(url, username, password);
			statement = dbConnection.createStatement();
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
		
		return dbConnection;
	}
	
	public static void closeDB() {
		
		try {
			
			if(resultSet != null) {
				resultSet.close();
			}
			if(preparedStatement != null) {
				preparedStatement.close();
			}
			if(statement != null) {
				statement.close();
			}
			if(dbConnection != null) {
				dbConnection.close();
			}
		
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
}
