

public class Program {
  public static String Puzzle(String s) {
    String newS = s.charAt(0)+"";
    for(int i=s.length()-2;i>0;i--){
      newS = newS + s.charAt(i);
    }
    return newS+s.charAt(s.length()-1);
  }
}