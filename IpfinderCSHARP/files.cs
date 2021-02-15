using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Learn
{
    class files
    {
        public string filefind(string file, string name)
        {
            FileStream fsSource = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsSource);
            string line;
            while ((line = sr.ReadLine()) != null)
                if (line.Contains(name))
                {
                    Console.WriteLine(line);
                }
            
            sr.Close();
            fsSource.Close();
            return line;
        }

        public void filewrite(string file, string name, string address)
        {
            FileStream fappend = File.Open(file, FileMode.Append);

            StreamWriter x = new StreamWriter(fappend);
            string full = $"{name} {address}";
            x.WriteLineAsync(full);

            x.Close();

        }
    }
}
