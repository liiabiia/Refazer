using System;

public static class Program {
    public static int Puzzle(int[] a) {
       
	   
	   for(int i=a.Length-1;i!=-1;i++)
	   {
		   if(isPrime(a[i])||a[i]==1)
		   return a[i];
	   }
	    return a[0];
    }
	 static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
}