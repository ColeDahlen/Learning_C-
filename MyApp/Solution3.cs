using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int result = 0;
    foreach(var a in arr)
    {
      if(a >= 0){
        result = result + a;
      }
    }
    return result;
  }
}
