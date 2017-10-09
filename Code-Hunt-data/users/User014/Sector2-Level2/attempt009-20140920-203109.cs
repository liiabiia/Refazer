using System;
using System.Text;

public class Program {
  public static int Puzzle(string s) {
            int i = 0;
            StringBuilder sb = new StringBuilder(s);
            var ss = sb.ToString().Split(new string[] { "()" }, StringSplitOptions.RemoveEmptyEntries);
            while (ss.Length > 1)
            {
                ++i;
                sb.Clear();
                foreach (var item in ss)
                {
                    sb.Append(item);
                }
                ss = sb.ToString().Split(new string[] { "()" }, StringSplitOptions.RemoveEmptyEntries);
                
            }
            return i==1?0:i;
  }
}