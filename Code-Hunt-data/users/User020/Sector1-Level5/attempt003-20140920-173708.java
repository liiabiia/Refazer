

public class Program {
    public static int Puzzle(int[] a) {
      for(int x : a){
		  if(x == 1) return true;
	  }
	  return false;
    }
}