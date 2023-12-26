using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library1.Classes
{
    public class JsonFileManager
    {
        private string path;

        public JsonFileManager(string filePath)
        {
            path = filePath;
        }

        public List<Books> ReadBooks(List<Books> books)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                books = JsonConvert.DeserializeObject<List<Books>>(json);
            }
            return books;
        }

        public void SaveBook(List<Books> books)
        {
            var json = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText(path, json);
        }

    }
}
