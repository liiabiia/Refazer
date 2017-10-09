using System;

public class Program {
  public static int Puzzle(string s) {
    string [] split = s.Split();
		int cnt=0;
        foreach (string s1 in split) {

            if (s1.Trim() != "")
			{
                //Console.WriteLine(s);
				++cnt;
			}
        }
		return cnt;
  }
}