using System;

public class Program {
  public static string Puzzle(int n) {
	  var result = String.Empty;
	  while(n > 0){
	  result = n%2==0?"0":"1"+result;
	  n /=2; 
  }
	  result = n%2==0?"0":"1"+result;
    return result;
  }
}