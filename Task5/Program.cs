namespace Task5 {
	public class Program {
		public static void Main(string[] args) {}

		/*
		TASK 5 - Check even or throw
		Below is a function that returns a boolean and takes an 
		integer as its parameter.

		Within the body of the function, write code that checks
		wether the given number is even (use the IsEven() function).

		If the number is even, return true. If the number is
		odd, you should instead throw an exception.
		(Do not handle the exception yourself!)	
		*/

		public static bool CheckEvenOrThrow(int number) {
			//Write your solution between the dotted lines!
			//--------------------------------------------
			if (!IsEven(number))
				throw new Exception();
			return true;
			//--------------------------------------------
		}



		//This method checks if the number given as its parameter is even.
		//It returns a boolean (true if the number is even, false if the number is odd)
		static bool IsEven(int number) {
			return number % 2 == 0;
		}        
	}
}