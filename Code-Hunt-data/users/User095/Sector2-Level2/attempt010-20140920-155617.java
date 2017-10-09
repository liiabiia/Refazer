

public class Program {
  public static int Puzzle(String s) {
	  char[] c_arr = s.toCharArray();
	   for(int i=0;i<c_arr.length;i++){
	   if(c_arr[i] == '\0')c_arr[i] == 'a';
	   }
	 int c=0;
	 
	 for(int i=0;i<c_arr.length/2;i++){
		 if ((c_arr[i] == '(') && (c_arr[c_arr.length-1-i] == ')')) {
			 ++c;
		 }
	 }
    return c;
  }
}