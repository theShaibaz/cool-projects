package com.mutiny.dao;

public class SearchUserHolder {

	private int userId;
	private String requestResult;
	
	public SearchUserHolder(int userId, String requestResult) {
		super();
		this.userId = userId;
		this.requestResult = requestResult;
	}
	
	public int getUserId() {
		return userId;
	}
	
	public void setUserId(int userId) {
		this.userId = userId;
	}
	
	public String getRequestResult() {
		return requestResult;
	}
	
	public void setRequestResult(String requestResult) {
		this.requestResult = requestResult;
	}
	
	@Override
	public String toString() {
		return "SearchUserHolder [userId=" + userId + ", requestResult=" + requestResult + "]";
	}
	
}
