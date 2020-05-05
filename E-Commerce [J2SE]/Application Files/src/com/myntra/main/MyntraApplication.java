package com.myntra.main;

import java.util.Map.Entry;
import java.util.Set;

import com.myntra.user.PasswordException;
import com.myntra.user.User;
import com.myntra.user.UserCart;
import com.myntra.user.UserValidations;
import com.myntra.user.UsernameException;

public class MyntraApplication {
	
	public static void main(String[] args) {
		
		int choiceSubMenu = 0;
		int choiceProducts = 0;
		
		int isMenu = 1;
		int isSubMenu = 0;
		int isCart = 1;
		
		Set<Entry<String,Integer>> productsMenu;
		String addChoice;
		
		String username = "";
		String password = "";
		
		while(true) {
			
			try {
				
				if(username == "") {
					System.out.print("ENTER USERNAME : ");
					username = ApplicationHelper.input.nextLine();
				}
				
				if(UserValidations.isUsernameValid(username)) {
						
					if(password == "") {
						System.out.print("ENTER PASSWORD : ");
						password = ApplicationHelper.input.nextLine();
					}
					
					if(UserValidations.isPasswordValid(password)) {
						User myntraUser = new User(username,password);
					}
				}
					
				while(true) {
						
					if(isMenu == 1) {
						ApplicationHelper.printMenu();
						isCart = 1;
					}
						
					if(isMenu == 1) {
						System.out.print("ENTER YOUR CHOICE : ");
						choiceSubMenu = ApplicationHelper.input.nextInt();
						
						isMenu = 0;
						isSubMenu = 1;
					}
						
					switch (choiceSubMenu) {
						
						case 1:
								
							Object women = ApplicationHelper.getSubMenu("WOMEN");
								
							if(isSubMenu == 1) {
								ApplicationHelper.printSubMenu("WOMEN");
								System.out.print("ENTER YOUR CHOICE : ");
								choiceProducts = ApplicationHelper.input.nextInt();
								
								isSubMenu = 0;
							}
			
							switch (choiceProducts) {
									
								case 1:
										
									productsMenu = ApplicationHelper.printProducts(women, "ETHNIC");
										
									System.out.print("DO YOU WANT TO ADD PRODUCTS TO CART (Y/N) ? : ");
									addChoice = ApplicationHelper.input.next();
										
									if(addChoice.equalsIgnoreCase("y")) {
										ApplicationHelper.takeOrder(productsMenu);
									}
									else if(addChoice.equalsIgnoreCase("n")) {
										isSubMenu = 1;
									}
									else {
										System.out.println("\nINVALID CHOICE");
									}
								
								break;
				
								case 2: 
										
									productsMenu = ApplicationHelper.printProducts(women, "WESTERNWEAR");
									
									System.out.print("DO YOU WANT TO ADD PRODUCTS TO CART (Y/N) ? : ");
									addChoice = ApplicationHelper.input.next();
										
									if(addChoice.equalsIgnoreCase("y")) {
										ApplicationHelper.takeOrder(productsMenu);
									}
									else if(addChoice.equalsIgnoreCase("n")) {
										isSubMenu = 1;
									}
									else {
										System.out.println("\nINVALID CHOICE");
									}
									
								break;
									
								case 3:
										
									productsMenu = ApplicationHelper.printProducts(women, "FOOTWEAR");
									
									System.out.print("DO YOU WANT TO ADD PRODUCTS TO CART (Y/N) ? : ");
									addChoice = ApplicationHelper.input.next();
										
									if(addChoice.equalsIgnoreCase("y")) {
										ApplicationHelper.takeOrder(productsMenu);
									}
									else if(addChoice.equalsIgnoreCase("n")) {
										isSubMenu = 1;
									}
									else {
										System.out.println("\nINVALID CHOICE");
									}
									
								break;
									
								case 4:
									
									isMenu = 1;
									isSubMenu = 0;
									
								break;

								default:
									
									System.out.println("\nINVALID CHOICE");
									isSubMenu = 1;
									
								break;
									
							}
								
						break;
						
						case 2:
							
							Object men = ApplicationHelper.getSubMenu("MEN");
							
							if(isSubMenu == 1) {
								ApplicationHelper.printSubMenu("MEN");
								System.out.print("ENTER YOUR CHOICE : ");
								choiceProducts = ApplicationHelper.input.nextInt();
								
								isSubMenu = 0;
							}
			
							switch (choiceProducts) {
									
								case 1:
										
									productsMenu = ApplicationHelper.printProducts(men, "TOPWEAR");
										
									System.out.print("DO YOU WANT TO ADD PRODUCTS TO CART (Y/N) ? : ");
									addChoice = ApplicationHelper.input.next();
										
									if(addChoice.equalsIgnoreCase("y")) {
										ApplicationHelper.takeOrder(productsMenu);
									}
									else if(addChoice.equalsIgnoreCase("n")) {
										isSubMenu = 1;
									}
									else {
										System.out.println("\nINVALID CHOICE");
									}
								
								break;
				
								case 2: 
										
									productsMenu = ApplicationHelper.printProducts(men, "BOTTOMWEAR");
									
									System.out.print("DO YOU WANT TO ADD PRODUCTS TO CART (Y/N) ? : ");
									addChoice = ApplicationHelper.input.next();
										
									if(addChoice.equalsIgnoreCase("y")) {
										ApplicationHelper.takeOrder(productsMenu);
									}
									else if(addChoice.equalsIgnoreCase("n")) {
										isSubMenu = 1;
									}
									else {
										System.out.println("\nINVALID CHOICE");
									}
									
								break;
									
								case 3:
										
									productsMenu = ApplicationHelper.printProducts(men, "FOOTWEAR");
									
									System.out.print("DO YOU WANT TO ADD PRODUCTS TO CART (Y/N) ? : ");
									addChoice = ApplicationHelper.input.next();
										
									if(addChoice.equalsIgnoreCase("y")) {
										ApplicationHelper.takeOrder(productsMenu);
									}
									else if(addChoice.equalsIgnoreCase("n")) {
										isSubMenu = 1;
									}
									else {
										System.out.println("\nINVALID CHOICE");
									}
									
								break;
									
								case 4:
									
									isMenu = 1;
									isSubMenu = 0;
									
								break;

								default:
									
									System.out.println("\nINVALID CHOICE");
									isSubMenu = 1;
									
								break;
									
							}
								
						break;
							
						case 6:
								
							if(isCart == 1) {
									
								if(UserCart.cart.size() > 0) {
										
									UserCart.showCart();
										
									System.out.print("ENTER YOUR CHOICE : ");
									int choiceCart = ApplicationHelper.input.nextInt();
										
									switch (choiceCart) {
										
										case 1:
												
											System.out.print("ENTER UPDATED QTY (PROD_ID:NEW_QTY) : ");
											ApplicationHelper.input.nextLine();
											String quantity = ApplicationHelper.input.nextLine();
											UserCart.updateQuantity(quantity);
											
										break;
						
										case 2:
												
											System.out.print("ENTER PRODUCT ID : ");
											int productId = ApplicationHelper.input.nextInt();
											UserCart.removeFromCart(productId);
												
										break;
											
										case 3:
												
											ApplicationHelper.input.nextLine();
											UserCart.placeOrder();
											ApplicationHelper.input.nextLine();
											isMenu = 1;
											isCart = 0;
												
										break;
											
										case 4:
											
											isMenu = 1;
											isCart = 0;
											
										break;
										
										default:
											
											System.out.println("\nINVALID CHOICE");
											
										break;
										
									}
										
								}
								else {
										
									System.out.println();
									System.out.println("CART IS EMPTY");
									isMenu = 1;
								}
							
							}
			
						break;
							
						default:
							
							System.out.println("\nINVALID CHOICE");
							isMenu = 1;
							
						break;
							
					}
						
				}
			
			} catch (UsernameException ue) {
				System.out.println(ue.getMessage());
				username = "";
			} catch (PasswordException pe) {
				System.out.println(pe.getMessage());
				password = "";
			} catch (Exception e) {
				System.out.println("UNHANDLED EXCEPTION");
			}
		
		}
	
	}
}
