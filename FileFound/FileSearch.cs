using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFound
{
    public  class FileSearch
    {
        public bool FindLogFile(long filebyte) {

            //FileDataObject obj = new FileDataObject();//class find files in the system
            TestDataObject obj = new TestDataObject();//cap or dummy for tests

            List<long> files = obj.GetFileslist();//getting list of file length

            foreach (var file in files)
            {
                if (file == filebyte)
                {
                    return true;
                }
            }
            return false;

        }


    }
}
