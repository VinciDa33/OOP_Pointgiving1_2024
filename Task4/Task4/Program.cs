using System;
namespace Task4{
public class Program{

    /*
    Write a function MultipliedNumber this method should take in a parameter
    the parameter needs to be an int. The function should also return an int.
    The paramter int should be multiplied by 2 and returned.
    */

    //Write your solution between the dotted lines!
			//--------------------------------------------
    public static int ForLoop(int n){
        for(int i = 0; i < n; i++){
            return n;
        }
    }
   
			//--------------------------------------------

    public static void Main(string[] args){
        Console.WriteLine(Program.ForLoop(10));

    }

    }
}