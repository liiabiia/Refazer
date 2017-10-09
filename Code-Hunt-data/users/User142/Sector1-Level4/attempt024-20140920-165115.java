

public class Program {
  public static Boolean Puzzle(int x, int y) {
	


	 if (x==y)
	    return true;	
	boolean testx=true;
	boolean testy=true;    
	for (int i=2;i<=x/2;i++)
	{
		if(x%i==0)
		{
		    testx=false;
			break;
		}
	}
    
	for (int j=2;j<=y/2;j++)
	{
		if(y%j==0)
		{
		    testy=false;
			break;
		}
	}
    return (testx || testy);
  }
}