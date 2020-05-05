package com.myntra.user;

public class UsernameException extends Exception{

	@Override
	public String getMessage() {
		return "\nINCORRECT USERNAME FORMAT\n";
	}
}
