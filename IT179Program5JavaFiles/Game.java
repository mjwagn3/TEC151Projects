package isu.edu;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Scanner;
import java.util.Stack;

public class Game {
	/**
	 * this is the Game class, here it will hold all the cards and the actual game
	 * will be played by the players. Each game has a constant array of types this
	 * is for me to not having to keep copy and pasting. Also this holds the correct
	 * order for which the types will be unshuffled
	 * 
	 * it has a linked list of unshuffled cards, no face cards so it holds ACE to 10
	 * of hearts, diamonds, clubs, spades in that order
	 * 
	 * a stack of Strings that represent the cards that are shuffled deck,
	 * 
	 * a stack of Strings that represent the cards that are discarded by players
	 * 
	 * a queue of Player types
	 * 
	 * @author Michael Wagner
	 */
	public final char[] TYPES = { '♥', '♦', '♣', '♠' };
	private LinkedList<String> unshuffledCards;
	private Stack<String> faceDownCards;
	private Stack<String> faceUpCards;
	private Queue<Player> players;

	/**
	 * Game constructor, calls for an array of names to be pasted, it will inital
	 * the face up cards and then make a new deck of unshuffled cards and then it
	 * will shuffle the cards, then create all the players, and finally will play
	 * the game
	 * 
	 * @param names
	 */
	public Game(String[] names) {
		this.faceUpCards = new Stack<>();
		this.setUnshuffledDeck();
		this.shuffle();
		this.setPlayer(names);
		this.play();

	}

	/**
	 * Sets the names of players, call for the array of names to set player names
	 * 
	 * @param names
	 */
	private void setPlayer(String[] names) {
		this.players = new LinkedList<>();
		for (int i = 0; i < names.length; i++) {
			String name = names[i];
			String cardsInHand[] = new String[4];
			for (int j = 0; j < cardsInHand.length; j++) {
				cardsInHand[j] = this.faceDownCards.pop();
			}

			Player player = new Player(name, cardsInHand[0], cardsInHand[1], cardsInHand[2], cardsInHand[3]);
			this.players.offer(player);
		}
		Player ogPlayer = this.players.poll();
		this.players.offer(ogPlayer);
		ogPlayer.viewHand();
		while (!this.players.element().getName().equals(ogPlayer.getName())) {
			Player player = this.players.poll();
			this.players.offer(player);
			player.viewHand();
		}
	}

	/**
	 * Creates a new un-shuffled deck filled with cards represent as strings, that
	 * is store in the unshuffledCards Linked List
	 */
	private void setUnshuffledDeck() {
		this.unshuffledCards = new LinkedList<>();
		for (int i = 0; i < this.TYPES.length; i++) {
			for (int j = 1; j <= 10; j++) {
				String card = this.setCard(i, j);
				this.unshuffledCards.add(card);
			}
		}
	}

	/**
	 * Views the un-shuffled deck, by printing the cards
	 */
	public void viewUnshuffledDeck() {
		for (int i = 0; i < this.unshuffledCards.size(); i++) {
			String card = this.unshuffledCards.get(i);
			System.out.println(card);
			int cardValue = this.getCardValue(card);
			if (cardValue % 10 == 0)
				System.out.println();

		}
	}

	/**
	 * Sets the cards as a string,
	 * 
	 * @param typeIndex
	 * @param cardNumber
	 * @return cards
	 */
	private String setCard(int typeIndex, int cardNumber) {
		StringBuilder sb = new StringBuilder();

		if (typeIndex < 0 || typeIndex >= this.TYPES.length) {
			throw new IndexOutOfBoundsException(Integer.toString(typeIndex));
		}
		if (cardNumber <= 0 || cardNumber > 10) {
			sb.append("Card number has to be 1 to 10, not ");
			sb.append(Integer.toString(cardNumber));
			throw new IndexOutOfBoundsException(sb.toString());
		}
		if (cardNumber == 1) {
			sb.append("ACE of ");
		} else {
			if (cardNumber == 10) {
				sb.append("0");

			} else {
				sb.append("00");
			}
			sb.append(Integer.toString(cardNumber));
			sb.append(" of ");
		}
		sb.append(this.TYPES[typeIndex]);
		return sb.toString();

	}

	/**
	 * calculates the value of the card
	 * 
	 * @param card
	 * @return the value of the card
	 */
	public int getCardValue(String card) {
		if (card.contains("ACE"))
			return 1;
		else
			return Integer.parseInt(card.substring(0, 3));
	}

	/**
	 * Shuffles the deck
	 */
	private void shuffle() {
		if (this.faceDownCards == null)
			this.faceDownCards = new Stack<>();
		else
			while (!this.faceDownCards.empty())
				this.faceDownCards.pop();
		int[] order = new int[this.unshuffledCards.size()];
		for (int i = 0; i < order.length; i++)
			order[i] = -1;
		order[0] = (int) Math.random() * this.unshuffledCards.size();
		for (int i = 1; i < order.length; i++) {
			int cardNumber = (int) (Math.random() * 40);
			if (this.indexOf(cardNumber, order) == -1) {
				order[i] = cardNumber;
			} else {
				i--;
			}
		}
		for (int i = 0; i < order.length; i++)
			this.faceDownCards.push(this.unshuffledCards.get(order[i]));

	}

	/**
	 * Finds the index of a specific order of a card
	 * 
	 * @param num
	 * @param order
	 * @return index of a card
	 */
	private int indexOf(int num, int[] order) {
		for (int i = 0; i < order.length; i++) {
			if (num == order[i])
				return i;
		}
		return -1;
	}

	/**
	 * This plays the game. first the game plays by seeing if an players have one a
	 * hand, it displays the players, and then each will player if the face up cards
	 * stack is empty, will draw from the face down cards. Then it will throw card
	 * that helps reach the player to win. Will only draw from floor if its the
	 * winning move
	 */
	public void play() {
		boolean won = false;
		int rounds = 1;
		int turn = 0;
		rounds = 3;
		if (this.winningPlayer() == null) {
			System.out.print("Round: ");
			System.out.print(rounds / 3);
			System.out.print(" || Turn: ");
			System.out.println(turn);
			this.printPlayerList();
			this.printBoardDisplay();
			Player player = this.players.poll(), winningPlayer = null;
			this.userRespond(player);
			this.players.offer(player);

			while (!won) {
				turn++;
				won = player.throwCard(faceDownCards, faceUpCards);
				if (won) {

					winningPlayer = player;
					System.out.println("Last Round State: ");
					this.printPlayerList();
					this.printBoardDisplay();
					this.userRespondWinner(winningPlayer);

				}
				if (!won) {
					System.out.print("Round: ");
					System.out.print(rounds / 3);
					System.out.print(" || Turn: ");
					System.out.println(turn);
					rounds++;

					this.printPlayerList();
					this.printBoardDisplay();
					this.userRespond(player);
					player = this.players.poll();
					this.players.offer(player);

				}

				if (this.faceDownCards.empty()) {
					this.shuffle();
				}

			}
		} else {
			userRespondWinner(this.winningPlayer());
		}
	}

	/**
	 * Prints each of the players hands
	 */
	private void printPlayerList() {
		Player player = this.players.poll();
		System.out.println(player.viewHand());
		Queue<Player> temp = new LinkedList<>();
		temp.offer(player);
		while (players.peek() != null) {
			player = this.players.poll();
			System.out.println(player.viewHand());
			temp.offer(player);
		}
		this.players = temp;

	}

	/**
	 * displays the board info, shows the face up card, and displays the face down
	 * card. Don't worry the players dont know what the face down cards are, only we
	 * do, thats what the [] are for
	 */
	private void printBoardDisplay() {

		System.out.println();
		if (!this.faceUpCards.empty()) {
			System.out.print("Face Up Cards: ");
			System.out.println(this.faceUpCards.peek());
			System.out.println();

		}

		if (!this.faceDownCards.empty()) {
			System.out.print("Face Dn Cards: ");
			System.out.print("[");
			System.out.print(this.faceDownCards.peek());
			System.out.println("]");
		}

	}

	/**
	 * This is views the current state of a player, takes a player object, it has
	 * user input to control the flow of the program
	 * 
	 * @param p
	 */
	private void userRespond(Player p) {
		Scanner s = new Scanner(System.in);
		System.out.print("\nHere is the current state, ");
		System.out.print(p.getName());
		System.out.println(" will go.\n\tPress [Enter] key to continue\n");
		s.nextLine();
	}

	/**
	 * Displays the winning player, takes the winning player object, has user input to control the flow of the program
	 * @param p
	 */
	private void userRespondWinner(Player p) {
		Scanner s = new Scanner(System.in);
		System.out.print(p.getName());
		System.out.println(" has won with a hand of ");
		System.out.print("\t");
		System.out.println(p.viewHand());
		System.out.println("\n\tPress [Enter] key to continue\n");
		s.nextLine();
	}

	/**
	 * This is used to see if there are any players who drew a winning hand
	 * @return null if no player has drew a winning hand, else returns the player object that has won
	 */
	private Player winningPlayer() {

		Queue<Player> tempPlayers = new LinkedList<>();

		while (this.players.peek() != null) {

			Player currentPlayer = this.players.poll();
			tempPlayers.offer(currentPlayer);
			if (currentPlayer.intialHandWon()) {
				while (this.players.element() != null) {
					tempPlayers.offer(this.players.poll());
				}
				this.players = tempPlayers;
				return currentPlayer;

			}
		}
		this.players = tempPlayers;

		return null;
	}

}
