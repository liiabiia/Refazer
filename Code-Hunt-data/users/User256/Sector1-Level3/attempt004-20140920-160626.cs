using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
   int  num1 = 0, num2 = 0;
   x?num++:num2++;
   y?num++:num2++;
   z?num++:num2++;
    
	if(num1 > num2) return true;
	else
	return false;
  }
}