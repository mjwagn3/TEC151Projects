package ilstu.edu;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class MainClass {

	private static MorseCode morseCodeTree;

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		buildTree("morse_code.csv");
		String userInputStr = null;
		Scanner readUserInput = new Scanner(System.in);
		boolean run = true;
		do {

			System.out.print("Please enter encoded message or stop to exit: ");
			userInputStr = readUserInput.nextLine();
			if (!userInputStr.equals("stop")) {
				if (MainClass.hasValidMessage(userInputStr)) {
					System.out.print("The decoded message is: ");
					System.out.println(MainClass.decodeMessage(userInputStr));
				} else {
					System.out.println("Please enter a valid Morse Code!");
				}
			} else {
				run = false;
			}
		} while (run);
		readUserInput.close();
		System.out.println("Thank you for using our decoder!");

	}

	private static String decodeMessage(String message) {
		Scanner readMessage = new Scanner(message);
		StringBuilder sb = new StringBuilder();
		while (readMessage.hasNextLine()) {

			sb.append(MainClass.morseCodeTree.decode(readMessage.next()));

		}
		readMessage.close();
		return sb.toString();
	}

	private static boolean hasValidMessage(String message) {
		if (MainClass.hasValidCharacters(message)) {
			if (MainClass.hasValidLength(message)) {
				return true;
			}
		}
		return false;
	}

	private static boolean hasValidLength(String message) {
		String testMessageStr = message;
		try {
			@SuppressWarnings("resource")
			Scanner readMessage = new Scanner(testMessageStr);
			StringBuilder sb = new StringBuilder();
			while (readMessage.hasNextLine()) {
				sb.append(MainClass.morseCodeTree.decode(readMessage.next()));
			}
			return true;
		} catch (Exception ex) {
			return false;
		}

	}

	private static boolean hasValidCharacters(String message) {
		String testMessageStr = message;
		if (testMessageStr.indexOf('-') != -1)
			testMessageStr = testMessageStr.replace('-', ' ');
		if (testMessageStr.indexOf('.') != -1)
			testMessageStr = testMessageStr.replace('.', ' ');
		@SuppressWarnings("resource")
		Scanner readTestMessage = new Scanner(testMessageStr);
		return !readTestMessage.hasNext();
	}

	public static void buildTree(String fileName) {

		MainClass.morseCodeTree = new MorseCode();
		try {
			File file = new File(fileName);
			Scanner readFile = new Scanner(file);
			readFile.useDelimiter(",");
			@SuppressWarnings("unused")
			String trash = readFile.nextLine();
			while (readFile.hasNext()) {
				String line = readFile.nextLine();
				Scanner readLine = new Scanner(line);
				readLine.useDelimiter(",");

				char codeLetter = readLine.next().toLowerCase().charAt(0);
				String codeStr = readLine.next();
				readLine.close();
				morseCodeTree.add(codeStr, codeLetter);
			}
			readFile.close();

		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void test1() {
		char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
				's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
		String[] codes = { "•-", "-•••", "-•-•", "-••", "•", "••-•", "--•", "••••", "••", "•---", "-•-", "•-••", "--",
				"-•", "---", "•--•", "--•-", "•-•", "•••", "-", "••-", "•••-", "•--", "-••-", "-•--", "--••" };
		MorseCode m = new MorseCode();
		for (int i = 0; i < 26; i++) {
			m.add(codes[i], letters[i]);
		}
		for (int i = 0; i < 26; i++) {
			System.out.println(m.decode(codes[i]));
		}
		System.out.println(m.decode(" "));
		System.out.println(m);
	}
}
