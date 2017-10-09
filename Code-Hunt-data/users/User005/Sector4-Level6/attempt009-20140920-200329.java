public class Program {
 public static String Puzzle(String s) {
 //if (s.equals("z")) return "a";
 String res = "";
 int [] pass = new int[] {1, 1, 2, 3, 5, -18, 13, 21, 8, 3, 11, 14, -1, -13, -14, -1, -15, -16, -5, 5, 0, 5, 5, -16, -11, -1, -12, -10};
 for (int i = 0; i < s.length(); ++i) {
 char t = (char)(s.charAt(i) + pass[i%pass.length]);
 if (t > 'z') t -= (char)('z' - 'a' + 1);
 if (t < 'a') {
 t = (char)( 'z'  - ('a' - t) + 1);
 }
 
res += t;
 }
     return res;
 }
}