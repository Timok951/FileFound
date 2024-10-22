namespace FileFound
{
    internal class FileFioundBytes
    {
        static void Main(string[] args)
        {
            long filbytes = 1000;//bytes for file

            FileSearch mgr = new FileSearch();//class filesearch

            if (mgr.FindLogFile(filbytes))
            {
                Console.WriteLine("File {0} find!", filbytes);
            }

            else {
                Console.WriteLine("File {0} not found !", filbytes);
            
            }
            Console.ReadKey();
        }



    }
}
