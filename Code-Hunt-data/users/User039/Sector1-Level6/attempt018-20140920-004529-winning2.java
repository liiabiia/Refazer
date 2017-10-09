
public class Program {
  public static int Puzzle(String s) {
    int count=0;
	String[] sa = s.split(" ");
	
	for (int i=0;i<sa.length;i++)
		if(!sa[i].equals(""))
			count++;
	return count;
  }
}