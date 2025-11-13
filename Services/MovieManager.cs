using MovieApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
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
        public void Add(List<Movie> movies)
        {
            string path = "C:\\Users\\II Novbe\\Source\\Repos\\Movieapp\\Data\\movie.json";

            List<Movie> list = new List<Movie>();

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    list = JsonConvert.DeserializeObject<List<Movie>>(json) ?? new List<Movie>();
                }
            }

       
            list.AddRange(movies);


            string updatedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(path, updatedJson);
        }
        public void Show()
        {
            string path = "C:\\Users\\II Novbe\\Source\\Repos\\Movieapp\\Data\\movie.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(json))
                    Console.WriteLine(json);
                else
                    Console.WriteLine("No data found.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}