

public class Program {
  public static int Puzzle(String s) {
   String[] a = s.trim().split(" ");
   boolean x = false;
      int i, count=0;
	  for (i=0; i<a.length; i++){
		  if (a[i].equals(" ")) {
			  count=count+1;
		  x=true;
		  }
	  }if (x == false)
	  return a.length-count;
	  else return a.length-count-1;
  }
}