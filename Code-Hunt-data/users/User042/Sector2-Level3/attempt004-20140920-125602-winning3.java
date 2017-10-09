

public class Program {
  public static String Puzzle(String s) {
	
	char[] letters = s.toCharArray();
	int start = 1;
	char temp;
	int end = s.length()-2;
	while(start<end)
	{
		temp = letters[end];
		letters[end] = letters[start];
		letters[start] = temp;
		
		start++;
		end--;
	} 
    return new String(letters);
  }
}