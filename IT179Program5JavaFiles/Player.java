package isu.edu;

import java.util.Stack;

public class Player {
	/**
	 * This is the Player class, has an array of card types used to help me not copy
	 * paste,
	 * 
	 * each card is a string, with the first 3 chars represent the number ACE to 010
	 * and the last char represent the type
	 * 
	 * has an array of Strings, representing the cards in hand
	 * 
	 * has a name
	 * 
	 * has varible that keeps track of the type
	 * 
	 * a constant varible that keeps track of size of each hand
	 * 
	 * @author Michael Wagner
	 */
	public final char[] TYPES = { '♥', '♦', '♣', '♠' };
	private String[] cardsInHand;
	private String name;
	private char typeToTrack;
	private final int NUMBER_CARDS_IN_HAND = 4;

	/**
	 * Player constructor that takes a name, and the first 4 intial cards, sets the
	 * name and sets the cards in hand array with the 5th spot representing the card
	 * that was drawn, since this is setting a new player, we have the 5th spot null
	 * 
	 * @param name
	 * @param card1
	 * @param card2
	 * @param card3
	 * @param card4
	 */
	public Player(String name, String card1, String card2, String card3, String card4) {
		this.name = name;
		this.cardsInHand = new String[5];
		this.cardsInHand[0] = card1;
		this.cardsInHand[1] = card2;
		this.cardsInHand[2] = card3;
		this.cardsInHand[3] = card4;
		this.typeToTrack = this.setTypeFromIntitalHand();

	}

	/**
	 * This gets the name
	 * 
	 * @return name of player
	 */
	public String getName() {
		return this.name;
	}

	/**
	 * This views the hand
	 */
	public String viewHand() {
		StringBuilder sb = new StringBuilder();
		sb.append(this.name);
		sb.append("\'s Hand:\n\t[\"");
		for (int i = 0; i < this.NUMBER_CARDS_IN_HAND - 1; i++) {
			sb.append(this.cardsInHand[i]);
			sb.append("\", \"");
		}

		sb.append(this.cardsInHand[this.NUMBER_CARDS_IN_HAND - 1]);
		sb.append("\"]");
		return sb.toString();

	}

	/**
	 * Gets the value of a card
	 * 
	 * @param card
	 * @return value of a card
	 */
	private int getValueOfCard(String card) {
		if (card != null) {
			String valueStr = card.substring(0, 3);
			if (valueStr.equals("ACE")) {
				return 1;
			}
			return Integer.parseInt(valueStr);
		}
		return 0;

	}

	/**
	 * figures out the type it will track for the winning combo based on inital
	 * hand. At times the majority type appear 2, or sometimes ties at 2
	 * appearances, to avoid dealing with a tie, say 2 is always the majoirty
	 * 
	 * @return
	 */
	private char setTypeFromIntitalHand() {
		int totalHearts = 0, totalDiamonds = 0, totalSpades = 0, totalClubs = 0;
		for (int i = 0; i < 4; i++) {
			char type = this.getTypeOfCard(this.cardsInHand[i]);
			if (type == this.TYPES[0])
				totalHearts++;
			else if (type == this.TYPES[1])
				totalDiamonds++;
			else if (type == this.TYPES[2])
				totalClubs++;
			else if (type == this.TYPES[3])
				totalSpades++;
		}

		if (totalHearts >= 2)
			return this.TYPES[0];
		else if (totalDiamonds >= 2)
			return this.TYPES[1];
		else if (totalClubs >= 2)
			return this.TYPES[2];
		else if (totalSpades >= 2)
			return this.TYPES[3];
		return ' ';
	}

	/**
	 * Figures out the type of card
	 * 
	 * @param card
	 * @return card type
	 */
	private char getTypeOfCard(String card) {
		if (card != null)
			return card.charAt(card.length() - 1);
		return ' ';
	}

	/**
	 * Determines the what 4 of kind a player has in their hand
	 * 
	 * @param cardsInHand
	 * @return a type that is 4 of a kind else returns ' '
	 */
	private char determine4Type(String[] cardsInHand) {
		int totalHearts = 0, totalDiamonds = 0, totalSpades = 0, totalClubs = 0;
		for (int i = 0; i < 4; i++) {
			char type = this.getTypeOfCard(cardsInHand[i]);
			if (type == this.TYPES[0])
				totalHearts++;
			else if (type == this.TYPES[1])
				totalDiamonds++;
			else if (type == this.TYPES[2])
				totalClubs++;
			else if (type == this.TYPES[3])
				totalSpades++;
		}

		if (totalHearts == 4)
			return this.TYPES[0];
		else if (totalDiamonds == 4)
			return this.TYPES[1];
		else if (totalClubs == 4)
			return this.TYPES[2];
		else if (totalSpades == 4)
			return this.TYPES[3];
		return ' ';

	}

	/**
	 * calculates the total value of the hand,
	 * 
	 * @param cardsInHand
	 * @return true if the total value equals 23 else returns false
	 */
	private boolean has23(String[] cardsInHand) {
		int total = 0;
		for (int i = 0; i < 4; i++) {
			total += this.getValueOfCard(cardsInHand[i]);

		}
		return total == 23;
	}

	/**
	 * Looks at hand and if the player doesn't have 4 of a kind and hand doesn't
	 * equal 23, if the face up cards is not empty, looks at the face up card and
	 * sees if it will win
	 * 
	 * @param faceUpCards
	 * @return true if the top face up card is a winning card
	 */
	private boolean drawFromFloorOrStack(Stack<String> faceUpCards) {

		if (this.determine4Type(this.cardsInHand) == ' ' && !this.has23(this.cardsInHand)) {
			if (!faceUpCards.empty()) {
				String card = faceUpCards.peek();
				String[][] combos = this.combos(card);
				for (int i = 0; i < combos.length; i++) {
					if (this.winningHand(combos[i]))
						return true;

				}

			}
		}
		return false;
	}

	/**
	 * 2d array thats every possible winning had with the combo with the card
	 * 
	 * @param card
	 * @return 2d array of the possible combos with the new card and see if
	 *         dispossing a card will make it winn
	 */
	private String[][] combos(String card) {
		String[][] combo = { { this.cardsInHand[0], this.cardsInHand[1], this.cardsInHand[2], card },
				{ this.cardsInHand[0], this.cardsInHand[1], card, this.cardsInHand[3] },
				{ this.cardsInHand[0], card, this.cardsInHand[2], this.cardsInHand[3] },
				{ card, this.cardsInHand[1], this.cardsInHand[2], this.cardsInHand[3] } };
		return combo;
	}

	/**
	 * sees if the cards in hand is a winning hand
	 * 
	 * @param cardsInHand
	 * @return true if has 23 and has 4 of type
	 */
	private boolean winningHand(String[] cardsInHand) {
		return (this.has23(cardsInHand) && this.determine4Type(cardsInHand) != ' ');
	}

	/**
	 * Draws a card from either the face down cards or face up cards
	 * 
	 * @param faceDownCards
	 * @param faceUpCards
	 * @return true representing the player has won else returns false
	 */

	private boolean draw(Stack<String> faceDownCards, Stack<String> faceUpCards) {
		boolean drawFromFloor = this.drawFromFloorOrStack(faceUpCards);
		if (this.determine4Type(this.cardsInHand) == ' ' && !this.has23(this.cardsInHand)) {
			if (!drawFromFloor) {
				this.cardsInHand[4] = faceDownCards.pop();
				return false;
			} else {
				this.cardsInHand[4] = faceUpCards.pop();
			}
		}
		return true;

	}

	/**
	 * Draws from the face down or face up cards, determines which card to throw,
	 * 
	 * @param faceDownCards
	 * @param faceUpCards
	 * @return true if won else, throws a card it drew from face down cards
	 */
	public boolean throwCard(Stack<String> faceDownCards, Stack<String> faceUpCards) {
		boolean won = draw(faceDownCards, faceUpCards);
		if (!won) {
			int i;
			int j = 0;

			Stack<String> newHand = new Stack<>();
			Stack<String> notHand = new Stack<>();
			for (i = 0; i < this.cardsInHand.length; i++) {
				String card = this.cardsInHand[i];
				if (this.getTypeOfCard(card) == this.typeToTrack) {
					newHand.push(card);
					j++;
				} else {
					notHand.push(card);

				}
			}
			String[] order = new String[this.cardsInHand.length - j];
			i = 0;
			while (i < order.length && !notHand.empty()) {
				order[i] = notHand.pop();
				i++;

			}
			for (i = 0; i < order.length; i++) {
				for (j = i + 1; j < order.length; j++) {
					String card = null;
					if (this.getValueOfCard(order[i]) > this.getValueOfCard(order[j])) {
						card = order[i];
						order[i] = order[j];
						order[j] = card;
					}
				}
			}
			for (i = 0; i < order.length - 1; i++) {
				newHand.push(order[i]);
			}
			String cardToThrow = order[order.length - 1];
			faceUpCards.push(cardToThrow);
			for (i = 0; i < this.NUMBER_CARDS_IN_HAND && !newHand.empty(); i++) {
				this.cardsInHand[i] = newHand.pop();
			}
			this.cardsInHand[this.cardsInHand.length - 1] = null;
			return false;

		}
		this.cardsInHand[this.cardsInHand.length - 1] = null;
		return true;
	}

	/**
	 * gets if the intital hand is a winning hand 
	 * @return true if inital hand is a winning hand
	 */
	public boolean intialHandWon() {
		return this.winningHand(this.cardsInHand);

	}

}
