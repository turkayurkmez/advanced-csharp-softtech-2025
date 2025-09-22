using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    public interface IDataReader<out T>
    {
        //Problemin giderilmesi için T'nin covariance olduğunu söylemem gerekir. Böylelikle miras alanlar (derived) miras verene (base) dönüşebilir.
        T GetData();
        IEnumerable<T> GetAll();

    }

    public class ManagerReader : IDataReader<Manager>
    {
        public IEnumerable<Manager> GetAll()
        {
            return new List<Manager>
            {
                 new Manager{ Name="Yeliz", TeamSize=4},
                 new Manager{ Name="Zeynep", TeamSize=8}

            };
        }

        public Manager GetData()
        {
            return new Manager { Name = "Mehmet", TeamSize = 6 };
        }
    }

    public class DirectorReader : IDataReader<Director>
    {
        public IEnumerable<Director> GetAll()
        {
            return new List<Director>
            {
                new Director { Name = "Cüneyt", Department = "İK", TeamSize = 30 },
                new Director { Name = "Derya", Department = "Finans", TeamSize = 30 },

            };
        }

        public Director GetData()
        {
            return new Director { Name = "Cüneyt", Department = "İK", TeamSize = 30 };
        }
    }

    //Buraya dikkat!!! Problem alanı:

    public class ReportService
    {
        public void GenerateReport(IDataReader<Employee> reader)
        {
            var employees = reader.GetAll();
            foreach (var employee in employees) {
                Console.WriteLine($"Çalışan: {employee.Name}");
            }
        }
    }

}
