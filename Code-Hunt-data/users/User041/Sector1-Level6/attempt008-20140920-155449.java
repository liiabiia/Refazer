

public class Program {
  public static int Puzzle(String s) {
	  int len = s.length();
	  char[] a = s.toCharArray();
	  int word =0;
	  for (int i=0; i < len ; i++){
		  if (a[i]== ' ' & a[i-1] != ' ' & a[i+1] != ' '){word++;
		  	word++;
		  }
	  }
    return word;
  }
}