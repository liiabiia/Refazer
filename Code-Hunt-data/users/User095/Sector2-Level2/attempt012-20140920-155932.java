

public class Program {
  public static int Puzzle(String s) {
	  int l=0;
	  int p=0;
	  
	  char[] c_arr = s.toCharArray();
	   for(int i=0;i<c_arr.length;i++){
	   if(c_arr[i] == '\0')c_arr[i] = 'a';
	   if(c_arr[i] == '(')++l;
	   if(c_arr[i] == ')')++p;
	   
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