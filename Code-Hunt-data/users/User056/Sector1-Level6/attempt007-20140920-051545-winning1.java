

public class Program {
  public static int Puzzle(String s) {
int f=0,i;
  int len=s.length();
	for(i=0;i<len;i++)
	 {
	 	if(s.charAt(i)!=' ')
	 	 {
	 	 	f=1;
	 	 	break;
	 	 }
	 }
	 if(f==0)
	  return 0;
	else
	{

	int cnt=0,j;
	for(j=0; ; j++)
	{
		if(s.charAt(j)!=' ')
		 break;
	}
	
	for(i=j;i<len;i++)
	{
		if(s.charAt(i)==' ' && s.charAt(i-1)!=' ')
		 cnt++;
	}
	if(s.charAt(i-1)!=' ')
	 cnt+=1;
	return cnt;
	}
    
  }
}