package com.library.database;

import com.mysql.jdbc.Driver;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Date;
import java.util.ResourceBundle;

public class DatabaseConnection {

	private DatabaseConnection() {
		
	}
	
	public static Connection dbConnection = null;
	public static Statement statement = null;
	public static PreparedStatement preparedStatement = null;
	public static ResultSet resultSet = null;
	public static Date date = new Date();
	
	public static void connectDB() {
		
		ResourceBundle bundle = ResourceBundle.getBundle("com.library.utilities.dblibrary");
		String url = bundle.getString("url");
		String username = bundle.getString("username");
		String password = bundle.getString("password");
		
		try {
			
			Class.forName("com.mysql.cj.jdbc.Driver");
			
			dbConnection = DriverManager.getConnection(url,username,password);
			statement = dbConnection.createStatement();
			
			dbConnection.setAutoCommit(false);
		} 
		catch (SQLException e) {
			e.printStackTrace();
		} 
		catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
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
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
}
