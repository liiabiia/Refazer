using System;

public class Program {
  public static int Puzzle(string input)   {
            int openB = 0;
            int closeB = 0;
            int adjacent = 0;
            int adjacentOpenB=0;
            int adjacentCloseB = 0;
            char[] arr = input.ToCharArray();
            foreach (char c in arr)
            {
                if (c.Equals( '('))
                    openB++;
                else if (c.Equals(')'))
                    closeB++;

            
            }
            if (openB == closeB)
            {
                for (int i=0; i < arr.Length; i ++)
                {
                    if (arr[i].Equals('('))
                    {
                        if (arr[i + 1].Equals('(') || arr[i + 1].Equals(')'))
                            adjacentOpenB++;
                    }
                    else if (arr[i].Equals(')'))
                    {
                        adjacentCloseB++;

                        if (adjacentOpenB == adjacentCloseB)
                        {
                            adjacent = adjacentCloseB;
                            break;
                        }
                    }


                }
                return adjacent;
            
            
            }
            return 0;
            
        }
}