

public class Program {
  public static int Puzzle(String s) {
	  int result = 0;
	  int aux = 0;
	  int aux2 = 0;
    for(int i = 0; i < s.length(); i++)
	{
		if(s.charAt(i) == '(')
		{
			aux++;
		}
		else if(s.charAt(i) == ')')
		{
			if(aux > 1)
			{
				if(aux > aux2){
					aux2 = aux;
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