using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionIntro
{
    public class Personel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private decimal salary;

        public void Work()
        {
            Console.WriteLine($"{Name} isimli çalışan iş başında");
        }

        private void secretMethod()
        {
            Console.WriteLine("Bu private bir metot!");
        }
    }
}
