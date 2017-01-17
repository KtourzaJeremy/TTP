package com.example;



import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class Member implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1296713157556705603L;
	private static int count;
	private String firstName;
	private String lastName;
	private String phoneNumber;
	private String email;
	private String userName;
	private String password;

	public Member(String userName,String password, String FN, String LN, String num, String email) {
		this.userName = userName;
		this.password = password;
		this.firstName = FN;
		this.lastName = LN;
		this.phoneNumber = num;
		this.setEmail(email);
		count++;
	}

	public Member(String userName, String FN, String LN) {
		this(userName, "",FN, LN, "", "");
	}

	public Member(String fullName, String email) {
		this(Integer.toString(count), "",fullName.substring(0, fullName.indexOf(" ")),
				fullName.substring(fullName.indexOf(" "), fullName.length()), "", email);

	}

	public static void saveMember(Member member, String filename) {
		FileOutputStream saveFile;
		try {
			saveFile = new FileOutputStream(filename);
			ObjectOutputStream save = new ObjectOutputStream(saveFile);
			save.writeObject(member);
			save.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}
	public static void saveMemberList(List<Member> memberlist, String filename) {
		FileOutputStream saveFile;
		try {
			saveFile = new FileOutputStream(filename);
			ObjectOutputStream save = new ObjectOutputStream(saveFile);
			for (int i = 0; i < memberlist.size(); i++) {
				save.writeObject(memberlist.get(i));
			}
			save.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}
	
	
	
	public static List<Member> LoadMemberList(String filename){
		List<Member> membres = new ArrayList<Member>();
	
		try {
			FileInputStream saveFile = new FileInputStream(filename);
			ObjectInputStream restore = new ObjectInputStream(saveFile);
			while( saveFile.available() > 0) 
			   {
			      Member mouton = (Member)restore.readObject();
			      membres.add(mouton);
			   }
			restore.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			
		}
		
		return membres;
		
	}
	public String toString() {
		StringBuffer sb = new StringBuffer();
		sb.append("pseudo : " + userName + "\n");
		sb.append("nom : " + firstName + " " + lastName.toUpperCase() + "\n");
		sb.append("téléphone : " + phoneNumber + "\n");
		sb.append("email : " + email + "\n");
		return sb.toString();
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getPhoneNumber() {
		return phoneNumber;
	}

	public void setPhoneNumber(String phoneNumber) {
		this.phoneNumber = phoneNumber;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getUserName() {
		return userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

}
