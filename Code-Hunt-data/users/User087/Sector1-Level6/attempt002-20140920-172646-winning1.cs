using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] a = s.Split(' ');
            int c=0;
            foreach(string t in a)
                if (!t.Equals(""))
                 c+=1;
    return c;
  }
}