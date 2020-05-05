package com.myntra.consoleui;

import com.myntra.database.DatabaseOperations;

public class ConsoleUI {

	private ConsoleUI() {
		
	}
	
	static int width = 127, height = 22;
	
	static String starWidth = "**", spaceWidth = "", dashWidth = "--", spaceTen = "", spaceTwenty = "", spaceForty = "";
	static String logo = "      MYNTRA LA LA       ";
	static String heading = "";
	
	static {
		
		for (int index = 0; index < 10; index++) {
			spaceTen += " ";
		}
		
		spaceTwenty += spaceTen + spaceTen;
		spaceForty += spaceTwenty + spaceTwenty;
		
		for (int index = 0; index < width - 2; index++) {
			starWidth += "*";
			spaceWidth += " ";
			dashWidth += "-";
		}
		
		heading = "*" + spaceForty + spaceTen + logo + spaceForty + spaceTen + "*";
		
	}
	
	public static String getDashWidth() {
		return dashWidth;
	}
	
	public static void updateScreen(String menu) {
		
		System.out.println();
		System.out.println(starWidth);
		System.out.println("*" + spaceWidth + "*");
		System.out.println(heading);
		System.out.println("*" + spaceWidth + "*");
		System.out.println(starWidth);
		System.out.println();
		System.out.println("WELCOME " + DatabaseOperations.userName);
		System.out.println();
		System.out.println(menu);
		System.out.println(starWidth);
		System.out.println();
	}
	
	public static void printCart(String cart) {
		
		System.out.println();
		System.out.println(starWidth);
		System.out.println("*" + spaceWidth + "*");
		System.out.println(heading);
		System.out.println("*" + spaceWidth + "*");
		System.out.println(starWidth);
		System.out.println();
		System.out.println();
		System.out.println(dashWidth);
		System.out.println(spaceForty + spaceTwenty + "MY CART" + spaceTwenty + spaceForty);
		System.out.println(dashWidth);
		System.out.printf("%-20s%-5s%-50s%-20s%-10s%-20s\n","","SR","PRODUCT","PRICE","QTY","TOTAL");
		System.out.println(dashWidth);
		System.out.println(cart);
		System.out.println(dashWidth);
		System.out.println();
		System.out.println();
		System.out.println("1. CHANGE QTY");
		System.out.println("2. REMOVE PRODUCT");
		System.out.println("3. PLACE ORDER");
		System.out.println("4. GO HOME");
		System.out.println();
		System.out.println();
		System.out.println(starWidth);
		System.out.println();
	}

	public static void printInvoice(String invoice) {
		
		System.out.println();
		System.out.println(starWidth);
		System.out.println("*" + spaceWidth + "*");
		System.out.println(heading);
		System.out.println("*" + spaceWidth + "*");
		System.out.println(starWidth);
		System.out.println();
		System.out.println();
		System.out.println(dashWidth);
		System.out.println(spaceForty + spaceTwenty + "INVOICE" + spaceTwenty + spaceForty);
		System.out.println(dashWidth);
		System.out.printf("%-20s%-5s%-50s%-20s%-10s%-20s\n","","SR","PRODUCT","PRICE","QTY","TOTAL");
		System.out.println(dashWidth);
		System.out.println(invoice);
		System.out.println(dashWidth);
		System.out.println();
		System.out.println();
		System.out.println(starWidth);
		System.out.println();
		
		System.out.println("ORDER PLACED SUCCESSFULLY");
	}
	
}








