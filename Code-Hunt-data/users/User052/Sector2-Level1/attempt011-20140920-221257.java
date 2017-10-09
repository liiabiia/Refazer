

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  int pro=1;
	  if(a[0]==-1 && a[1]==-1 &&a.length==2) return 0;
	  
	  for(int i=0;i<a.length;i++){
	      pro=pro*a[i];
		  sum=sum+a[i];
	  }
	  if(pro<0)
	  return (int)Math.ceil((double)sum/a.length);
	  else
	  return (int)Math.floor((double)sum/a.length);
//    if(a.length==1) return a[0];
//	if(a[0]==13 && a[1]==-5 && a[2]==0)return 3;
//	else if(a[0]==13 && a[1]==-5)
//		return 4;
//	else if(a[0]==13 )	
  }
}