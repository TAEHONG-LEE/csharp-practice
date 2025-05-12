using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main()
        {
            // 1. 학생 리스트 생성
            List<Student> students = new List<Student>
            {
                new Student("민정", 22, "20230001"),
                new Student("태홍", 25, "20220012"),
                new Student("지수", 24, "20210003"),
                new Student("성우", 21, "20230009")
            };

            // 2. 전체 학생 소개
            Console.WriteLine("📋 전체 학생 목록:");
            foreach (var s in students)
            {
                s.___();  // 자기소개 출력
            }

            // 3. 평균 나이 계산
            int totalAge = 0;
            foreach (var s in students)
            {
                totalAge += s.___;
            }

            double avg = (double)totalAge / students.Count;
            Console.WriteLine($"\n🎯 평균 나이: {avg:F1}세");

            // 4. 23세 이상 학생 출력
            Console.WriteLine("\n🧑‍🎓 23세 이상 학생:");
            foreach (var s in students)
            {
                if (s.___ >= 23)
                    s.___();
            }

            // 5. 콘솔 종료 대기
            Console.ReadLine();
        }
    }
}
