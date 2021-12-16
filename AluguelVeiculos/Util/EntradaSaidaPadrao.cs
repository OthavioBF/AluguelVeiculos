using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Util
{
    class EntradaSaidaPadrao
    {
        public static void Mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static int ReadInt(string mensagem)
        {
            Mensagem(mensagem);

            return ReadInt();
        }

        public static double ReadDouble(string mensagem)
        {
            Mensagem(mensagem);

            return ReadDouble();
        }

        public static string ReadString(string mensagem)
        {
            Mensagem(mensagem);

            return ReadString();
        }

        public static string ReadString()
        {
            return Console.ReadLine();
        }

        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
