

public class Program {
  public static int Puzzle(String s) {
	String c[]= s.split(" ");
	int count=c.length;
	fot (int i=0;i<c.length;i++){
		if (c[i]=="")
		  count--;
	}
	return count;
  }
}