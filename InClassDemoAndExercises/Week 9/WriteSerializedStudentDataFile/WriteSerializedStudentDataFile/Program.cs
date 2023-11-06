using System;
using System.IO;
using System.Text.Json;

namespace WriteSerializedStudentDataFile
{

    public class Program
    {
        static void Main(string[] args)
        {
            var data = new SchoolDataSource();
            var collegePrograms = data.GenerateCollegePrograms();

            string jsonString = JsonSerializer.Serialize(collegePrograms);

            string filePath = "c:\\temp\\collegePrograms.json";

            File.WriteAllText(filePath, jsonString);

            #region snippets
            //var serializationOptions = new JsonSerializerOptions()
            //{
            //    WriteIndented = true
            //};

            ////[JsonPropertyOrder(2)]
            #endregion
        }
    }
}
