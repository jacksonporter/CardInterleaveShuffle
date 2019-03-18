# CardInterleaveShuffle
### This repository contains code for a simpele 52 card interleave shuffle.
#### Code is written in C#. Explaination below:

Rules:

- Generate a deck of 52 unique playing cards in random order.  -s
- Do an interleave shuffle. 
(ie: split the cards into 2 decks, and interleave them.)
- Draw a 2nd top card, and draw a second bottom card. 
- Print these cards on the screen. 

An example deck of 6 cards:  

- Input deck: 6 4 2 5 3 1 
- Cut into 2 decks: 6 4 2 | 5 3 1 
- Interleave them:   6   6 5   6 5 4   6 5 4 3   6 5 4 3 2   6 5 4 3 2 1 
- Deck generated from the shuffle function: 6 5 4 3 2 1 
- Print out "Top+1 = 5, Bottom-1 = 2" */
