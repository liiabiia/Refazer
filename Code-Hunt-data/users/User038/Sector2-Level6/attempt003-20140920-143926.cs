using System;

public class Program {
  public static string Puzzle(int n) {int quot;

        string rem = "";

        while (n >= 1)

        {

            quot = num / 2;

            rem += (num % 2).ToString();

            num = quot;

        }

        string bin = "";

        for (int i = rem.Length - 1; i >= 0; i--)

        {

            bin = bin + rem[i];

        }
    return "bin";
  }
}