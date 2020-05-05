package com.myntra.categories;

import java.util.LinkedHashMap;

public class Categories {
	 
	private Categories() {
		
	}
	
	public static LinkedHashMap<String,Object> mainCategories = new LinkedHashMap<String,Object>();

	static{
		
			LinkedHashMap<String,Object> women = new LinkedHashMap<String,Object>();
				LinkedHashMap<String,Integer> ethnicW = new LinkedHashMap<String,Integer>();
				ethnicW.put("Block Print Kurta", 599);
				ethnicW.put("Yoke Design Kurta", 999);
				ethnicW.put("Checked A-Line Kurta", 1499);
				ethnicW.put("Striped Line Kurta", 699);
				ethnicW.put("Solid Print Kurta", 799);
			women.put("ETHNIC", ethnicW);
				
				LinkedHashMap<String,Integer> westernwearW = new LinkedHashMap<String,Integer>();
				westernwearW.put("Solid Sheath Dress", 799);
				westernwearW.put("Fit & Flare Dress", 1799);
				westernwearW.put("Solid Empire Dress", 1199);
				westernwearW.put("Polo-Neck Dress", 1499);
				westernwearW.put("Denim Dungaree", 1599);
			women.put("WESTERNWEAR", westernwearW);
				
				LinkedHashMap<String,Integer> footwearW = new LinkedHashMap<String,Integer>();
				footwearW.put("Solid White Sneakers", 1499);
				footwearW.put("Arkyn Sneakers", 1399);
				footwearW.put("Slip-On Sneakers", 499);
				footwearW.put("Horsebit Loafers", 999);
				footwearW.put("Snakeskin Texture Heels", 2599);
				footwearW.put("Slip-On Running Shoes", 1499);
			women.put("FOOTWEAR", footwearW);
				
		mainCategories.put("WOMEN", women);
		
			LinkedHashMap<String,Object> men = new LinkedHashMap<String,Object>();
				LinkedHashMap<String,Integer> topwearM = new LinkedHashMap<String,Integer>();
				topwearM.put("Solid Polo Collar T-Shirt", 1599);
				topwearM.put("V-Neck T-Shirt", 1499);
				topwearM.put("Slim Fit Casual Shirt", 1199);
				topwearM.put("Striped Line Shirt", 699);
				topwearM.put("Solid Print Formal Shirt", 799);
			men.put("TOPWEAR", topwearM);
				
				LinkedHashMap<String,Integer> bottomwearM = new LinkedHashMap<String,Integer>();
				bottomwearM.put("Skinny Fit Jeans", 799);
				bottomwearM.put("Straight Fit Jeans", 1799);
				bottomwearM.put("Slim Tapered Leg Jeans", 1199);
				bottomwearM.put("Polo-Neck Dress", 1399);
				bottomwearM.put("Slim Fit Jeans", 599);
			men.put("BOTTOMWEAR", bottomwearM);
				
				LinkedHashMap<String,Integer> footwearM = new LinkedHashMap<String,Integer>();
				footwearM.put("Men Flat Boots", 1499);
				footwearM.put("Casual Shoes", 1399);
				footwearM.put("Leather Sneakers", 499);
				footwearM.put("Men Nubuck Derbys", 999);
				footwearM.put("Slip-On Running Shoes", 1499);
			men.put("FOOTWEAR", footwearM);
				
		mainCategories.put("MEN", men);
		
		mainCategories.put("KIDS", women);
		mainCategories.put("BEAUTY", women);
		mainCategories.put("GADGETS", women);
	}
	
}
