using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
		if(x&&y&&z){
			return x&&y&&z;
		}else{
			if(x==false && y==false && z==false){
				return false;
			}else{
				return true;
			}
		}
		
  }
}