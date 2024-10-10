public class Program {
	public static void Main(string[] args) {}

	/*
	TASK 3 - Flip positions
	Below is a method that returns nothing and takes an integer 
	array as its parameter. The array always contains 2 integers.

	Within the body of the method, write code that swaps the position
	of the two integers in the array.
	*/

	public void FlipPositions(int[] arr) {
		//Write your solution between the dotted lines!
		//--------------------------------------------
		int hold = arr[0];
		arr[0] = arr[1];
    	arr[1] = hold;
		//--------------------------------------------
	}        
}