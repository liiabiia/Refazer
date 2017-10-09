using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
          int[] retArray = null;

                if (b.Length == 0)
                {
                    foreach (int element in a)
                    {
                        //Uncomment the following code
                        //if (element > 0)
                            //return a;
                    }
                    retArray=new int[1];
                    retArray[0] = 0;
                }

                if (a == b)
                    retArray = null;

return retArray;

         
    }
}