

public class Program {
  public static int Puzzle(String s) {
	//char[] c = s.toCharArray();
    int count = 0; boolean word = false;
	for(int i =0; i < s.length(); ++i)
	{
		if(s.charAt(i) != ' ') {
			if(!word) {
				++count;
				word = true;
			}
		}
		else
			word = false;	
	}
	return count;
  }
}