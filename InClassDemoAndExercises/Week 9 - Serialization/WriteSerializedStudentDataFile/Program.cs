using System;
using System.IO;
using System.Text.Json;

namespace WriteSerializedStudentDataFile
{

    public class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new SchoolDataSource();
            var collegePrograms = dataSource.GenerateCollegePrograms();

            var serializerOptions = new JsonSerializerOptions()
            {
                WriteIndented = true     
            };

            var jsonString = JsonSerializer.Serialize(collegePrograms, serializerOptions);

            var filePath = "c:\\temp\\collegePrograms.json";

            File.WriteAllText(filePath, jsonString);

            Console.WriteLine("Open file!");
            Console.ReadLine();
            #region snippets
            //var data = new SchoolDataSource();
            //var collegePrograms = data.GenerateCollegePrograms();

            //string jsonString = JsonSerializer.Serialize(collegePrograms);

            //string filePath = "c:\\temp\\collegePrograms.json";

            //File.WriteAllText(filePath, jsonString);
            //var serializationOptions = new JsonSerializerOptions()
            //{
            //    WriteIndented = true
            //};

            ////[JsonPropertyOrder(2)]
            #endregion
        }
    }
}
