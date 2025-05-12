using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice._250512.Practice2_SearchByName
{
    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { ___ = "민정", ___ = 22, ___ = "20230001" },
                new Student { ___ = "태홍", ___ = 25, ___ = "20220002" },
                new Student { ___ = "지수", ___ = 24, ___ = "20210003" }
            };

            Console.Write("검색할 이름: ");
            string input = Console.ReadLine();

            Student found = students.Find(s => s.___ == input);
            if (found != null)
            {
                found.___();
            }
            else
            {
                Console.WriteLine("해당 학생 없음");
            }
        }
    }
}