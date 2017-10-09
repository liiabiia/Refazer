

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  
	  //if(x%2 == 1 && x<=y)
	 // 	return true;
	//  if(x%2 == 0 && x>=y)
	//  	return true;
	Boolean b = (Boolean) x|y;
		 
	return b;	  		  
	  /*
	  if(x%2 == 0 && y%2 == 0)
	  
	  if(x%2 == 0 && y%2 == 1)
	  
	  if(x%2 == 1 && y%2 == 0)
	  
	  if(x%2 == 1 && y%2 == 1)
	  if(x==0 || y==1)	return true;
	  
	  if(x%2 == 0 || y%2==1 ) return true;
    if(x%2==1 && y%2==1 && x>y) return false;
	
	return false;
	*/
  }
}