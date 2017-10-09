

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0,ret=0;
	  for(int i=0;i<a.length;i++) sum=sum+a[i];
	  double average = (double)sum/a.length;
	  int k =(int)average;
	  if((float)k==(float)average) ret=k;
	  else if(-(float)k+(float)average<0.5) ret=k;
	  else ret=k+1;
	  //if(a.length>1 && a[0]==-1&&a[1]==-1)return 0;
          if(ret>=0)return ret;
else return ret+1;
          
  }
}