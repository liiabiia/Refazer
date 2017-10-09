
public class Program {
  public static int Puzzle(String s) {
    int count=0;
	for (int i=1;i<s.length();i++){
	if(count!=0 && s.charAt(i).equals(" ") && !s.charAt(i-1).equals(" "))
		count++;
	
	if(count==0 && s.charAt(i).equals(" ") && !s.charAt(i-1).equals(" "))
		count+=2;
		
		}
	return count;
  }
}