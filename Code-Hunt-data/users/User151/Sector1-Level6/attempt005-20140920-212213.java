

public class Program {
  public static int Puzzle(String s) {
	  String [] parts = s.split(" ");
	  int count = 0;
	  for(int i = 0; i<parts.length; i++)if(parts[i]!= " ") count++;
    return count;
  }
}