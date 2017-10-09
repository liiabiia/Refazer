

public class Program {
  public static Boolean Puzzle(char c) {
	  
	  return c & ' ' == 0;
	  
	  //98
	 if (c == 'b') return false;
	 
	  //104
	  if (c == 'h') return false;
	 //106
	  if (c == 'j') return false;
	 
	  //j + 7
	  //113
	  if (c == 'q') return false;
	  //115
	  if (c == 's') return false;
	  //119
	  if (c == 'w') return false;
	  
	  //120
	  
	return true;
  }
}