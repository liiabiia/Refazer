using System;

public class Program {
  public static int Puzzle(int x) {
	
	int counter = -100;
	int result = 142;
	
	if(counter == x) return result;
	do{
		
		counter++;
		result--;
	}while(counter != x);
	if(counter == x) return result;
	else return 0;
  }
}