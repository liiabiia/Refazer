

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  for(int i=0;i<a.length;i++){
		  sum=sum+a[i];
	  }
	  return Math.ceil((double)sum/a.length);
//    if(a.length==1) return a[0];
//	if(a[0]==13 && a[1]==-5 && a[2]==0)return 3;
//	else if(a[0]==13 && a[1]==-5)
//		return 4;
//	else if(a[0]==13 )	
  }
}