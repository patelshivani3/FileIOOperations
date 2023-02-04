using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to File IO Operation");
            Console.WriteLine("\n1.Binary Serialization\n2.Binary DeSerialization");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //Binary Serialization Operation
                case 1:
                    BinaryIOOperation.BinaryDataSerialization();
                    break;
                //Binary DeSerialization Operation
                case 2:
                    BinaryIOOperation.BinaryDataDeSerialization();
                    break;
                default:
                    Console.WriteLine("Choose from given option Only");
                    break;
            }
            Console.ReadLine();
        }
    }
}
