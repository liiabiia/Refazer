

public class Program {
  public static int Puzzle(String s) {
	  int nb_l = 0;
	  int ss = 0;
	  s = s.replaceAll("[^()]", "");
	  
	  if (s.length() % 2 == 1 || s.charAt(0) == ')') return 0;
	  
	  for (int i = 0; i < s.length() ; i++)
	  {
		  if (s.charAt(i) == '(')
				ss++;
		  else if (s.charAt(i) == ')')
		  {
				ss--;
				if (ss >= 0)
					nb_l++;	  
		  }
	  }
	  
	 if (ss != 0) return 0;
	 
     return nb_l;
  }
}