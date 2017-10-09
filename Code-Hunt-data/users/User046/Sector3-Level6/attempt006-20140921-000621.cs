using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
          int[] retArray = null;

                if (a.Length==0 && b.Length==0) return a;

                Array.Sort(a);
                Array.Sort(b);
                if (b.Length == 0)
                {
                    foreach (int element in a)
                    {
                        //Uncomment the following code
                        if (element > 0)
                            return a;
                    }
                    retArray=new int[1];
                    retArray[0] = 0;
                    return retArray;
                }

                

                if (a.Length > 0 && b.Length > 0)
                {
                    if (a[0] == 0 && b[0] == 0) return new int[0];
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (a[0] < b[i])
                            return a;
                        //else
                        //    return b;
                    }
                }
                else if (a.Length==0 && b.Length > 0)
                     {
                        foreach (int element in b)
                        {
                            if (element >0) return a;
                        }
                     }

                

                return a;

         
    }
}