using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
		if(x&&y){
			return x&&y;
		}else{
			if(x&&z){
				return x&&z;
			}else{
				return (y&&z);
			}
		}
		
  }
}