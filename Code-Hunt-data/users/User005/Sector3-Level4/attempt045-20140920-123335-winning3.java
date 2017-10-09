public class Program {
  public static Boolean Puzzle(char c) {
       return "acegimnpu ".indexOf(c) == -1 ? false : true;
  }
}