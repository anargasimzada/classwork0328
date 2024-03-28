using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Moduls
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduated;

        public Student(string name,string surname,string group,int point)
        {
             Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = false;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Group} {Point}");
        }
        public void CheckGraduation()
        { 
            
            if (Point<65) 
            {
                Console.WriteLine("telebe mezun olmayib");
            }
            else
            {
                Console.WriteLine("telebe mezun olub");
            }
                
        }

        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("yoxdur");
            }
            else if (Point>=65 && Point < 80)
            {
                Console.WriteLine("adi");
            }
            else if(Point>=80 && Point < 90)
            {
                Console.WriteLine("sheref");
            }
            else
            {
                Console.WriteLine("yuksek sheref");
            }
        }

    } 
    
}
