

public class Program {
  public static int Puzzle(String s) {
	  int result = 0;
	  int aux = 0;
	  int aux2 = 0;
	  if(s.charAt(0) == '(')
		{
			aux++;
		}
    for(int i = 1; i < s.length(); i++)
	{
		if(s.charAt(i) == '(')
		{
			aux++;
		}
		else if(s.charAt(i) == ')')
		{
			else if(aux > 1)
			{
				if(aux > aux2){
					aux2 = aux;
				}
				if(s.charAt(i-aux2) != '(')
				{
					aux2 = 0;
				}
				aux--;
			}
			else if(aux > 0)
			{
				if(aux2 > result)
				{
					result = aux2;
					aux2 = 0;
				}
				aux--;
			}
		}
	}
	return result;
  }
}