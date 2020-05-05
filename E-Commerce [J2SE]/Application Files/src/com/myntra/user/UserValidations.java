package com.myntra.user;

public class UserValidations {

	private UserValidations() {
		
	}
	
	public static boolean isUsernameValid(String username) throws UsernameException {
		
		if(username.contains(" ") || username.length() < 8) {
			throw new UsernameException();
		}
		
		return true;
	}
	
	public static boolean isPasswordValid(String password) throws PasswordException {
		
		if(password.contains(" ") || password.length() < 8) {
			throw new PasswordException();
		}
		
		return true;
	}
}
