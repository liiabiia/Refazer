

public class Program {
  public static String Puzzle(int n) {
    String output = "";
	int q,r;
        do{
            q=n/2;
            r=n%2;
            n=q;         
            output+=r;                       
        }while (q!=0);
		return output;
  }
}