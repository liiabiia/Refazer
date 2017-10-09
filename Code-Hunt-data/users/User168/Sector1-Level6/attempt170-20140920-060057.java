

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1,i=0,b=0;
	for(char c : texto)
	{
			
		if(c!=' ')
			i=1;
		else if(i==1)
		{	
			a++;
			i=0;		
		}		
	}
	for(int i=0;i<=s.length();i++)
	{
		if(texto[i]==' ' && texto[i+1]==' ')
		b++;
	}
	if(b>0) return b;
	return a;
  }
}