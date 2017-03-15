using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitives_RefTypes_ValTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a = 15;
            Int32 b = 15;
            Console.WriteLine("Default Result: "+a+b);
            Console.WriteLine("Using ToString method:"+a.ToString()+b.ToString());
            Console.WriteLine("Using breakets for (a+b):"+(a+b));

            
            Int32 _x = 100;
            Int32 _y = _x + 23;
            Boolean _lessThanFifty = (_y<50);
            Console.WriteLine(_lessThanFifty);
            Byte b1 = 100;
            b1 = unchecked((Byte)(b1 + 200));   ///Не будет проверки на переполнениее типа Byte.Результат 44.
                                                ///т.к макс от Byte 255 (0-255 = 256 размер)=>300-256=44.
            //b1=checked((Byte)(b1+200));
            Console.WriteLine(b1);              ///Будет проводится проверка на выход за рамки типа Byte.
                                                ///Результат RTE. Результат >255.
            Char chr = 'b';
            Char chr1 = 'b';
            
            

                Console.WriteLine("Hash code of {0}{2}{1}", chr, chr1, (Equals(chr.GetHashCode(), chr1.GetHashCode())) ? "==" : "!=");

        }
    }
}
