

public class Program {
  public static int Puzzle(String s) {
    int l, i, f=0;
	l=s.length();
	for(i=1;i<l;i++)
    {
		f+=((s.charAt(i)==' '&& s.charAt(i-1)!=' ')?1:0);
	}
	return (f+(s.charAt(l-1)==' '?0:1)); 
  }
}