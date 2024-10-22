using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFound
{
    internal class TestDataObject
    {
        public List<long> GetFileslist()
        {
            List<long> list = new List<long>();
            list.Add(1000);
            list.Add(999999);
            list.Add(2340234902);
            list.Add(4389598389533535);
            return list;
        }
    }
}
