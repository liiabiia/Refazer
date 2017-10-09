

public class Program {
  public static String Puzzle(int n) {
        int i = 0;String s="";
        int b[] = new int[10];
        while (n != 0)
        {
            i++;
            b[i] = n % 2;
            n = n / 2;
        }
        for (int j = i; j > 0; j--)
        {
            s=s+(String)b[j];
        }
  }
}