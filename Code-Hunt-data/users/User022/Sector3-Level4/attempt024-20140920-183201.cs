using System;

public class Program {
  public static bool Puzzle(char c) {
    if( c== 'a'  
	|| c == 'g'   
	|| c == 'p' 
	|| c == ' ' 
	) return true;
	return false;
  }
}