using System;
using System.Text;

public class Program {
  public static int Puzzle(string s) {
             int i = 0;
            StringBuilder sb = new StringBuilder(s);
            var ss = sb.ToString().Split(new string[] { "()" }, StringSplitOptions.RemoveEmptyEntries);
            while (ss.Length > 0)
            {
                ss = sb.ToString().Split(new string[] { "()" }, StringSplitOptions.RemoveEmptyEntries);
                sb.Clear();
                foreach (var item in ss)
                {
                    sb.Append(item);
                }
                ++i;
            }
 
            return i;
  }
}