

public class Program {
  public static int Puzzle(String s) {
   String[] a = s.trim().split(" ");
      int i, count=1;
	  for (i=0; i<a.length; i++){
		  if (a[i].equals(" ")) count=count+1;
		  
	  }
	  return a.length-count;
  }
}