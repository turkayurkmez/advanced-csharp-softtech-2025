using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    //in: Contravarience, parametre 
   public interface IDataWriter<in T>
    {
        void SaveData(T data);
        bool ValidateData(T data);
      //  T Sample();
        void SaveAll(IEnumerable<T> data);
    }

    public class EmployeeValidator : IDataWriter<Employee>
    {
        public void SaveAll(IEnumerable<Employee> data)
        {
            foreach (var item in data)
            {
                SaveData(item);
            }
        }

        public void SaveData(Employee data)
        {
            Console.WriteLine($"{data.Name} kaydedildi");
        }

        public bool ValidateData(Employee data)
        {
            return !string.IsNullOrEmpty(data.Name);
        }
    }

    public class ManagerService
    {
        public void ProcessManager(Manager manager, IDataWriter<Manager> writer)
        {
            if (writer.ValidateData(manager))
            {
                writer.SaveData(manager);
                Console.WriteLine($"Yönetici işlemi gerçekleşti: {manager.Name}");
            }
        }
    }
}
