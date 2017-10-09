

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  double xNew = x;
	  double yNew = y;
	  
	  if(xNew == 0 || yNew == 0){
		  return true;
	  }
	  if(xNew > yNew){
	  while(xNew!=1){
		  if(xNew%2==0){
		  	xNew = xNew/2;
		  }else{
			  xNew = -1;
			  break;
		  }
	  }
	  while(yNew!=1){
		  if(yNew%2==0){
		  	yNew= yNew/2;
		  }else{
			  yNew = -1;
			  break;
		  }
	  }
	  }
	  if(xNew != -1 || yNew != -1){
		  return true;
	  }else{
		  return false;
	  }
  }
}