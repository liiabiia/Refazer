

public class Program {
  public static int Puzzle(int a, int b) {
	  boolean flag=false;
	  boolean flag2 = false;
    if (a%2==0 && b%2==0 || a==b)return a;
	else
		if(b%2!=0){
			flag=true;
			flag2 = true;
		}else
		if(a%2!=0&&b%2!=0)
		{
			flag=false;
			flag2 = true;

		}
		if(flag && flag2)return b;else if(!flag && flag2)return b;
		
		if(!flag2)
		return a*b;
		else{
			
			return 0;
		}

  }
}