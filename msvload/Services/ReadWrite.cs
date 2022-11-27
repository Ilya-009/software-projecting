using msvload.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace msvload.Services
{
    public class ReadWrite
    {
        private static string _folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WordRemmember";

        //Set data to file (folder = *\Documents\WordRemmember)
        public static void SetDataToFile(string path, string[] Text) //Text - colletion of lines
        {
            StreamWriter StreamWriter;
            string[] line_temp;

            if (!File.Exists(path))
            {
                Directory.CreateDirectory(_folder);
            }

            StreamWriter = new StreamWriter(path, true, Encoding.UTF8);

            if (Text.Length != 0)
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    line_temp = Text[i].Split('-');
                    line_temp[0] = line_temp[0].Trim().Substring(0, 1).ToUpper() + line_temp[0].Trim().Remove(0, 1);
                    line_temp[1] = line_temp[1].Trim().Substring(0, 1).ToUpper() + line_temp[1].Trim().Remove(0, 1);
                    StreamWriter.WriteLine(line_temp[0] + " - " + line_temp[1]);
                }
            }
            StreamWriter.Dispose();
        }

        //File writer in List of models
        public static void SetDataToFile(List<ReadDataModel> data)
        {
            string filePath = Path.Combine(_folder, "data.txt");
            StreamWriter streamWriter;

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(_folder))
                {
                    Directory.CreateDirectory(_folder);
                }
                File.Create(filePath).Close();
            }

            streamWriter = new StreamWriter(filePath, true, Encoding.UTF8);

            for (int i = 0; i < data.Count; i++)
            {
                streamWriter.Write(data[i].Key + " - " + data[i].Answer);
            }

            streamWriter.Close();
            streamWriter.Dispose();
        }

        public static List<ReadDataModel> Compare(List<ReadDataModel> data, List<ReadDataModel> _out)
        {
            List<ReadDataModel> results;
            if (_out.Count > 0)
            {
                results = new List<ReadDataModel>();

                foreach (var el in _out)
                {
                    if (!HasInList(data, el))
                    {
                        results.Add(el);
                    }
                }
                if (results.Count != 0)
                    return results;
                else
                    return null;
            }
            else { return null; }

        }

        private static bool HasInList(List<ReadDataModel> elems, ReadDataModel element)
        {
            var found = elems.Find(e => e.Key.Contains(element.Key));
            if (found == null)

                return false;
            else
                return true;

        }

        public static async Task<List<ReadDataModel>> ReadData(string path)
        {
            if (!File.Exists(path))
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                File.Create(path).Close();
                return new List<ReadDataModel>();
            }

            StreamReader StreamReader = new StreamReader(path, Encoding.UTF8);
            string text = await StreamReader.ReadToEndAsync();
            text.Trim().Replace(" ", string.Empty);

            StreamReader.Close();
            StreamReader.Dispose();
            

            if (text != string.Empty)
            {
                //readDataModels = new List<ReadDataModel>();
                //string[] words = text.Split('\n');
                //string[] line_temp;

                //for (int i = 0; i < words.Length; i++)
                //{
                //    if (words[i] != string.Empty)
                //    {
                //        line_temp = words[i].Split('-');
                //        ReadDataModel model = new ReadDataModel(line_temp[0], line_temp[1]);
                //        readDataModels.Add(model);
                //    }
                //}

                //return readDataModels;

                return ConvertDataToList(text);

            }
            else
                return new List<ReadDataModel>();

        }

        public static List<ReadDataModel> ConvertDataToList(string value)
        {
            List<ReadDataModel> readDataModels = new List<ReadDataModel>();

            string[] words = value.Split('\n');
            string[] lineTemp;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != string.Empty)
                {
                    lineTemp = words[i].Split('-');
                    ReadDataModel model = new ReadDataModel(lineTemp[0], lineTemp[1]);
                    readDataModels.Add(model);
                }
            }
            return readDataModels;
        }
        
        public static List<ReadDataModel> GetDataFromWeb(string fileName)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                Task<string> res = httpClient.GetStringAsync("https://motorspace.000webhostapp.com/" + fileName + ".txt");
                return ConvertDataToList(res.Result);
            }
            catch
            {
                return null;

                throw;
            }
        }

    }
}
