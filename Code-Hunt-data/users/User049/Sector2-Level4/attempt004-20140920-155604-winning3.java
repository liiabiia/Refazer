

public class Program {
  public static int Puzzle(int a, int b) {
	  
	  int temp1 = a, temp2 = b;
	  
	  while (temp1 != temp2)
	  {
		  if (temp1 > temp2)
		  	temp1 -= temp2;
		else
			temp2 -= temp1;
	  }
	  
    return (a * b) / temp1;
  }
}