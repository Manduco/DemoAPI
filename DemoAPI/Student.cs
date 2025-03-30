using System.Collections.Generic;

namespace DemoAPI
{
    public class Student
    {
        private static Random _r = new Random();

        public int Id { get; set; }
        public String Name { get; set; } = "";
        public float TotalScore { get; set; }
        public String CurrentGrade
        {
            get
            {
                if (TotalScore > 90.0) return "A";
                if (TotalScore > 80.0) return "B";
                if (TotalScore > 70.0) return "C";
                if (TotalScore > 60.0) return "D";
                return "F";
            }
        }

        public Student(int id, string name, float totalScore)
        {
            Id = id;
            Name = name;
            TotalScore = totalScore;
        }

        private static int _randomScore() => _r.Next(58, 100);
        public static List<Student> GetStudents() => new List<Student>
        {
            new Student(1234, "Charley Oliver", _randomScore()),
            new Student(2222, "Augusta Sheppard", _randomScore()),
            new Student(2234, "Darcie Parent", _randomScore()),
            new Student(3210, "Emile Gorbold", _randomScore()),
            new Student(3456, "Vicki Glover", _randomScore()),
            new Student(4444, "Tera Hambleton", _randomScore()),
            new Student(4567, "Domenic Cash", _randomScore()),
            new Student(4680, "Marcy Salvage", _randomScore())
        };

        public static List<Student> Students = new List<Student>();
        private static int _nextId = 5000;

        public static Student AddStudent(string name, float score)
        {
            var student = new Student(_nextId++, name, score);
            Students.Add(student);
            return student;
        }


    }
}
