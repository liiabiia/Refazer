using System;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0, media;
	for(int i=0; i<a.Length; i++) sum += a[i];
	media = sum / (double)a.Length;
	if(media<1 & media > -1) return 0;
	return media > 0 & media<1 ? 1 : media<0 & media>-1 ? 0 : (int)Math.Round(sum / (double)a.Length);
  }
}