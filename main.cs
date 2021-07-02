using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    
 double[] celsius =new double[7];
 double total = 0;
 double[] farenheight = new double[7];
 
 for(int i=0; i < celsius.Length; i++)
  {
    Console.WriteLine("Enter Temperature in Celsius");
  celsius[i]=Convert.ToInt32(Console.ReadLine());
  total = total + celsius[i];
  farenheight[i] = celsius[i];
 
  }
  Console.WriteLine("Temperature in Farenheight is ");
 

foreach(double item in celsius)
{
  
  Console.WriteLine(item *9/5+32);
}
Array.Reverse(farenheight);
 double sum = farenheight.Sum();
 double average = sum/7;
 double final = average*9 /5 + 32;
 Console.WriteLine("Average weekly temperature is " + final + "degree farenheight");
  }
}