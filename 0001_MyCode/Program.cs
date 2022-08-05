using System.Text;
using static System.Console;

namespace _0001_MyCode
{
    class Program
    {
        static void Main( string[] args )
        {

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
}
