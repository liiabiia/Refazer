

public class Program {
  public static Boolean Puzzle(char c) {
	 for(int i  = 0; i<255 ; i++)
	  	  {
	  		  if(c=='b'+i*8) return false;
	  	  }
	  	  return true;
  }
}