using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
          int[] retArray = null;

                if (a.Length == 0 && b.Length == 0) return a;

                Array.Sort(a);
                Array.Sort(b);
                if (b.Length == 0)
                {
                    foreach (int element in a)
                    {
                        //Uncomment the following code
                        if (element > 0) {
                            return a;
                            break;
                            }
                    }
                    retArray = new int[1];
                    retArray[0] = 0;
                    return retArray;
                }



                if (a.Length > 0 && b.Length > 0)
                {
                    if (a[0] == 0 && b[0] == 0) return new int[0];
                    bool flag = false;
                    bool flag1 = false;
                    for (int i = 0; i < b.Length; i++)
                    {

                        if (a[0] < b[i])
                        {
                            flag = true;
                        }
                        else if (a[0] == b[i])
                        {
                            flag1 = true;
                        }
                    }
                    if (flag1 == true) return new int[0];
                    if (flag == true) return a;
                }
                else if (a.Length == 0 && b.Length > 0)
                {
                    foreach (int element in b)
                    {
                        if (element > 0)
                        {
                            return a;
                            break;
                        }
                    }
                }

                return retArray;

         
    }
}