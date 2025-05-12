using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Student
    {
        // 1) 자동 구현 프로퍼티
        public string ___ { get; set; }

        // 2) 일반 프로퍼티 (0 이상만 허용)
        private int ___;
        public int ___
        {
            get { return ___; }
            set
            {
                if (value >= 0)
                    ___ = value;
                else
                    Console.WriteLine("나이는 0 이상이어야 합니다!");
            }
        }

        // 3) 읽기 전용 프로퍼티
        public string ___ { get; private set; }

        // 4) 생성자
        public Student(string name, int age, string studentId)
        {
            ___ = name;
            ___ = age;
            ___ = studentId;
        }

        // 5) 출력 메서드
        public void ___()
        {
            Console.WriteLine($"이름: {___}, 나이: {___}, 학번: {___}");
        }
    }
}
