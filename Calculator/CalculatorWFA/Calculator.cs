using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNum
{
    public class Calculator
    {
        const string PATH = "Save.dat";
        public Calculator()
        {

        }
        public void Save(string s)
        {
            if (!File.Exists(PATH))
            {
                File.WriteAllText(PATH, "");
            }
            File.AppendAllText(PATH, s+"\n");
        }
        public void Load()
        {
            if (File.Exists(PATH))
            {
                string[] s = File.ReadAllLines(PATH);
                s.Reverse();
                foreach (var item in s)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Add(double x, double y)
        {
            string result = String.Format("{0} + {1} = {2}", x, y, x + y);
            Save(result);
            //Console.WriteLine(result);
        }
        public void Sub(double x, double y)
        {
            string result = String.Format("{0} - {1} = {2}", x, y, x - y);
            Save(result);
            //Console.WriteLine(result);
        }
        public void Mult(double x, double y)
        {
            string result = String.Format("{0} * {1} = {2}", x, y, x * y);
            Save(result);
            //Console.WriteLine(result);
        }
        public void Div(double x, double y)
        {
            string result = String.Format("{0} / {1} = {2}", x, y, x / y);
            Save(result);
            //Console.WriteLine(result);
        }
        public void Math()
        {
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Error. Try again");
            }
            char choose;
            while (!char.TryParse(Console.ReadLine(), out choose))
            {
                Console.WriteLine("Error. Try again");
            }
            double y;
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Error. Try again");
            }
            switch (choose)
            {
                case '+':
                    Add(x, y);
                    break;
                case '-':
                    Sub(x, y);
                    break;
                case '*':
                    Mult(x, y);
                    break;
                case '/':
                    Div(x, y);
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculator c = new Calculator();
    //        c.Load();
    //        while (true)
    //        {
    //            c.Math();
    //        }
    //        Console.ReadKey();
    //    }
    //}
}
