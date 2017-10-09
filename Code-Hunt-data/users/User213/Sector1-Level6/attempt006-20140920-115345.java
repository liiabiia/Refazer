

public class Program {
  public static int Puzzle(String s) {
    int w=0;
	int len=s.length();
	for(int i=0; i<=len; i++)
	{
		if(s[i]==" ")
		w+=1;
	}
	if(w==1)
	return 0;
	else return w+1;
  }
}