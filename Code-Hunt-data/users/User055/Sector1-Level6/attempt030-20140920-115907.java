

public class Program {
  public static int Puzzle(String s) {
  s=s.trim();
  int count =0;
  boolean found = true;
  int i;
  char x;
  for (i=0; i<s.length(); i++){
  
    x=s.charAt(i);
   if (!x.equals(" ")) 
	  if (found = true){
		  
		  count++;
		  found=false;
	  }
	   else found = true;
	   
   
  }
  
  return count;
}
}