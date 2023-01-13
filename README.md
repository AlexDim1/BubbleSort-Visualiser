# BubbleSort-Visualiser
Course task for the Synthesis and Analysis of Algorithms course (3rd semester).

## Goal
Learn the most important sorting algorithms by making a visualisation showing how they work. 
I chose to implement the Bubble Sort algorithm.

## Technologies used
- Windows Forms

## Functionality
- Select order - selects the order in which the array will be sorted (Ascending/Descending);
- Generate Array button - generates an `int[]` with 8 random values between 0 and 100, then sorts it according to the chosen order using an implementation of a Bubble sort algorithm (the unsorted array is shown on the GUI!) and records the steps it made in a Queue
- Next Step button - takes the next step from the Queue and displays it on the GUI. Press this button until all steps are shown to get to the sorted array
- The program also shows the number of comparisons and swaps made
