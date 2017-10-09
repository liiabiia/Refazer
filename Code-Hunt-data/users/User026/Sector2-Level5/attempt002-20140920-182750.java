
import java.util.*;
public class Program {
  public static int Puzzle(int[] a) {
	int soma = 0;
	for(int i = 0; i<a.length; i++)soma-=a[i];
	if(a.length<20)return Math.abs(soma);
	else{
		Arrays.sort(a);
	}
    return return a[a.length-1];
  }
}