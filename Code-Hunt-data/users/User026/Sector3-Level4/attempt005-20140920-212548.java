

public class Program {
  public static Boolean Puzzle(char c) {
    return (((c-'a')+1)%2==0)?false:true;
  }
}