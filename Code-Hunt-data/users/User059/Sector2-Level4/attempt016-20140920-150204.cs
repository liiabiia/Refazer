using System;

public class Program {
  public static int Puzzle(int a, int b) {
	 /// if(a==b) return a;
	  //else if (a%b==0 || b%a==0)
	///  {
	//	  if(a<b) return b;
	//	  else return a;
	//  }
	//  else if(a%2==0 && b%2==0) return (a*b)/2;
	int num1, num2, lcm=0;
        if (a > b)
        {
            num1 = a; num2 = b;
        }
        else
        {
            num1 = b; num2 = a;
        }

        for (int i = 1; i <= num2; i++)
        {
            if ((num1 * i) % num2 == 0)
            {
                lcm = i * num1;
            }
        }
        lcm= num2;
    

	if(lcm!=0) return lcm;
	
	  else     return a*b;
  }
}