using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
		if(x== false){
			if(y==false){
				if(z==false){
					return false;
				}else{
					true;
				}
			}else{
				if(z==false){
					return true;
				}else{
					return false;
				}
			}
		}else{
			if(y==true){
				return true;
			}else{
				if(z==true){
					return true;
				}else{
					return false;
				}
			}
			
		}
		
  }
}