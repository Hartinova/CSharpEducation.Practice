using System.Linq;

namespace Practice7.Task6.Model
{
  public static class StringExtensions
  {
    public static bool IsPalindrome(this string str)
    {
      var reverseStr = new string ( str.Reverse().ToArray());
      return (str == reverseStr);
    }

    public static string ToTitleCase(this string str)
    {
      if (str != "")
      {
        var str1 = str.Substring(0, 1).ToUpper();
        var str2 = str.Substring(1, str.Length - 1);
        str = str1 + str2;
      }
      return str;
    }
  }
}
