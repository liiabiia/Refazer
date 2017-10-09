

public class Program {
  public static String Puzzle(int n) {
	  printBinaryform(n);
	  
    return "0";
  }
  private static void printBinaryform(int number) {
        int remainder;

        if (number <= 1) {
            return;   // KICK OUT OF THE RECURSION
        }

        remainder = number %2; 
        printBinaryform(number >> 1);
    }
}