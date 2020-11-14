using System;

using AppKit;
using Foundation;

namespace GUITicTacToe {
    public partial class ViewController : NSViewController {
        public ViewController(IntPtr handle) : base(handle) {
        }

        /* Layout is like: (Image Buttons)
         * 
         *      1 2 3    ||  [0, 0], [0, 1], [0, 2]
         *      4 5 6    ||  [1, 0], [1, 1], [1, 2]
         *      7 8 9    ||  [2, 0], [2, 1], [2, 2]
         */

        String[,] playerboardValues = new String[3, 3] {
            {null, null, null},
            {null, null, null},
            {null, null, null}
        };
        bool[,] valuesUsed = new bool[3, 3] {
            {false, false, false},
            {false, false, false},
            {false, false, false}
        };
        int turncount = 0, gamesPlayed = 0, player1Wins = 0, player2Wins = 0, ties = 0, totalgames = 0;
        double p1score, p2score;
        string player = "X";
        bool Player1Turn = true, roundover = false;

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            PlayerTurnText.StringValue = "X";
            MessageOfWinnerText.StringValue = "";
        }

        public void updateScore() {
            if (gamesPlayed == 0) {
                PlayerXLabel.StringValue = "";
                PlayerOLabel.StringValue = "";
            } else {
                p1score = (double)player1Wins / (double)gamesPlayed;
                p2score = (double)player2Wins / (double)gamesPlayed;

                PlayerXLabel.StringValue = "X winning: " + p1score.ToString("F2");
                PlayerOLabel.StringValue = "O winning: " + p2score.ToString("F2");
            }
        }

        // Calls and checks to see if it is X's or O's turn to pick a selection
        public void playerTurn() { //TODO UPDATE TEXTVIEW IN SYNC TO SHOW WHOs turn it currently is
            if (Player1Turn == true && MessageOfWinnerText.StringValue == "") {
                player = "X";
                PlayerTurnText.StringValue = "O";
                Player1Turn = false;
            }
            else if(Player1Turn == false && MessageOfWinnerText.StringValue == "") {
                player = "O";
                PlayerTurnText.StringValue = "X";
                Player1Turn = true;
            }
        }

        // Image Buttons Methods which all follow the same logic but just the values in my 2d arrays so I can determine a winner
        partial void ImageButton1Click(Foundation.NSObject sender) {

            playerTurn();

            if(valuesUsed[0,0] == false) {
                playerboardValues[0, 0] = player;
                valuesUsed[0, 0] = true;

                if(player == "X")
                    ImageButton1.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton1.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton2Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[0, 1] == false) {
                playerboardValues[0, 1] = player;
                valuesUsed[0, 1] = true;

                if (player == "X")
                    ImageButton2.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton2.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton3Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[0, 2] == false) {
                playerboardValues[0, 2] = player;
                valuesUsed[0, 2] = true;

                if (player == "X")
                    ImageButton3.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton3.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton4Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[1, 0] == false) {
                playerboardValues[1, 0] = player;
                valuesUsed[1, 0] = true;

                if (player == "X")
                    ImageButton4.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton4.Image = NSImage.ImageNamed("cat");

                turncount++;
            }
            
            CheckWinCondition();
        }
        partial void ImageButton5Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[1, 1] == false) {
                playerboardValues[1, 1] = player;
                valuesUsed[1, 1] = true;

                if (player == "X")
                    ImageButton5.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton5.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton6Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[1, 2] == false) {
                playerboardValues[1, 2] = player;
                valuesUsed[1, 2] = true;

                if (player == "X")
                    ImageButton6.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton6.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton7Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[2, 0] == false) {
                playerboardValues[2, 0] = player;
                valuesUsed[2, 0] = true;

                if (player == "X")
                    ImageButton7.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton7.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton8Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[2, 1] == false) {
                playerboardValues[2, 1] = player;
                valuesUsed[2, 1] = true;

                if (player == "X")
                    ImageButton8.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton8.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }
        partial void ImageButton9Click(Foundation.NSObject sender) {

            playerTurn();

            if (valuesUsed[2, 2] == false) {
                playerboardValues[2, 2] = player;
                valuesUsed[2, 2] = true;

                if (player == "X")
                    ImageButton9.Image = NSImage.ImageNamed("acu");
                else
                    ImageButton9.Image = NSImage.ImageNamed("cat");

                turncount++;
            }

            CheckWinCondition();
        }

        // Win Condition Method (Checks Vertical, Horizontal, and Diagonal Lines to see if they are all the same which indicates a win)
        void CheckWinCondition() {

            // Checks Vertical Lines for X
            if(playerboardValues[0, 0] == "X" && playerboardValues[1, 0] == "X" && playerboardValues[2, 0] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            else if (playerboardValues[0, 1] == "X" && playerboardValues[1, 1] == "X" && playerboardValues[2, 1] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            else if (playerboardValues[0, 2] == "X" && playerboardValues[1, 2] == "X" && playerboardValues[2, 2] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            // Checking the Horizontal Lines for X
            else if (playerboardValues[0, 0] == "X" && playerboardValues[0, 1] == "X" && playerboardValues[0, 2] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            else if (playerboardValues[1, 0] == "X" && playerboardValues[1, 1] == "X" && playerboardValues[1, 2] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            else if (playerboardValues[2, 0] == "X" && playerboardValues[2, 1] == "X" && playerboardValues[2, 2] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            // Checking the Diagonal Lines for X
            else if (playerboardValues[0, 0] == "X" && playerboardValues[1, 1] == "X" && playerboardValues[2, 2] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }
            else if (playerboardValues[2, 0] == "X" && playerboardValues[1, 1] == "X" && playerboardValues[0, 2] == "X") {
                player1Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "X wins!";
            }

            // Checks Vertical Lines for O
            if (playerboardValues[0, 0] == "O" && playerboardValues[1, 0] == "O" && playerboardValues[2, 0] == "O") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            } else if (playerboardValues[0, 1] == "O" && playerboardValues[1, 1] == "O" && playerboardValues[2, 1] == "O") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            } else if (playerboardValues[0, 2] == "O" && playerboardValues[1, 2] == "O" && playerboardValues[2, 2] == "O") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            }
              // Checking the Horizontal Lines for X
              else if (playerboardValues[0, 0] == "O" && playerboardValues[0, 1] == "O" && playerboardValues[0, 2] == "O") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            } else if (playerboardValues[1, 0] == "O" && playerboardValues[1, 1] == "O" && playerboardValues[1, 2] == "O") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            } else if (playerboardValues[2, 0] == "O" && playerboardValues[2, 1] == "O" && playerboardValues[2, 2] == "O") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            }
              // Checking the Diagonal Lines for X
              else if (playerboardValues[0, 0] == "O" && playerboardValues[1, 1] == "O" && playerboardValues[2, 2] == "0") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            } else if (playerboardValues[2, 0] == "O" && playerboardValues[1, 1] == "O" && playerboardValues[0, 2] == "0") {
                player2Wins++;
                roundover = true;
                MessageOfWinnerText.StringValue = "O wins!";
            }

            if (turncount == 9 && (MessageOfWinnerText.StringValue != "X wins" && MessageOfWinnerText.StringValue != "O wins!")) {
                ties++;
                roundover = true;
                MessageOfWinnerText.StringValue = "Tie game!";
            }

            if (roundover == true) {
                gamesPlayed++;
                updateScore();
                roundover = false;
            }
        }

        partial void PlayAgainButtonClick(Foundation.NSObject sender) {

            ImageButton1.Image = null;
            ImageButton2.Image = null;
            ImageButton3.Image = null;
            ImageButton4.Image = null;
            ImageButton5.Image = null;
            ImageButton6.Image = null;
            ImageButton7.Image = null;
            ImageButton8.Image = null;
            ImageButton9.Image = null;

            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    valuesUsed[i, j] = false;
                    playerboardValues[i, j] = null;
                }
            }

            MessageOfWinnerText.StringValue = "";
            PlayerTurnText.StringValue = "X";
            turncount = 0;
            Player1Turn = true;
            ViewDidLoad();
        }

        // Button which RESETS EVERTHING back to its initial state
        partial void ResetButtonClick(Foundation.NSObject sender) {
            ImageButton1.Image = null;
            ImageButton2.Image = null;
            ImageButton3.Image = null;
            ImageButton4.Image = null;
            ImageButton5.Image = null;
            ImageButton6.Image = null;
            ImageButton7.Image = null;
            ImageButton8.Image = null;
            ImageButton9.Image = null;
            turncount = 0;
            player1Wins = 0;
            player2Wins = 0;
            p1score = 0;
            p2score = 0;
            gamesPlayed = 0;
            MessageOfWinnerText.StringValue = "";
            PlayerTurnText.StringValue = "";
            Player1Turn = true;
            PlayerXLabel.StringValue = "";
            PlayerOLabel.StringValue = "";

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    valuesUsed[i, j] = false;
                    playerboardValues[i, j] = null;
                }
            }
        }

        public override NSObject RepresentedObject {
            get {
                return base.RepresentedObject;
            }
            set {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
