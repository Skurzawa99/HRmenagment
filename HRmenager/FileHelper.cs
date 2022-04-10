using System.IO;
using Newtonsoft.Json;

namespace HRmenager
{
    public class FileHelper<T> where T : new()
    {
        private string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T employees)
        {
            var serializer = new JsonSerializer();

            using( var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, employees);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(_filePath))
            {
                var jsonReader = new JsonTextReader(streamReader);
                var employees = serializer.Deserialize<T>(jsonReader);
                streamReader.Close();
                return employees;
            }
        }
    }
}
