using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students = new List<Student> ();

        private IReadOnlyCollection<string> sources = new ReadOnlyCollection<string>(new List<string>());

        public void AddSource(string source)
        {
            

        }

        public void AddStudent(Student student) => students.Add(student);

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }

            //return students.GetEnumerator();
        }

        public List<Student> GetStudents() => students;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
