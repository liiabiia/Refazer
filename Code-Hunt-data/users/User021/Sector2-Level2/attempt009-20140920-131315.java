

public class Program {
  public static int Puzzle(String s) {
	  int nb_l = 0;
	  int ss = 0;
	  s = s.replaceAll("[^()]", "");
	  
	  if (s.length() % 2 == 1) return 0;
	  
	  for (int i = 0; i < s.length() ; i++)
	  {
		  if (s.charAt(i) == '(')
		  {
				ss++;
				if (ss <= 0)
					nb_l++;	  
		  }
		  else if (s.charAt(i) == ')')
		  {
				ss--;
				if (ss >= 0)
					nb_l++;	  
		  }
		  
		  
	  }
	  
    return nb_l;
  }
}