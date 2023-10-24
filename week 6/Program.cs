//using System;
//using System.Collections.Generic;

//class Person
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Person> People = new List<Person>
//        {
//            new Person { Name = "Kamil", Surname = "Johnson", Age = 25 },
//            new Person { Name = "Alice", Surname = "Smith", Age = 30 },
//            new Person { Name = "John", Surname = "Ova", Age = 22 },
//            new Person { Name = "Sara", Surname = "Petrova", Age = 18 },
//            new Person { Name = "Kamil", Surname = "Silva", Age = 28 },
//            new Person { Name = "David", Surname = "Ova", Age = 35 },
//            new Person { Name = "Eva", Surname = "Koval", Age = 21 },
//        };

//        Console.WriteLine("Adı Kamil olan kişiler:");
//        foreach (var person in People)
//        {
//            if (person.Name == "Kamil")
//            {
//                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
//            }
//        }

//        Console.WriteLine("\nSoyadı 'ov' veya 'ova' ile biten kişiler:");
//        foreach (var person in People)
//        {
//            if (person.Surname.EndsWith("ov", StringComparison.OrdinalIgnoreCase) || person.Surname.EndsWith("ova", StringComparison.OrdinalIgnoreCase))
//            {
//                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
//            }
//        }

//        Console.WriteLine("\nYaşı 20 veya daha büyük kişiler:");
//        foreach (var person in People)
//        {
//            if (person.Age >= 20)
//            {
//                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Exam
//{
//    public string Subject { get; set; }
//    public int ExamDurationHours { get; set; }
//    public DateTime StartDate { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Exam> exams = new List<Exam>();

//       
//        exams.Add(new Exam
//        {
//            Subject = "Math",
//            ExamDurationHours = 3,
//            StartDate = DateTime.Now - TimeSpan.FromDays(7)
//        });

//        exams.Add(new Exam
//        {
//            Subject = "Physics",
//            ExamDurationHours = 2,
//            StartDate = DateTime.Now - TimeSpan.FromHours(3)
//        });

//        exams.Add(new Exam
//        {
//            Subject = "History",
//            ExamDurationHours = 1,
//            StartDate = DateTime.Now - TimeSpan.FromHours(2)
//        });

//       
//        Console.WriteLine("Son 1 hafta içindeki sınavlar:");
//        foreach (var exam in exams)
//        {
//            if ((DateTime.Now - exam.StartDate).TotalDays <= 7)
//            {
//                Console.WriteLine($"Ders: {exam.Subject}, Süre: {exam.ExamDurationHours} saat");
//            }
//        }

//  
//        Console.WriteLine("\n2 saatten uzun sınavlar:");
//        foreach (var exam in exams)
//        {
//            if (exam.ExamDurationHours > 2)
//            {
//                Console.WriteLine($"Ders: {exam.Subject}, Süre: {exam.ExamDurationHours} saat");
//            }
//        }

//     
//        Console.WriteLine("\nBaşlamış, ama bitmemiş sınavlar:");
//        foreach (var exam in exams)
//        {
//            if (exam.StartDate <= DateTime.Now)
//            {
//                Console.WriteLine($"Ders: {exam.Subject}, Süre: {exam.ExamDurationHours} saat");
//            }
//        }
//    }
//}
