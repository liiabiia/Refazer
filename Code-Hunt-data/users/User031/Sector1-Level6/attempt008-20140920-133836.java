

public class Program {
  public static int Puzzle(String s) {
        int counter = 0;
        for(char c: s.toCharArray()){
            if(c.equals(" "))
                counter++;
        }
        return counter;
  }
}