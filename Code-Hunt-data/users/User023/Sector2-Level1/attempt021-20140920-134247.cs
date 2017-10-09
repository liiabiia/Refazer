using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double result=0;
	  if(a[0]==-1&&a.Length==1)
	  return -1;
	  else{
    for(int i=0;i<a.Length;i++){
		//a[i]=(a[i]==-1 ? 1 : a[i]);
		result+=a[i];
	}
	
	result+=0.1
	
	return (int)(result/a.Length);
	  }
  }
}