using System;

public class Program {
  public static int Puzzle(string s) {

            int startingIndex = s.IndexOf("()");
            int endingIndex = startingIndex + 1;
            int counter = 0;

            try
            {
                if (s.Length % 2 != 0)
                {
                    counter = 0;
                }
                else
                {
                    while (startingIndex >= 0 && endingIndex <= s.Length)
                    {
                        if (s[startingIndex].ToString() == "(" && s[endingIndex].ToString() == ")")
                        {
                            startingIndex--;
                            endingIndex++;
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                
            }
            catch (Exception ex)
            {
                
            }           
    return counter ;
  }
}