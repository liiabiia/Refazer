
public class Program {
  public static int Puzzle(int[] a) {
	if(a.length==1)return a[0];
	int j=0,posflag=0;
	boolean flag=false;
	for(int i=0;i<a.length;i++)
	{
		if(a[i]<0)flag=!flag;
		else posflag++;
		j+=a[i];
	}
	if(j==0)return 0;
	if(posflag==a.length) return (int) Math.floor((double)j/3)+1;
	
	if(flag) return (int) Math.ceil((double)j/3);
	else return (int) Math.floor((double)j/3)+1;
  }
}