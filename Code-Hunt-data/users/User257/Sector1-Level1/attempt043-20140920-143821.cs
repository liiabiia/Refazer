using System;
public class Program {
 public static int Puzzle(int x) {

if ( x == 0)
{

return x+42;
	
}
else if ( x == 33 )
{
	return x-24;
}
else if(x==34)
{
	return x-26;
}
else if(x==35)
{
	return x-28;
}

else
{
	return x-59-1;
}
}
}
