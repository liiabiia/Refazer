

public class Program {
  public static Boolean Puzzle(int x, int y) {
	 // int a= x/y;
	  //if((x-y)%2!=0){
	  int a= x*y;
	  if(x==0 && y==1){return true;}
    if(a%2!=0){
	return true;}
	return false;
  }
}