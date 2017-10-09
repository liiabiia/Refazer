public class Program {

static int f(int n){
   int prev=0, next=1, result=1;
   for (int i = 1; i <n; i++) {
       result=prev+next;
       prev=next;
       next=result;
   }
   return result;
}

public static String Puzzle(String s) {
String res = "";

for (int i = 0; i < s.length(); ++i) {
char t = (char)(s.charAt(i) + (f(i+1) % 26));
if (t > 'z') t -= (char)('z' - 'a' + 1);
if (t < 'a') {
t = (char)( 'z'  - ('a' - t) + 1);
}

res += t;
}
    return res;
}



}
public static class Program {
public static int[] Puzzle(int[] a, int[] b) {
if (a.length == 0) return new int[0];


for (int i = 0; i < a.length; ++i) {
for (int j = 0; j < b.length; ++j) {
if (a[i] == b[j]) return new int[0];
//	if (a[i] != b[j])
//	return false;
}
}

if (hasOnlyZeros(a))
return new int[1];

return a;
}

private static boolean hasOnlyZeros(int[] a) {
for (int i = 0; i < a.length; ++i) {
if (a[i] != 0)
return false;
}
return true;
}
}