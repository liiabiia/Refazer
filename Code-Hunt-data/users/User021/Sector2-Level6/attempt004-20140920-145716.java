

public class Program {
  public static String Puzzle(int n) {
	  StringBuffer sBuf = new StringBuffer();
    int temp=0;
    while(n>0){
        temp = n%2;
        sBuf.append(temp);
        n = n / 2;
    }
	return sBuf.reverse().toString();
  }
}