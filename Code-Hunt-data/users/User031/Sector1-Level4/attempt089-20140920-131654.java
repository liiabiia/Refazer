

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  
	  int z=x;
	  
	  if(x == 0 || y == 0 || y == 1){
		  return true;
	  }
	  if(x > y){
		  
	  while(z!=1){
		   if(z%y==0){
		  	z = 1;
		  }else{
			  z = -1;
			  break;
		  }
	  }
		  
	  while(x!=1){
		  if(x%2==0){
		  	x = x/2;
		  }else{
			  x = -1;
			  break;
		  }
	  }
	  while(y!=1){
		  if(y%2==0){
		  	y = y/2;
		  }else{
			  y = -1;
			  break;
		  }
	  }
	  }else{
		  return false;
	  }
	  if(x != -1 && y != -1 || z != -1){
		  return true;
	  }else{
		  return false;
	  }
  }
}