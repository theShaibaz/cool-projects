package com.myntra.user;

import java.sql.SQLException;
import java.util.LinkedHashMap;
import java.util.Map.Entry;
import java.util.Set;

import com.myntra.consoleui.ConsoleUI;
import com.myntra.database.DatabaseConnection;
import com.myntra.database.DatabaseOperations;

public class UserCart {

	private UserCart() {
		
	}
	
	public static LinkedHashMap<Integer,String> cart = new LinkedHashMap<Integer,String>();
	private static int counter = 1;
	
	public static void addToCart(String order, Object[] productMenu) {
		
		String[] selectedProducts = order.split(",");
		
		try {
			
			for (String product : selectedProducts) {
				
				String productDesc = "";
				
				String[] productSplit = product.split(":");
				int productId = Integer.parseInt(productSplit[0]);
				int productQty = Integer.parseInt(productSplit[1]);
				
				String productString = productMenu[productId - 1] + "";
				String productName = productString.substring(0,productString.indexOf("="));
				int productPrice = Integer.parseInt(productString.substring(productString.indexOf("=") + 1));
				int totalPrice = productPrice * productQty;
				
				productDesc += productName + "," + productPrice + "," + productQty + "," + totalPrice;
				cart.put(counter++, productDesc);
				
				//	ADDING ENTRY TO TBL_CART [USING BATCH; NOT YET EXECUTED]
				DatabaseOperations.addToCart(DatabaseOperations.userId, productId, productQty, totalPrice);
			}
			
			//	EXECUTED AND ADDED ENTRIES TO TBL_CART
			DatabaseConnection.preparedStatement.executeBatch();
		}
		catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
	public static void updateQuantity(String quantities) {
		
		String[] updatedQuantities = quantities.split(",");
		Set<Entry<Integer, String>> cartEntries = cart.entrySet();
		Object[] cartProducts = cartEntries.toArray();
		
		try {
			
			for (String quantity : updatedQuantities) {
				
				String productDesc = "";
				
				String[] quantitySplit = quantity.split(":");
				int productId = Integer.parseInt(quantitySplit[0]);
				int productQty = Integer.parseInt(quantitySplit[1]);
				
				String productString = cartProducts[productId - 1] + "";
				String[] productStringSplit = productString.split(",");
				String productName = productStringSplit[0].substring(productStringSplit[0].indexOf("=") + 1);
				int productPrice = Integer.parseInt(productStringSplit[1]);
				int totalPrice = productPrice * productQty;
				productDesc += productName + "," + productPrice + "," + productQty + "," + totalPrice;
				
				cart.put(productId, productDesc);
				
				//	UPDATING ENTRY TO TBL_CART [USING BATCH; NOT YET EXECUTED]
				DatabaseOperations.updateCart(DatabaseOperations.userId, productId, productQty);
			}
			
			//	EXECUTED AND UPDATED ENTRIES TO TBL_CART
			DatabaseConnection.preparedStatement.executeBatch();
			
		}
		catch (SQLException e) {
			e.printStackTrace();
		}
		

	}
	
	public static void removeFromCart(int productId) {
		
		cart.remove(productId);
		
		try {
			DatabaseOperations.deleteFromCart(DatabaseOperations.userId, productId);
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void placeOrder() {
		
		showInvoice();
		cart.clear();
		counter = 1;
		
		try {
			DatabaseOperations.clearUserCart(DatabaseOperations.userId);
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void showCart() {
		
		String cartData = "";
		int grandTotal = 0;
		
		try {
			DatabaseConnection.resultSet = DatabaseOperations.selectFromCart(DatabaseOperations.userId);
			
			while(DatabaseConnection.resultSet.next()) {
				
				int serialNo = DatabaseConnection.resultSet.getInt("ID");
				String productName = DatabaseConnection.resultSet.getString("PRODUCT_NAME");
				String productPrice = DatabaseConnection.resultSet.getString("PRODUCT_PRICE");
				String productQty = DatabaseConnection.resultSet.getString("QUANTITY");
				int totalPrice = DatabaseConnection.resultSet.getInt("TOTAL_PRICE");
				
				grandTotal += totalPrice;
				
				cartData += String.format("%-20s%-5s%-50s%-20s%-10s%-20s\n",
						  "",serialNo + ". ",productName,productPrice,productQty,totalPrice);
			}
			
			cartData += ConsoleUI.getDashWidth();
			cartData += String.format("\n%-20s%-5s%-50s%-20s%-10s%-20s", "","","GRAND TOTAL","","",grandTotal);
			
			ConsoleUI.printCart(cartData);
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}

//		Set<Entry<Integer, String>> cartEntries = cart.entrySet();
//		for (Entry<Integer, String> cartEntry : cartEntries) {
//			
//			int serialNo = cartEntry.getKey();
//			String[] productDesc = cartEntry.getValue().split(",");
//			String productName = productDesc[0];
//			String productPrice = productDesc[1];
//			String productQty = productDesc[2];
//			String totalPrice = productDesc[3];
//			
//			grandTotal += Integer.parseInt(totalPrice);
//			
//			cartData += String.format("%-20s%-5s%-50s%-20s%-10s%-20s\n", 
//									  "",serialNo + ". ",productName,productPrice,productQty,totalPrice);
//		}
//		
//		cartData += ConsoleUI.getDashWidth();
//		cartData += String.format("\n%-20s%-5s%-50s%-20s%-10s%-20s", "","","GRAND TOTAL","","",grandTotal);
//		
//		ConsoleUI.printCart(cartData);
	}
	
	public static void showInvoice() {
		
		String cartData = "";
		int grandTotal = 0;
		
		try {
			DatabaseConnection.resultSet = DatabaseOperations.selectFromCart(DatabaseOperations.userId);
			
			while(DatabaseConnection.resultSet.next()) {
				
				int serialNo = DatabaseConnection.resultSet.getInt("ID");
				String productName = DatabaseConnection.resultSet.getString("PRODUCT_NAME");
				String productPrice = DatabaseConnection.resultSet.getString("PRODUCT_PRICE");
				String productQty = DatabaseConnection.resultSet.getString("QUANTITY");
				int totalPrice = DatabaseConnection.resultSet.getInt("TOTAL_PRICE");
				
				grandTotal += totalPrice;
				
				cartData += String.format("%-20s%-5s%-50s%-20s%-10s%-20s\n",
						  "",serialNo + ". ",productName,productPrice,productQty,totalPrice);
			}
			
			int sgst = (int) (grandTotal * 0.09);
			int cgst = (int) (grandTotal * 0.09);
			grandTotal += sgst + cgst;
			
			cartData += ConsoleUI.getDashWidth();
			cartData += String.format("\n%-20s%-5s%-50s%-20s%-10s%-20s\n", "","","SGST @9%","","",sgst);
			cartData += String.format("%-20s%-5s%-50s%-20s%-10s%-20s\n", "","","CGST @9%","","",cgst);
			cartData += ConsoleUI.getDashWidth();
			cartData += String.format("\n%-20s%-5s%-50s%-20s%-10s%-20s", "","","GRAND TOTAL","","",grandTotal);
			
			ConsoleUI.printInvoice(cartData);
		} 
		catch (SQLException e) {
			e.printStackTrace();
		}
		
//		Set<Entry<Integer, String>> cartEntries = cart.entrySet();
//		for (Entry<Integer, String> cartEntry : cartEntries) {
//			
//			int serialNo = cartEntry.getKey();
//			String[] productDesc = cartEntry.getValue().split(",");
//			String productName = productDesc[0];
//			String productPrice = productDesc[1];
//			String productQty = productDesc[2];
//			String totalPrice = productDesc[3];
//			
//			grandTotal += Integer.parseInt(totalPrice);
//			
//			cartData += String.format("%-20s%-5s%-50s%-20s%-10s%-20s\n", 
//									  "",serialNo + ". ",productName,productPrice,productQty,totalPrice);
//		}
//		
//		int sgst = (int) (grandTotal * 0.09);
//		int cgst = (int) (grandTotal * 0.09);
//		grandTotal += sgst + cgst;
//		
//		cartData += ConsoleUI.getDashWidth();
//		cartData += String.format("\n%-20s%-5s%-50s%-20s%-10s%-20s\n", "","","SGST @9%","","",sgst);
//		cartData += String.format("%-20s%-5s%-50s%-20s%-10s%-20s\n", "","","CGST @9%","","",cgst);
//		cartData += ConsoleUI.getDashWidth();
//		cartData += String.format("\n%-20s%-5s%-50s%-20s%-10s%-20s", "","","GRAND TOTAL","","",grandTotal);
//		
//		ConsoleUI.printInvoice(cartData);
	}
	
}
