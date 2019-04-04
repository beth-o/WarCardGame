using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame {
    class Program {
        static void Main(string[] args) {
            int[] deck = new int[52];

            FillDeck(deck);
            int[] player1 = new int[26];
            int[] player2 = new int[26];
            ShuffleDeck(deck);
            DealToPlayers(deck, player1, player2);
            for (int i = 0; i < 26; i++) {
                string card = IdentifyCard(player1, i);
            }
            WriteLine("Shuffled Deck");
            for (int i = 0; i<deck.Length; i++) {
                Write(deck[i] + " ");
                if (i > 0 && i % 4 ==0) {
                    WriteLine("");
                }                
            }

            WriteLine("\nCheck it: ");
            Array.Sort(deck);
            //Display sorted deck in 
            foreach(int i in deck){
                Write(i + " ");
                if (i % 13 == 0) {
                    WriteLine("");
                }
                
            }
            Read();
        }

        ///////////////////////////////////////////////////////////
        public static string IdentifyCard(int[] hand, int i) {
            string card;
            if (hand[i] == 1 || hand[i] == 13 || hand[i] == 29 || hand[i] == 39) {
                card = "Ace"; 
            }
            return card;
        }

        /// <FillDeck>///////////////////////////////////////////////////
        /// This Method fills the deck with sequential numbers
        /// </FillDeck>
        /// <param name="deck"></param>
        public static void FillDeck(int[] deck) {
            for (int i = 0; i < deck.Length; ++i) {
                deck[i] = i + 1;
            }
        }
/// <DealToPlayers>
/// //////Deals alternately to player one and two the shuffled deck
/// </DealToPlayers>
/// <param name="deck"></param>
/// <param name="player1"></param>
/// <param name="player2"></param>
    public static void DealToPlayers(int[] deck, int[] player1, int[] player2) {
            int j = 0;
            int k = 0;
            for (int i = 0; i < deck.Length; i++) {                
                if (i % 2 == 0) {
                    player1[j] = deck[i];
                    j++;
                }
                else {
                    player2[k] = deck[i];
                    k++;
                }
            }

    }
/// <ShuffleDeck>///////////////////////////////////////////////
/// This method Shuffles the Numbers
/// </ShuffleDeck>
/// <param name="deck"></param>
        public static void ShuffleDeck(int[] deck) {

            var tempList = new List<int>();            
            Random ran = new Random();
           
            for (int i = deck.Length-1; i > 0; i--) { 
                int ranInt = ran.Next(0, deck[i]-1);
                //the value of the current index is swapped
                //with the random int
 
                int temp = deck[i];
                deck[i] = deck[ranInt];
                deck[ranInt] = temp;

            }
        }           
    }
}


    

