

public class Program {
  public static int Puzzle(String s) {

  int count =0;
  boolean found = false;
  int i;
  char x;
  for (i=0; i<s.length(); i++){
  
    x=s.charAt(i);
   if (" ".equals(x)){ found = true;
   
   }
   else if (found==true){
	   count=count+1;
	   found=false;
	   
   }
	 
	   
   
  }
  
  return count;
}
}