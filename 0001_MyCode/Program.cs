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