using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
		if(x==y){
			return x&&y;
		}else{
			if(y==z){
				return y||z;
			}else{
				return z&&x;
			}
		}
		
  }
}