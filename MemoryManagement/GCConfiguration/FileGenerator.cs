using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCConfiguration
{
    public class FileGenerator : IDisposable
    {

        public FileStream FileStream { get; set; }

        public void CreateFile()
        {
            
        }

        public void Dispose()
        {
            //complex nesneleri yok et....
            FileStream.Dispose();
            GC.SuppressFinalize(this);
        }


        //~FileGenerator()
        //{
        //    FileStream.Close();
        //    FileStream.Dispose();

        //}
    }
}
