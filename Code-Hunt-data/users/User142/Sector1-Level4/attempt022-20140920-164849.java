

public class Program {
  public static Boolean Puzzle(int x, int y) {
	

    if (x==2 || y==2)
	    return false;
	 if (x==y)
	    return true;	
	boolean testx=true;
	boolean testy=true;    
	for (int i=3;i<=x/2;i++)
	{
		if(x%i==0)
		{
		    testx=false;
			break;
		}
	}
    
	for (int j=3;j<=y/2;j++)
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