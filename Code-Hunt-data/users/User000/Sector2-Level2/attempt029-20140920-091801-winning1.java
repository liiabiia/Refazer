

public class Program {
  public static int Puzzle(String s) {
	  int k=0,q=0,maxq=0;
	  if(s.replaceAll("[^()]","").length()%2!=0)
	  	return 0;
		  for (char c : s){
			  if(c=='(')
				k++;
			if(c==')')
			{
				--k;
				q++;
				if(k==0){
					maxq= q>maxq? q : maxq;
					q=0;
				}
				if(k<0){
					return 0;
				}
			}
		  }
    return k==0?maxq:0;
  }
}