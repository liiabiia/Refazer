using System;

public class Program {
  public static int Puzzle(string s) {
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == "(")
                    counter1++;
                else
                    break;
            }
            for (int i = counter1; i < s.Length; i++)
            {
                if (s[i].ToString() == ")")
                    counter2++;
                else
                    break;
            }
            textBox1.Text = counter1.ToString() + ":" + counter2.ToString();
    return counter1 == counter2 ? (counter1 == 1 ? 0 : counter1) : 0;
  }
}