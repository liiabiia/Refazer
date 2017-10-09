using System;

public class Program {
  public static int Puzzle(int a, int b) {
	 int num1, num2;
        if (a > b)
		 {
			 num1 = a; 
			 num2 = b;
			 }
         else
		 { 
			 num1 = b; 
			 num2 = a;
			 }
        for (int i = 1; i <= num2; i++)
        {
			if ((num1 * i) % num2 == 0)return i * num1;
        }
        return num2;
  }
}
