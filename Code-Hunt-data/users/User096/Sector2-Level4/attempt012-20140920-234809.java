

public class Program {
  public static int Puzzle(int a, int b) {
    if (a%2==0 && b%2==0 || a==b)return a;
		if(b%2!=0)return a;
		if(a%2!=0&&b%2!=0)return b;
		return a*b;
	}

  }
}