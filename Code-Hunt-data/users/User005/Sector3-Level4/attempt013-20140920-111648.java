

public class Program {
  public static Boolean Puzzle(char c) {
	  if(c=='b'+21) return false;
	  int delta = 8;
	 for(int i  = 0; i<3; i++)
	  	  {
	  		  if(c=='b'+delta-i) return false;
	  	  }
	  	  return true;
  }
}