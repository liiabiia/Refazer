

public class Program {
  public static String Puzzle(String s) {
    String new = "s.charAt(0);
    for(int i=s.length-2;i>0;i--){
      new = new + s.charAt(i);
    }
    return new+s.charAt(s.length-1);
  }
}