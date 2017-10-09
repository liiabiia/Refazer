using System;

public class Program {
	 public static int Puzzle(string s)
        {
            int count = 0;
            int max = 0;
            bool check = true;
            int i = 0;
            int greatest = 0;
            int len = s.Length;
            while (i < len)
            {
                while (i < len)
                {
                    if (i < len && s[i] == '(')
                    {
                        check = true;
                        count++;
                        i++;
                        continue;
                    }
                    else if (i < len && s[i] != ')')
                    {
                        if(Char.IsLetter(s[i])||Char.IsWhiteSpace(s[i]))
                       
                        {
                            i++;
                            continue;
                        }                 
                        else
                        {
                            check = false;
                            i++; 
                        }
                        
                    }
                        
                    else break;
                }
                if (max == 0)
                {
                    max = count;
                    greatest = count;
                }
                else if (max != 0 && count > max)
                {
                    greatest = max;
                    max = count;
                }
                if (i < len && s[i] == ')' && count > 0)
                {
                    while (i < len && count != 0)
                    {
                        if (i < len && s[i] == ')')
                        {
                            count--;
                            i++;
                            continue;
                        }
                        else
                        {
                            if (Char.IsLetter(s[i]) || Char.IsWhiteSpace(s[i]))
                            {
                                i++;
                                continue;
                            }

                            else
                            {
                                check = false;
                                break;
                            }

                        }
                    }
                }
                else if (i==len && count ==0)
                {
                    check = true;
                    continue;
                }
                else
                    check = false;
                if (count == 0 && i < len)
                    if ((s[i] == '(') || (Char.IsLetter(s[i])) || Char.IsWhiteSpace(s[i]))
                    {
                        if (Char.IsLetter(s[i]) || Char.IsWhiteSpace(s[i]) )
                        {
                            i++;
                            continue;
                        }
                        else
                            continue;                            
                    }
                        
                    else
                        break;
                count = 0;
            }
            
            if (check == true && count == 0 && i < len)
            {
                while (i < len)
                {
                    if (i < len && s[i] != '(' && s[i] != ')')
                    {
                        i++;
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check == true && count == 0 && i == s.Length)
                return greatest;
            else
                return 0;
        }
	
}