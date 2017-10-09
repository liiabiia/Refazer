
public class Program {
  public static int Puzzle(String s) {
    int count=0;
	for (int i=1;i<s.length();i++){
		if(count==0 &&!s.charAt(i).equals(" "))
		count++;
	if(s.charAt(i).equals(" ") && !s.charAt(i-1).equals(" "))
		count++;}
	return count;
  }
}