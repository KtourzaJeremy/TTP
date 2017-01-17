package com.example;

public class Admin extends Member {

	/**
	 * 
	 */
	private static final long serialVersionUID = -2348487959769490516L;
	private String role;

	public Admin(String userName,String password, String FN, String LN, String num, String email, String role) {
		super(userName,password, FN, LN, num, email);
		this.role = role;
	}

	public String getRole() {
		return role;
	}

	public void setRole(String role) {
		this.role = role;
	}
}
