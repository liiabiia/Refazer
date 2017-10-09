

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	//String[] tokens = s.split("[ ]");
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
	return a;
  }
}