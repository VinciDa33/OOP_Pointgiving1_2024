public class Program {
	public static void Main(string[] args) {}

	/*
	TASK 6 - PingPong
	Below is a method that returns a string and takes a
	string as its parameter.

	Within the body of the method, write code that checks 
	and does the following.

	1. If the string variable 'str' contains the value  "PingPong" you should return "PongPing".
	2. If the string variable 'str' contains the value  "Ping" you should return "Pong".
	3. If the string variable 'str' contains the value  "Pong" you should return "Ping".
	4. In all other cases you should return "Check"
	*/

	public string PingPong(string str) {
		//Write your solution between the dotted lines!
		//--------------------------------------------
		if (str == "PingPong")
			return "PongPing";
		if (str == "Ping")
			return "Pong";
		if (str == "Pong")
			return "Ping";
		return "Check";
		//--------------------------------------------
	}        
}