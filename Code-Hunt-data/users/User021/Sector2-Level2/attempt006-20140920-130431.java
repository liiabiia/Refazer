

public class Program {
  public static int Puzzle(String s) {
	  int nb_l = 0;
	  int ss = 0;
	  boolean changed = false;
	  s = s.replaceAll("[\\W]|_", "");
	  
	  if (s.length() % 2 == 1) return 0;
	  
	  for (int i = 0; i < s.length() ; i++)
	  {
		  if (s.charAt(i) == '(')
		  {
				ss++;
				changed = true;	  
		  }
		  else if (s.charAt(i) == ')')
		  {
				ss--;
				changed = true;	  
		  }
		  if (changed && ss == 0)
		  {
			  changed = false;
			  nb_l++;
		  }
		  
	  }
	  
    return nb_l;
  }
}