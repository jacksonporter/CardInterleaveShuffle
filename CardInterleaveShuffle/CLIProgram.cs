/*
 Simple: 52 playing cards interleave shuffle -

Generate a deck of 52 unique playing cards in random order.  -

Do an interleave shuffle. 

ie: split the cards into 2 decks, and interleave them. 

- Draw a 2nd top card, and draw a second bottom card. 
Print these cards on the screen. 

An example deck of 6 cards:  

Input deck: 6 4 2 5 3 1 
Cut into 2 decks: 6 4 2 | 5 3 1 
Interleave them:   6   6 5   6 5 4   6 5 4 3   6 5 4 3 2   6 5 4 3 2 1 

Deck generated from the shuffle function: 6 5 4 3 2 1 
Print out "Top+1 = 5, Bottom-1 = 2" */

using System;
using System.Collections.Generic;

namespace CardInterleaveShuffle
{
    /// <summary>
    /// Contains the 52 interleave card shuffle program described in the README.
    /// </summary>
    class CLIProgram
    {
        const int listSize = 52;

        static void Main(string[] args)
        {
            Console.WriteLine("52 Playing Card Interleave Shuffle:");
            Console.WriteLine("\nGame Rules:\n\t* Generate a deck of 52 unique " +
                "playing cards in random order.\n\t* Do an interleave shuffle." +
                "\n\t(ie: split the cards into 2 decks, and interleave them.)" +
                "\n\n\t* Draw a 2nd top card, and draw a second bottom card." +
                "\n\t* Print these cards on the screen." +
                "\n\nAn example deck of 6 cards:" +
                "\n\tInput deck: 6 4 2 5 3 1" +
                "\n\tCut into 2 decks: 6 4 2 | 5 3 1" +
                "\n\tInterleave them:   6   6 5   6 5 4   6 5 4 3   6 5 4 3 2  " +
                " 6 5 4 3 2 1" +
                "\n\tDeck generated from the shuffle function: 6 5 4 3 2 1" +
                "\n\tPrint out \"Top+1 = 5, Bottom-1 = 2" +
                "\n\n*** For this example I will just print the top and bottom " +
                "cards instead of the 2nd and 2nd to last card. ***\n\n");

            /* Create a list of 52 cards with no value.*/ 
            var cards = new List<int>();

            for(int i = 0; i < listSize; i++)
            {
                cards.Add(0);
            }

            /* Assign number of cards from 1 to the size of list, in random order. */
            for (int i = 1; i < cards.Count; i++)
            {
                Random rand = new Random();
                int location;

                do{ 
                    location = rand.Next(cards.Count);
                } while (cards[location] > 0);

                cards[location] = i;
            }

            /* Print the list of cards. */
            Console.WriteLine("\nList of randomly generated cards:");
            printDeck(cards);

            /* Create two seperate lists, as we are 'cutting' the deck. */
            var list1 = new List<int>();
            var list2 = new List<int>();

            /* Move contents from left half of the orginal list into list1. */
            for(int i = 0; i < (listSize / 2); i++)
            {
                list1.Add(cards[0]);
                cards.RemoveAt(0);
            }
            /* Move contents from right half of the orginal list into list2. */
            for (int i = 0; i < (listSize / 2); i++)
            {
                list2.Add(cards[0]);
                cards.RemoveAt(0);
            }

            /* Add cards back into the orginal list, but interleaved. */
            for (int i = 0; i < (52 / 2); i++)
            {
                cards.Add(list1[i]);
                cards.Add(list2[i]);
            }

            /* Print the first card in the deck. */
            Console.WriteLine("\nFirst Card:" + cards[0]);

            /* Print the last card in the deck. */
            Console.WriteLine("\nLast Card:" + cards[cards.Count- 1]);

            /* Print the entire interleaved deck */
            Console.WriteLine("\nList of interleaved cards:");
            printDeck(cards);
        }

        public static void printDeck(List<int> cards)
        {
            foreach (int card in cards)
            {
                Console.Write(card + " ");
            }
            Console.WriteLine();
        }
    }
}
