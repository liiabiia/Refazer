

public class Program {
  public static int Puzzle(String s) {

  int count =0;
  boolean found = true;
  int i;
  char x;
  for (i=0; i<s.length(); i++){
  
    x=s.charAt(i);
   if (x.equals(" ")){ found = true;
   System.out.println("jere");
   }
   else if (found==true){
	   count=count+1;
	   found=false;
	   
   }
	 
	   
   
  }
  
  return count;
}
}