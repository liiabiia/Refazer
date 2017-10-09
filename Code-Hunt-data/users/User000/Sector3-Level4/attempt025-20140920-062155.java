//b d f h k l o q r s t v w y z

public class Program {
  public static Boolean Puzzle(char c) {
    return !(new String("bdfhkloqrstvwyz ").contains(c.toString()));
  }
}