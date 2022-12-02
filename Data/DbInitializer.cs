using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Mohammed",LastName="Loqman",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Ben",LastName="Short",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Derek",LastName="Peacock",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Priya",LastName="Day",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="yusuf",LastName="Shah",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Piggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Shaoib",LastName="Rehman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Uno",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="English",Credits=3},
            new Course{CourseID=4022,Title="Maths",Credits=3},
            new Course{CourseID=4041,Title="Science",Credits=3},
            new Course{CourseID=1045,Title="History",Credits=4},
            new Course{CourseID=3141,Title="Geogrophy",Credits=4},
            new Course{CourseID=2021,Title="PE",Credits=3},
            new Course{CourseID=2042,Title="Ict",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}