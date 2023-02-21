public class Kata
{
  public static bool Check(object[] a, object x)
  {
    foreach(var y in a)
    {
      if(y.Equals(x))
        return true;
      
    }
    return false;
  }
}