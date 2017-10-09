

public class Program {
  public static int Puzzle(String s) {
	  int k=0,q=0,maxq=0;
	  String p="";
	  s=s.replaceAll("[^()]","");
	  while(true){
		  k=s.length();
		  s=s.replace("()","");
		  q=s.length();
		  if(k==q&&k!=0)
		  	return 0;
		if(k==q)
			break;
		 maxq++;
	  }
	  return maxq<=1?0:maxq;
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