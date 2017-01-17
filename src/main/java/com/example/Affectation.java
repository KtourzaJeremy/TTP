package com.example;

public class Affectation {
	public Event event;
	public Member member;
	
	public Affectation(Event event, Member member) {
		this.event = event;
		this.member = member;
	}
	
	public Event getEvent() {
		return event;
	}
	
	public Member getMember() {
		return member;
	}
}