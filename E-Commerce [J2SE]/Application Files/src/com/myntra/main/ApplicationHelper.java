package com.myntra.main;

import java.util.Map;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.Set;

import com.myntra.categories.Categories;
import com.myntra.consoleui.ConsoleUI;
import com.myntra.user.UserCart;

public class ApplicationHelper {

	private ApplicationHelper() {
		
	}
	
	static Scanner input = new Scanner(System.in);
	
	public static void printMenu() {
		
		String menu = "";
		int counter = 1;
		
		Set<String> keySet = Categories.mainCategories.keySet();
		for (String key : keySet) {
			menu += counter++ + ". " + key + "\n\n";
		}

		
		if(UserCart.cart.size() > 0) {
			menu += counter++ + ". MYCART [" + UserCart.cart.size() + "]\n";
		}
		else {
			menu += counter++ + ". MYCART\n";
		}
				
		ConsoleUI.updateScreen(menu);
		
	}
	
	public static Object getSubMenu(String category) {
		
		Object subCategory = Categories.mainCategories.get(category);
		return subCategory;
	}
	
	public static Object printSubMenu(String category) {
		
		Object subCategory = Categories.mainCategories.get(category);
		Set<String> subCategories = ((Map) subCategory).keySet();
		
		int counter = 1;
		String menu = "";
		
		for (String subCat : subCategories) {
			menu += counter++ + ". " + subCat + "\n\n";
		}
		
		menu += counter++ + ". GO HOME\n";
		
		ConsoleUI.updateScreen(menu);
		
		return subCategory;
	}
	
	public static Set<Entry<String, Integer>> printProducts(Object category, String subCategory) {
		
		Object products = ((Map) category).get(subCategory);
		Set<Entry<String,Integer>> productsMenu = ((Map) products).entrySet();

		int counter = 1;
		String menu = "";
		
		menu += String.format("%-5s%-50s%-20s\n\n", "SR","PRODUCT","PRICE");
		
		for (Entry<String,Integer> product : productsMenu) {
			menu += String.format("%-5s%-50s%-20s\n\n", counter++ + ".", product.getKey(), "INR " + product.getValue()) ;
		}
		
		ConsoleUI.updateScreen(menu);
		
		return productsMenu;
	}
	
	public static void takeOrder(Set<Entry<String,Integer>> productsMenu) {
		
		System.out.print("ENTER YOUR ORDER (PROD_ID:QTY) : ");
		input.nextLine();
		String order = input.nextLine();
		UserCart.addToCart(order,productsMenu.toArray());
	}
	
	
}
