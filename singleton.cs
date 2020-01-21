using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton SingletonObject = Singleton.GetObject();
            SingletonObject.Print("Hello World");
            Console.ReadLine();
        }
    }

    public class Singleton
    {
        private static Singleton _obj;
        private Singleton()
        {
 
        }
        public static Singleton GetObject()
        {
            if (_obj == null)
            {
                _obj = new Singleton();
            }
            return _obj;
        }
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }