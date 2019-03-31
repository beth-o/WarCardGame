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
            ShuffleDeck(deck);
        }
        public static void FillDeck(int[] deck) {
            for (int i = 0; i < deck.Length; ++i) {
                deck[i] = i + 1;
                //display original deck
                WriteLine("Original Deck");
                Write(deck[i] + " ");
            }

        }
        public static void ShuffleDeck(int[] deck) {
            var tempArr = new List<int>();
            int temp;
            Random ran = new Random();

            for (int i = 0; i < deck.Length; i++) {
                int ranInt = ran.Next(1, 52);
                //if the random int is already at the current 
                //deck index or the tempArr already has the ranInt
                //value generate another random number
                while (ranInt == deck[i] || tempArr.Contains(ranInt)) {
                    ranInt = ran.Next(1, 52);
                }
                //copy the random int to the tempArr
                tempArr.Add(ranInt);
                //copy the value being swapped to tempArr
                tempArr.Add(deck[i]);
                //the subscript of the deck is swapped
                //with the random int
                temp = deck[i];
                deck[i] = ranInt;
                deck[ranInt-1] = temp;
            }
            //display the shuffled deck
            WriteLine("\nHere is the shuffled deck.");
            foreach (int count in deck) {
                WriteLine(count);
            }
        }

    }
}

    

