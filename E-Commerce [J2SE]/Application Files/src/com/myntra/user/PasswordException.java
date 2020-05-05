package com.myntra.user;

public class PasswordException extends Exception{

	@Override
	public String getMessage() {
		return "\nINCORRECT PASSWORD FORMAT\n";
	}
	
}
