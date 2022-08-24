using System.Text;
using static System.Console;

namespace _0001_MyCode
{
    class Program
    {
        static void Main( string[] args )
        {
            var list = CreateList(
                    new { Number = 10, Name = "Smith" },
                    new { Number = 10, Name = "John" }
            ).ToList( );

            foreach (var item in list)
            {
                WriteLine($"Number - {item.Number}, Name = {item.Name}");
            }

            int[] a = { 1, 2, 3, 4 };
            int[] b = { 4, 16, 1, 2, 3, 22 };
            Concat(a, b).PrintAll(  );
        }

        public static List<T> CreateList<T>( params T[] elements )
        {
            return new List<T>(elements);
        }

        public static int Max( params int[] numbers )
        {
            int max = numbers[0];

            for (var i = 1; i < numbers.Length; i++)
            {
                var current = numbers[i];
                if (max < current)
                {
                    max = current;
                }
            }

            return max;
        }

        public static T[] Concat<T>( T[] arr1, T[] arr2 )
        {
            T[] result = new T[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                result[arr1.Length + j] = arr2[j];
            }

            return result;
        }
    }

    public static class MyHelpers
    {
        public static void PrintAll<T>( this IEnumerable<T> enumerable )
        {
            foreach (T item in enumerable)
            {
                Write($"{item} ");
            }
        }
    }

    class StringWrapper
    {
        string _str;
        public StringWrapper( string str ) { _str = str; }

        public static string operator *( StringWrapper wrapper, int count )
        {
            var sb = new StringBuilder( );
            for (int i = 0; i < count; i++)
            {
                sb.Append(wrapper._str);
            }

            return sb.ToString( );
        }
    }

    record Point( int X, int Y );
}