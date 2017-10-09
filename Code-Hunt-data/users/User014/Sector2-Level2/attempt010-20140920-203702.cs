using System;
using System.Text;

public class Program {
  public static int Puzzle(string s) {
            int i = 1;
            StringBuilder sb = new StringBuilder(s);
            var ss = sb.ToString().Split(new string[] { "()" }, StringSplitOptions.RemoveEmptyEntries);
            while (ss.Length > 1)
            {
                ss = s.Split(new string[] { "()" }, StringSplitOptions.RemoveEmptyEntries);
                sb.Clear();
                foreach (var item in ss)
                {
                    sb.Append(item);
                }
                s = sb.ToString();
                if(s.Contains("()"))
                    ++i;
            }
            return i==1?0:i;
  }
}