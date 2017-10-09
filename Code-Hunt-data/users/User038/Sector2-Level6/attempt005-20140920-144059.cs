using System;

public class Program {
  public static string Puzzle(int n) {int quot,bin;

        string rem = "";

        while (n >= 1)

        {

            quot =n / 2;

            rem += (n % 2).ToString();

            n= quot;

        }

        string bin = "";

        for (int i = rem.Length - 1; i >= 0; i--)

        {

            bin = bin + rem[i];

        }
    return "bin";
  }
}