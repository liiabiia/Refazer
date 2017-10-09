using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if (x ){
		return true;
	}else if (y && z){
		return true;
	}
	return false;
  }
}