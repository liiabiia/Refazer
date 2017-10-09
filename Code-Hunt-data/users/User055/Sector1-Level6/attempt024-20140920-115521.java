

public class Program {
  public static int Puzzle(String s) {
  s=s.trim();
  count =0;
  boolean found = false;
  int i;
  for (i=0; i<s.length(); i++){
  
   char x=s.charAt(i);
   if (!x==" ") 
	  if (found = true){
		  
		  count++;
		  found=false;
	  }
	   else found = true;
	   +
   
  }
  
  return count;
}