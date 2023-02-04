using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class BinaryIOOperation
    {
        //Serialize method is use for creating data
        public static void BinaryDataSerialization()
        {
            try
            {
                string path = @"C:\Users\shivp\source\repos\FileIOOperations\FileIOOperations\Files\BinaryData.txt";
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 1, Name="Yash", Age= 22},
                    new Contact() {Id = 2, Name="Neel", Age= 24},
                    new Contact() {Id = 3, Name="Siya", Age= 27},
                };
                BinaryFormatter binary = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                binary.Serialize(stream, contact);
                stream.Close();
                Console.WriteLine("Binary Serialization Completed Succesfully");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //deserialize method is use for reading data
        public static void BinaryDataDeSerialization()
        {
            try
            {
                string path = @"C:\Users\shivp\source\repos\FileIOOperations\FileIOOperations\Files\BinaryData.txt";
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 1, Name="Yash", Age= 22},
                    new Contact() {Id = 2, Name="Neel", Age= 24},
                    new Contact() {Id = 3, Name="Siya", Age= 27},
                };
                BinaryFormatter binary = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                List<Contact> listOfContact = (List<Contact>) binary.Deserialize(stream);
                stream.Close();
                foreach (Contact contact1 in listOfContact)
                {
                    Console.WriteLine(contact1);
                }
                Console.WriteLine("Binary Deserialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
