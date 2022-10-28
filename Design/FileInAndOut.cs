using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    class FileInAndOut<T>
    {
        public List<T> ReadingFromFile(string FilePath)
        {
            if (FilePath == "")
            {
                return null;
            }

            var file = new FileInfo(FilePath);
            if (file.Exists == false)
            {
                return null;
            }
            if (file.Length == 0)
            {
                return null;
            }

            List<T> list;
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
                {
                    list = (List<T>)formatter.Deserialize(fs);
                }
            }
            catch 
            {              
                return null;
            }
          
            return list;
        }
        public bool WritingToFile(string path, List<T> list)
        {
            if (path == "")
            {
                return false;
            }

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }
            }
            catch
            {
                return false;
            }
           
            return true;
        }

    }
}

