using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with object cloning");
            Point p1 = new Point(50, 50, "Where Are You");
            Point p2 = p1;
            p1.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            //notice that clone() returns a plain copy type
            //you  must perform explicit cast to obtain the derirved type
            Console.WriteLine("clone p3 and store new point in p4");
            Point p3 = new Point(20, 20,"Where are you");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification");
            Console.WriteLine("p3:{0}, p4: {1}", p3, p4);
            p4.desc.PetName = "My new point";
            p4.X = 9;
            Console.WriteLine("\n Changed p4.desc.PetName and p4.x");
            Console.WriteLine("After modification");
            Console.WriteLine("p3:{0}, p4: {1}", p3, p4);
            Console.WriteLine(p4);

            //change p4.x will not change p3.x
            //p4.X = 0;
            //Console.WriteLine(p3);
            //Console.WriteLine(p4);

            Console.ReadLine();


        }
    }
}
