using System.Linq;
public class Program
{
    public static void Main()
    {
        // int[] array = ArrayOfMultiples(7, 5);
        // foreach (int num in array)
        // {
        //     Console.WriteLine(num);
        // }
        // Console.WriteLine(NameShuffle("Cavalo americano"));
        // Console.WriteLine(HammingDistance("abcde", "bcdef"));
        // Console.WriteLine(CalculateExponent(5, 5));
        // SortNumsAscending(new int[] { 1, 4, -90, 20, 10 });
        // FindMinMax(new double[] { 1, 4, -90, 20, 10 });
        // Console.WriteLine(LongBurp(19));

    }
    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = num * (i + 1);
        }

        return array;
    }
    public static string NameShuffle(string str)
    {
        string[] str2 = str.Split(' ');
        string str3 = $"{str2[1]} {str2[0]}";
        return str3;
    }
    public static int HammingDistance(string str1, string str2)
    {
        int j = 0;
        var arrayOne = str1.ToCharArray();
        var arrayTwo = str2.ToCharArray();

        for (int i = 0; i < arrayOne.Length; i++)
        {
            if (arrayOne[i] != arrayTwo[i])
            {
                j++;
            }
        }
        return j;
    }
    public static long CalculateExponent(long number, long exponent)
    {
        return (long)Math.Pow(number, exponent);
    }

    public static int[] SortNumsAscending(int[] arr)
    {
        if (arr == null)
        {
            arr = Array.Empty<int>();
        }
        else
        {
            Array.Sort(arr);
        }
        return arr;
    }
    public static double[] FindMinMax(double[] values)
    {
        var max = values.Max();
        var min = values.Min();
        return new double[] { min, max };
    }

    public static int Factorial(int num)
    {
        int factorial = num;
        for (int i = 1; i < num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public static string HackerSpeak(string str)
    {
        return str.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');
    }

    public static int GetAbsSum(int[] arr)
    {
        return arr.Sum(num => Math.Abs(num));
    }
    public static string NSidedShape(int n)
    {
        return n switch
        {
            1 => "circle",
            2 => "semi-circle",
            3 => "triangle",
            4 => "square",
            5 => "pentagon",
            6 => "hexagon",
            7 => "heptagon",
            8 => "octagon",
            9 => "nonagon",
            10 => "decagon",
            _ => "wrong number",
        };
    }
    public static int CountVowels(string str)
    {
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        var character = str.ToCharArray();
        var list = character.Where(i => vowels.Contains(i));
        return list.Count();
    }

    public static string LongBurp(int b)
    {
        var burp = new char[b + 3];
        burp[0] = 'B';
        burp[1] = 'u';
        for (int i = 2; i < b + 2; i++)
        {
            burp[i] = 'r';
        }
        burp[b + 2] = 'p';
        string burpStr = new string(burp);
        return burpStr;
    }
    public static bool IsIdentical(string str)
    {
        int j = 0;
        var chars = str.ToCharArray();
        for (int i = 0; i < chars.Count() - 1; i++)
        {
            if (chars[i] != chars[i + 1])
            {
                j++;
            }
        }
        if (j == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int[] MultiplyByLength(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= arr.Length;
        }
        return arr;
    }
    public static bool SameCase(string str)
    {
        int j = 0;
        char[] str2 = str.ToCharArray();
        for (int i = 0; i < str2.Length; i++)
        {
            if (Char.IsUpper(str2[i]))
            {
                j++;
            }
        }
        if (j == 0 || j == str.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}