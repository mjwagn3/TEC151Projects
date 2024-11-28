package isu.edu;

import java.util.Scanner;

public class MainClass {

	/**
	 * MainClass 
	 * 
	 * @author Michael Wagner
	 */
	/**
	 * 
	 * main method 
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("Welcome to Card Game.\nPress [Enter] key to continue");
		s.nextLine();

		String[] names = { "Player 1", "Player 2", "Player 3" };

		System.out.println("Our players are: ");
		for (int i = 0; i < names.length; i++) {
			System.out.print("\t\"");
			System.out.print(names[i]);
			System.out.println("\"");
		}
		System.out.println("Good luck to our players!\nPress [Enter] key to continue");
		s.nextLine();
		new Game(names);
		s.close();
	}
}
