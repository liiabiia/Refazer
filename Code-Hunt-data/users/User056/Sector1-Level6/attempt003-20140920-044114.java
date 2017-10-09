

public class Program {
  public static int Puzzle(String s) {
  int len=s.length();
	for(i=0;i<len;i++)
	 {
	 	if(s.at(i)!=' ')
	 	 {
	 	 	f=1;
	 	 	break;
	 	 }
	 }
	 if(f==0)
	  return 0;
	else
	{
	//cout<<len;
	int i;
	int cnt=0;
	for(i=0;i<len;i++)
	{
		if(s.at(i)==' ')
		 cnt++;
	}
	return cnt+1;
	}
    
  }
}