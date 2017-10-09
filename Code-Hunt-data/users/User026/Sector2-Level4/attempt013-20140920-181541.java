

public class Program {
  public static int Puzzle(int a, int b) {
	int c = a*b, aux = c, resp = 0;
	while(c>=aux){
		if(c%a==0 && c%b==0)resp = c;
		c--;
	}
    return resp;
  }
}