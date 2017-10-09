

public class Program {
  public static int Puzzle(int a, int b) {
    if (a%2==0 && b%2==0 || a==b)return a;
	else{
		if(b%2!=0)return a;else
		return a*b;
	}

  }
}