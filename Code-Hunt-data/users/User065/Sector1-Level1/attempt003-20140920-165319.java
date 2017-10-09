

public class Program {
  public static int Puzzle(int x) {
	  int w = 0;
	  if (x == 0){
		  w = 42;
	  }else{
		  if (x == 42){
			  w = 0;
		  }else{
			  w = -8;
		  }
	  }
    return w;
  }
}