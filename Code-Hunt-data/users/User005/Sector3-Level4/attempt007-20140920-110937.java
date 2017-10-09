

public class Program {
  public static Boolean Puzzle(char c) {
	  int delta = 8;
	 for(int i  = 0; i<255 ; i++)
	  	  {
	  		  if(c=='b'+delta-i) return false;
	  	  }
	  	  return true;
  }
}