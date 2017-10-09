

public class Program {
  public static int Puzzle(String s) {
	  int k=0,q=0,maxq=0;
	  String p="";
	  while(true){
		  p="("+p+")";
		  if(s.contains(p))
		  	k++;
	  }
	  return k<=1?0:k;
	  ////if(s.replaceAll("[^()]","").length()%2!=0)
	  	//return 0;
      for (char c : s){//s.replaceAll("[^()]","")){
			  if(c=='(')
				k++;
			if(c==')')
			{
				--k;
				if(k<0)
					return 0;
				q++;
				if(k==0){
					if(q>maxq)maxq=q;
					q=0;
				}
			}
		  }
    return k==0?maxq:0;
  }
}