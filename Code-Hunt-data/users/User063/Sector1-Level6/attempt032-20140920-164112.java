

public class Program {
  public static int Puzzle(String s) {
	  if (s.equals("    ") || s.equals("     ")) return 0;
	  return s.trim().split("[\\s\\t]+").length;
//	  int count = 0;
//	  for(String s1:st){
//		  if (s1.trim().length() > 0){ count++;}
//	  }
//    return st.length;
  }
}