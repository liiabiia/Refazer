

public class Program {
  public static int Puzzle(int a, int b) {
	  boolean flag=false;
    if (a%2==0 && b%2==0 || a==b)return a;
	else
		if(b%2!=0){
			flag=true;
		}else
		if(a%2!=0&&b%2!=0)
		{
			flag=false;

		}
		if(flag)return a;else return b;
		return a*b;
	

  }
}