
import java.util.*;
public class Program {
  public static int Puzzle(int[] a) {
	int soma = 0;	
	
		Arrays.sort(a);
		
	for(int i = 0; i<a.length-1; i++)soma+=a[i];
	if(a.length<20)return a[a.length-1]-soma;
	else{
		return a[a.length-1];
	}
    
  }
}