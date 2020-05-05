package com.library.main;

public class LibraryApplication {

	public static void main(String[] args) {

		int menuChoice = 1, subMenuChoice, ratings, newPrice, intChoice;
		float percent = 0;
		String strChoice = null;
		
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		ApplicationHelper.startApplication();

		do {
			
			System.out.println();
			System.out.println("1.INSERT BOOKS");
			System.out.println("2.UPDATE BOOKS");
			System.out.println("3.DELETE BOOKS");
			System.out.println("4.DISPLAY BOOKS");
			System.out.println("0.EXIT");
			System.out.println("ENTER YOUR CHOICE : ");
			menuChoice = ApplicationHelper.input.nextInt();
			
			switch (menuChoice) {
				
				case 1:
					
					ApplicationHelper.addBooks();
					
				break;
	
				case 2:
					
					System.out.println();
					System.out.println("1.UPDATE PRICE BY RATINGS AND PERCENTAGE INCREMENT");
					System.out.println("2.UPDATE PRICE BY RATINGS AND NEW PRICE");
					System.out.println("3.UPDATE PRICE BY RATINGS");
					System.out.println("ENTER YOUR CHOICE : ");
					subMenuChoice = ApplicationHelper.input.nextInt();
					
					switch (subMenuChoice) {
						
						case 1:
							
							System.out.print("ENTER BOOK RATING AND PERCENTAGE INCREMENT FOR PRICE : ");
							ratings = ApplicationHelper.input.nextInt();
							percent = ApplicationHelper.input.nextFloat();
							ApplicationHelper.updatePrice(ratings, percent);
							
						break;
		
						case 2:
							
							System.out.print("ENTER BOOK RATING AND NEW PRICE : ");
							ratings = ApplicationHelper.input.nextInt();
							newPrice = ApplicationHelper.input.nextInt();
							ApplicationHelper.updatePrice(ratings, newPrice);
							
						break;
						
						case 3:
							
							ApplicationHelper.updatePrice();
							
						break;
						
						default:
							
							System.out.println("INVALID CHOICE");
							
						break;
					}
					
				break;
				
				case 3:
					
					System.out.println();
					System.out.println("1.DELETE BOOKS BY PUBLISHER");
					System.out.println("2.DELETE BOOKS BY AUTHOR");
					System.out.println("3.DELETE BOOKS BY NAME");
					System.out.println("4.DELETE BOOKS BY ISBN");
					System.out.println("5.DELETE BOOKS BY PRICE");
					System.out.println("6.DELETE BOOKS BY RATINGS");
					System.out.println("7.DELETE REPEATED BOOKS");
					System.out.println("ENTER YOUR CHOICE : ");
					subMenuChoice = ApplicationHelper.input.nextInt();
					
					switch (subMenuChoice) {
					
						case 1:
							
							ApplicationHelper.input.nextLine();
							System.out.println("ENTER PUBLISHER NAME : ");
							strChoice = ApplicationHelper.input.nextLine();
							
							ApplicationHelper.deleteBooks("PUBLISHER", strChoice);
							
						break;
						
						case 2:
							
							ApplicationHelper.input.nextLine();
							System.out.println("ENTER AUTHOR NAME : ");
							strChoice = ApplicationHelper.input.nextLine();
							
							ApplicationHelper.deleteBooks("AUTHOR", strChoice);
							
						break;
						
						case 3:
			
							ApplicationHelper.input.nextLine();
							System.out.println("ENTER BOOK NAME : ");
							strChoice = ApplicationHelper.input.nextLine();
							
							ApplicationHelper.deleteBooks("NAME", strChoice);
							
						break;
							
						case 4:
			
							System.out.println("ENTER ISBN NUMBER : ");
							intChoice = ApplicationHelper.input.nextInt();
							
							ApplicationHelper.deleteBooks("ISBN", intChoice);
							
						break;
						
						case 5:
			
							System.out.println("ENTER BOOK PRICE : ");
							intChoice = ApplicationHelper.input.nextInt();
							
							ApplicationHelper.deleteBooks("PRICE", intChoice);
							
						break;
						
						case 6:
			
							System.out.println("ENTER BOOK RATINGS : ");
							intChoice = ApplicationHelper.input.nextInt();
							
							ApplicationHelper.deleteBooks("RATINGS", intChoice);
							
						break;
						
						case 7:
			
							ApplicationHelper.deleteSameBooks();
							
						break;
		
						default:
							
							System.out.println("INVALID CHOICE");
							
						break;
					}
					
				break;
				
				case 4:
					
					ApplicationHelper.displayBooks();
					
				break;
				
				case 0:
					
					ApplicationHelper.closeDB();
					System.exit(1);
					
				break;
				
				default:
					
					System.out.println("INVALID CHOICE");
					
				break;
			}
			
		}while(menuChoice != 0);
		
	}

}
