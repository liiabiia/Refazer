using System;

public class Program {
  public static int Puzzle(string s) {
int max = 0;
if (!IsParenthesis(s)) return 0;

for (int i = 0; i < s.Length; i++)
{
	int count = CheckP(s, i);
	if (count > max)
	max = count;
	else if (count == -1)
	return -1;
}

    return 0;
  }
  
  public static int CheckP(string s, int pos)
  {
	  int left = 0;
	  int right = 0;
	  if (s[i] != '(')
	  return -1;
	  while (s[i] == '(' && i < s.Length )
	  {
		  left++
		  i++;
	  }

	if (left == 0) return -1;
	
	  while (s[i] == ')' && i < s.Length )
	  {
		  right++;
		  i++;
	  }		
	if (left == right)
	return left;
	
return -1;	

  }
  
  public static bool IsParenthesis(string s)
  {
	  for (int i = 1; i < s.Length; i++)
	  if (s[i] != '(' && s[i] != ')' )
return false;
	  return true;
  }
  
}

