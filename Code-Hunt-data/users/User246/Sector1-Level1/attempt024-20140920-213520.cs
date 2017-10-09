using System;

public class Program {
  public static int Puzzle(int x) {
		if(x==0){
			return 42;
		}else{
			if(x==1){
				return 41;
			}else{
				if(x==2){
					return 40;
				}else{
					if(x==3){
						return 39;
					}else{
						return 38;
					}
				}
			}
		}
  }
}