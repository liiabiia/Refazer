

public class Program {
  public static Boolean Puzzle(int x, int y) {
    for(int i=2;i<y;i++){
		  if(y%i==0)
		  	return false;
	  }
	  return true;
  }
}
