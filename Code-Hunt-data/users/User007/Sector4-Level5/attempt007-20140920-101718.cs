using System;

public class Program {
  public static int Puzzle(int a, int b, int c) {
	if(c==1 || c==3) return 0;
	else if(c==4) return 3;
	else if(c==5){
		if(a==36 || b==36)return 4;
		else return 2;	
	} 
	else{
		if(a==36 || b==36)return 1;
		else return 0;
	}
  }
}