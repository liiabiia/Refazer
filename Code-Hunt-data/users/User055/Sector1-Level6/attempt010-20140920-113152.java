

public class Program {
  public static int Puzzle(String s) {
   String[] a = s.split(" ");
      int i, count=0;
	  for (i=0; i<a.length; i++){
		  if (a[i] == " ") count=count+1;
		  
	  }
	  return a.length-count;
  }
}