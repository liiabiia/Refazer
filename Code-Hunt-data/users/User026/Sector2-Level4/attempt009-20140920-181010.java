

public class Program {
  public static int Puzzle(int a, int b) {
	int c = Math.max(a,b);
	while(true){
		if(c%a==0 && c%b==0)break;
		c++;
	}
    return c;
  }
}