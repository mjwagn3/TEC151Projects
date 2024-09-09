using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Michael Wagner
 * Date: 4/17/2024
 * ULID: MJWAGN3
 * Assignment 6.9 Rock paper scissors game
 * Description:
 * This is a simply rock paper scissors game
 */
namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {
        //varibles to check what choice the player has made and if they even made a choice
        bool playerSelectedScissors = false, playerSelectedPaper = false, playerSelectedRock = false,playerHasSelected = false;
        //will assign values to what each player has selected
        int computerChoice = 0,playerChoice = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        //when the program first loads the computer choice will be random generate between 1 to 3
        //1 is paper, 2 is rock, 3 is scissors
        private void Form1_Load(object sender, EventArgs e)
        {
            computerChoice = ComputerChoice();
        }
        //a random number is generated here
        private int ComputerChoice()
        {
            var rand = new Random();
            return rand.Next(3) + 1;
        }

        //player clicks on the different picture boxs to determine choose, if any have be clicked before the game is determine and after the made their choise they cant undo it
       //this is the rock choise
        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            if (!playerHasSelected)
            {
                playerHasSelected = true;
                playerSelectedRock = true;
                playerSelectedPaper = false;
                playerSelectedScissors = false;
                determinePlayerChoice();
            }
            else
            {
                MessageBox.Show("You have already made your choice and you will live with it!");
            }
        }
        //this is the paper choice
        private void paperPictureBox_Click(object sender, EventArgs e)
        {

            if (!playerHasSelected)
            {
                playerHasSelected = true;
                playerSelectedRock = false;
                playerSelectedPaper = true;
                playerSelectedScissors = false;
                determinePlayerChoice();

            }
            else
            {
                MessageBox.Show("You have already made your choice and you will live with it!");
            }
        }
        //this is the scissors choice
        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {

            if (!playerHasSelected)
            {
                playerHasSelected = true;
                playerSelectedRock = false;
                playerSelectedPaper = false;
                playerSelectedScissors = true;
                determinePlayerChoice();

            }
            else
            {
                MessageBox.Show("You have already made your choice and you will live with it!");
            }
        }
        //this is the button that will show outcome of game, if the player has not made a choice it will tell uuser to make choise else it will determine winner and make a new game
        private void shootButton_Click(object sender, EventArgs e)
        {
            if (!playerHasSelected)
            {
                MessageBox.Show("You must choose. But choose wisely!");
            }
            else
            {
                MessageBox.Show(determineWinner());
                newGame();

                
            }
        }
        //it will determine which choise the player has made and then comparing it to what the computer said it will then return a message indicating what was the outcome
        private void determinePlayerChoice()
        {
            if (playerSelectedPaper)
            {

                playerChoice = 1;
            }
            else if (playerSelectedRock)
            {
                playerChoice = 2;
            }else if (playerSelectedScissors)
            {
                playerChoice = 3;
            }
        }
        private String determineWinner()
        {
            String message = "";
            if(playerChoice == 1)
            {
                
                switch (computerChoice)
                {
                    case 1:
                        message = "You both have choosen paper and therefore tied!" + " The game must be played again to determine the winner!"; ;
                        break;
                    case 2:
                        message = "You choosen paper and oppenent has choosen rock. Paper wraps rock, YOU WIN!";
                        break;
                    case 3:
                        message = "You choosen paper and oppenent has choosen scissors. Scissors cuts paper, YOU LOSE!";
                        break;

                }
            }
            else if(playerChoice == 2)
            {
                switch (computerChoice)
                {
                    case 1: 
                        message ="You have chosen rock and oppenent has choosen paper. Paper wraps rock, YOU LOSE!";
                        break;
                    case 2:
                        message = "You both have choosen rock and therefore tied!"+" The game must be played again to determine the winner!";
                        break;
                    case 3:
                        message = "You choosen rock and oppenent has choosen scissors. Rock smashes scissors, YOU WIN!";
                        break;

                }
            }else if(playerChoice == 3)
            {
                switch (computerChoice)
                {
                    case 1:
                        message = "You have choosen scissors and oppenent has choosen paper. Scissors cuts paper, YOU WIN!";
                        break;
                    case 2:
                        message = "You have choose scissors and oppenent has choosen rock. Rock smashes scissors, YOU LOSE!";
                        break;
                    case 3:
                        message = "You have both chosen scissors and therefore tied!" + " The game must be played again to determine the winner!"; ;
                        break;
                }

            }
            return message;
        }
        //this creates a resets all important values so the player can play again
        public void newGame()
        {
            computerChoice = ComputerChoice();
            playerHasSelected = false;
            playerSelectedPaper = false;
            playerSelectedRock = false;
            playerSelectedScissors = false;
            playerChoice = 0;
        }
    }
}
