namespace Task1 {
	public class Program {
		public static void Main(string[] args) {}

		/*
		TASK 1 - Sum of array
		Below is a function that returns an integer and takes an integer 
		array as its parameter.

		Within the body of the function, write code that sums up all the
		values in the array and returns that sum. (i.e. add all the integers
		together and return the result).
		*/

		public static int SumOfArray(int[] arr) {
			//Write your solution between the dotted lines!
			//--------------------------------------------
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
				sum += arr[i];
			return sum;
			//--------------------------------------------
		}        
	}
}