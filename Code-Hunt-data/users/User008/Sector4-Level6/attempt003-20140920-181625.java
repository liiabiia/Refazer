

public class Program {
  public static String Puzzle(String s) {
	  String res = "";
	  int [] pass = new int[] {1, 1, 2, 3, 5, -18, 13, 21, 8, 3, 11, 14, -1, -13, -14, -1, -15, -16, -5, 5, 0};
	  for (int i = 0; i < s.length(); ++i) {
			res += (char)(s.charAt(i) + pass[i]);
	  }
      return res;
  }
}