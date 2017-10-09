using System;

public class Program {
  public static int Puzzle(int[] a) {
int total = 0;
            int negValCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0) negValCounter++;
                if (negValCounter > 1)
                    total += Convert.ToInt32(a[i].ToString().Split('-')[1]);
                else
                    total += a[i];
            }
            double ret = System.Math.Round(Convert.ToDouble(total) / Convert.ToDouble(a.Length),1);
            string[] s = ret.ToString().Split('.');
            int finalVal = 0;
            if (s.Length > 1)
            {
                if ((int.Parse(s[1]) - 1) > 5)
                    finalVal = int.Parse(s[0]) + 1;
                else
                    finalVal = int.Parse(s[0]);
            }
            else
                finalVal = Convert.ToInt32(ret);
return finalVal;
    
  }
}