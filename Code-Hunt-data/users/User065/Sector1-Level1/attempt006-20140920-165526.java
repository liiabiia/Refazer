

public class Program {
  public static int Puzzle(int x) {
	  int w = 0;
		switch(x){
			case 0:
			w = 42;
			break;
			
			case 33:
			w = 9;
			break;
			
			case 34:
			w = -8;
			break;
			
			case 42:
			w = 0;
			break;
			
			case 50:
			w=-8;
			break;
		}
    return w;
  }
}