

public class Program {
  public static int Puzzle(int a, int b) {
	int c = Math.max(a,b);
	while(true){
		if(a%c==0 && b%c==0)break;
		c++;
	}
    return c;
  }
}