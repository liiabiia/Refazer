
public class Program {
  public static int Puzzle(int[] a) {
	if(a.length==1)return a[0];
	int j=0;
	boolean flag=false;
	for(int i=0;i<a.length;i++)
	{
		j+=a[i];
		if(a[i]<0)flag=true;
	}
	if(!flag) return (int) Math.floor((double)j/3);
	else return (int) Math.ceil((double)j/3);
  }
}