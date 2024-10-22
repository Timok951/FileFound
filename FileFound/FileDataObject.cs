using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileFound
{
    internal class FileDataObject
    {
        public List<long> GetFileslist()
        {
            string path = "C:\\Users\\timof\\Zomboid"; //writing paths
            List<long> filebytes = new List<long>();//we will form list with bytes of ourfiles
            DirectoryInfo dir = new DirectoryInfo(path);//get the directory info in path
            FileInfo[] files = dir.GetFiles();//Get all object files

            foreach (FileInfo file in files)//foreach add file
            {
                filebytes.Add(file.Length);//add our objects in list
            }

            return filebytes;

        }
    }
}
