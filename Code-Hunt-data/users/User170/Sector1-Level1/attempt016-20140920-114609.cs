using System;

public class Program {
  public static int Puzzle(int x) {
	
	int counter = 0;
	int result = 42;
	
	if(counter == x) return result;
	do{
		if(counter == x) return result;
		counter++;
		result--;
	}while(counter != x);
	
	return 0;
  }
}