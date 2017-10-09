

public class Program {
  public static String Puzzle(int n) {
	  
	  return  toUnsignedString(n, 2); 
	
      
  }
  
  final static char[] digits = {
          '0' , '1' , '2' , '3' , '4' , '5' ,
          '6' , '7' , '8' , '9' , 'a' , 'b' ,
          'c' , 'd' , 'e' , 'f' , 'g' , 'h' ,
          'i' , 'j' , 'k' , 'l' , 'm' , 'n' ,
          'o' , 'p' , 'q' , 'r' , 's' , 't' ,
          'u' , 'v' , 'w' , 'x' , 'y' , 'z'
      };
  
  static String toUnsignedString(int num, int exp)
  {
     // Use an array large enough for a binary number.
    int mask = (1 << exp) - 1;
    char[] buffer = new char[32];
    int i = 32;
    do
      {
        buffer[--i] = digits[num & mask];
         num >>>= exp;
      }
     while (num != 0);
 
    // Package constructor avoids an array copy.
    return new String(buffer, i, 32 - i, true);
   }
}