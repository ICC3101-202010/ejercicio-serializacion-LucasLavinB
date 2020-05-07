using System;

namespace SerializacionLucasLavin
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            string[] Menu = new string[] { "1.Agregar persona", "2.Ver lista de personas", "3.Salir" };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Para elegir una opcion del menu, ingrese el numero de la opcion a elegir.");
                for (int i = 0; i < Menu.Length; i++)
                {
                    if (option == 1)
                    {
                        public string objeto = Console.ReadLine();
                        public string nombre_objeto = Console.ReadLine();
                        public string apellido_objeto = Console.ReadLine();
                        public string edad_objeto = Console.ReadLine();
                        Person objeto = new Person(string nombre_objeto, string apellido_objeto, int edad_objeto();
                        Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, persona1);
                        stream.Close();
                    }
                    if (option == 2)
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Console.WriteLine(stream);
                        stream.Close();
                    }
                    if (option == 3)
                    {
                        Environment.Exit(0);
                    }
                }
        }
    }
}
