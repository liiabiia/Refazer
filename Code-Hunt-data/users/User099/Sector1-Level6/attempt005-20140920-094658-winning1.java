

public class Program {
  public static int Puzzle(String s) {
     int count = 1;
	 if(s.charAt(0) == ' ') count = 0;
        for (int i = 0; i < s.length(); i++)
        {
			if(i == s.length() - 1) break;
            if (s.charAt(i) == ' ' && s.charAt(i+1)!=' ')
            {
                count++;
            }
        }
        return count;
  }
}