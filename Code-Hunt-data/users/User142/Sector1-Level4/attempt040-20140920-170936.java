public class Program {
  public static Boolean Puzzle(int x, int y) {
	boolean testx=true;
	boolean testy=true;   
    if (y==2)
        testy=false;
	for (int i=2;i<=x/2;i++)
	{
		if(x%i==0)
		{
		    testx=false;
			c1++;
			break;
		}
	}
    if (c1==1)
	    
	for (int j=2;j<=y/2;j++)
	{
		if(y%j==0)
		{
		    testy=false;
			c2++;
			break;
		}
	}
      if (y==2)
        testy=false;
	 if ( !testx && !testy)
	     return true;
    else 
	    return (testx || testy);
  }
}