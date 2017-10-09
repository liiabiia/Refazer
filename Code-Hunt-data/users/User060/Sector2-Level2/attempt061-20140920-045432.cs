using System;

public class Program {
  public static int Puzzle(string s) {
int max = 0;
if (!IsParenthesis(s)) return 0;

int i = 0;
while (i < s.Length)
{
	if (i == 0)
	int count = CheckP(s, i);
	
	if (count > max)
	{
	max = count;
	i += count ;		
	}
	else if (count == -1)
	return 0;
		else if (count < -1)
	return count;

	else
	i++;
}

    return 0;
  }
  
  public static int CheckP(string s, int pos)
  {
	  int left = 0;
	  int right = 0;
	  int i = pos;
	  if (i != 0)
	  return 7;
	  if (s[i] != '(')
	  return -1;
	  
	  while (i < s.Length  && s[i] == '(')
	  {
		  left++;
		  i++;
	  }

	if (left == 0) return -1;
	
	  while (i < s.Length  && s[i] == ')')
	  {
		  right++;
		  i++;
	  }		
	if (left == right)
	return left + right;
	
return -1;	

  }
  
  public static bool IsParenthesis(string s)
  {
	  for (int i = 0; i < s.Length; i++)
	  if (s[i] != '(' && s[i] != ')' )
return false;
	  return true;
  }
  
}

