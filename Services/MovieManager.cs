using MovieApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
namespace MovieApp.Services
{
    public class MovieManager
    {
        public void Add(Movie obj)
        {
            string path = "C:\\Users\\narim\\Desktop\\MovieApp\\Data\\movie.json";

            using StreamReader sr = new StreamReader(path);


            string json;

            if (sr != null)
            {
                json = sr.ReadToEnd();
                List<Movie> list = JsonConvert.DeserializeObject<List<Movie>>(json);

                list.Add(obj);

                json = JsonConvert.SerializeObject(list, Formatting.Indented);

                sr.Close();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(json);
                }
            }
            else
            {

                List<Movie> list = new List<Movie>();

                list.Add(obj);

                json = JsonConvert.SerializeObject(list, Formatting.Indented);

                sr.Close();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(json);
                }
            }
        }
        public void Show(Movie obj)
        {
            string path = "C:\\Users\\narim\\Desktop\\MovieApp\\Data\\movie.json";

            using StreamReader sr = new StreamReader(path);


            string json;

            if (sr != null)
            {
                json = sr.ReadToEnd();
                
                Console.WriteLine(json);

                sr.Close();
            }
            else
            {
                Console.WriteLine("there is no data");
            }
        }
    }
}