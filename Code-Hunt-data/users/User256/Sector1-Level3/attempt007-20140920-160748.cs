using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
   int  num1 = 0, num2 = 0;
   if(x)
   num1++;
   else
   num2++;
   
   if(y)
   num1++;
   else
   num2++;
   if(z)
   num1++;
   else
   num2++;
    
	if(num1 > num2) return true;
	else
	return false;
  }
}