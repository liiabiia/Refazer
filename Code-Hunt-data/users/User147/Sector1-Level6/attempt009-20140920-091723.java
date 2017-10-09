

public class Program {
  public static int Puzzle(String s) {
	  int j = 0;
    for (int i = 0; s.Count; i++)
		if (s[i] == " ")
			j++;
	return j;
  }
}