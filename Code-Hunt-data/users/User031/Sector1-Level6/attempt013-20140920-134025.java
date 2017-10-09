
public class Program {
  public static int Puzzle(String s) {
    int counter =0;
   	for (int i=0;i<s.length();i++)
  	 {
       	if (s.charAt(i).equals(" ")) counter++;
  	 }

	return counter;
  }
}