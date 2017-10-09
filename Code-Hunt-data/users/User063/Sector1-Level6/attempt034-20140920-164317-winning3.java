

public class Program {
  public static int Puzzle(String s) {
	  return s.trim().length() == 0 ? 0 : s.trim().split("[\\s\\t]+").length;
//	  int count = 0;
//	  for(String s1:st){
//		  if (s1.trim().length() > 0){ count++;}
//	  }
//    return st.length;
  }
}