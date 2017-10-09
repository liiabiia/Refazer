

public class Program {
  public static int Puzzle(String s) {
    int l, i, f=0;
	l=s.length();
	for(i=1;i<l;i++)
    {
		if(s.charAt(i)==' '&& s.charAt(i-1)!=' ')
		f=f+1;
	}
	if(f==0)
	return 0;
	else
	return (f+1); 
  }
}