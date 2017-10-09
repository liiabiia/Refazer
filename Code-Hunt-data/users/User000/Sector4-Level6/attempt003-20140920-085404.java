

public class Program {
  public static String Puzzle(String s) {
    String s2="";
		
		for(int i=0;i<s.length();i++){
			s2+=(char)((s1.charAt(i)-'a'+fib(i+1))%26+'a');
		}
		return s2;
  }
  public static int fib(int i){
			if(i==0)return 0;
			if(i==1)return 1;
			return fib(i-1)+fib(i-2);
		}
}