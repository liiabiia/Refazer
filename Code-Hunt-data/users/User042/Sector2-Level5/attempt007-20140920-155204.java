

public class Program {
  public static int Puzzle(int[] a) {
    int smallest = 0, largest = 0;
	for(int i = 0; i < a.length; i++)
	{
		if(smallest > a[i])
			smallest = a[i];
		if(largest < a[i])
			largest = a[i];
	}
	return largest-smallest;
  }
}