

public class Program {
  public static int Puzzle(int n) {
	  if(n>3){
		  help(n);
	  }
    return n;
  }
  public static int help(int n){
	  if(n <= 3){
		  return n;
	  }
	  else{
		  n = help(n-1) + help(n-2);
	  }
	  return n;
  }
}