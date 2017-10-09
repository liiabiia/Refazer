using System;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		foreach(int x in a)if(x!=0)list.Add(x);
		int i = 0;
		if(list.Count > 0){
			if(list[i]%2!=0){
				while(i<list.Count-1)
				{
					if(list[i+1]%2!=0)i++;
					else break;
				}
				return list[i];
			}
			else{
				while(i<list.Count-1)
				{
					if(isPower(list[i],2)&&isPower(list[i+1],2))break;
					if(!isPower(list[i],2)&&isPower(list[i+1],2))break;
					if(list[i+1]%2==0)i++;
					else break;
				}
				return list[i];
			}
		}
//		for(int i = a.Length-1;i>=0;i--)
//		{
//			if(a[i]!=1 &&a[i]!=0 && !isPower(a[i],2))return a[i];
//		}
//		for(int i = 0;i<a.Length;i++)
//		{
//			if(a[i]!=0 && isPower(a[i],2))return a[i];	
//		}
		return 0;
		
    }
	public static bool isPower(int x,int y)
	{
		if(x==1)return true;
		while (x%y == 0)  x = x / y;
		return x == 1;
	}
}
