using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
if(x==false&&y==false) {
z=false;
    return z; }
if(x==true&&y==true) {
z=true;
return z; }
if(x==false&&y==true) {
z=false;
return z; }
if(x==true&&y==false) {
z=true;
return z; }
else return true;
  }
}