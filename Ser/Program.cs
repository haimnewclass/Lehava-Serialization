using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using System.Text.Json;
namespace Ser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[10];

            Person p = new Person() { 
                Address="Golan 19 BS",
                Age = 22,
                Id = "234234234",
                Name = "Moshe"                
            };

            arr[0] = p;
            arr[1] = p;
            arr[2] = p;

            p.AdditionalData = new Data();
            p.AdditionalData.Num = 345345;
            p.AdditionalData.Str = "AAAAAA";

           
            System.Collections.Generic.Dictionary<string, Person> tbl = new Dictionary<string, Person>();

            tbl["111"] = p;
            tbl["222"] = p;
            tbl["333"] = p;

            string str = JsonSerializer.Serialize(tbl);

            // Save str into file, DB, WS, API
            //string s = @"c:\aaa\n\rbbb\ntccc"; verbatim
            System.IO.File.WriteAllText(@"Data.txt", str);


            tbl = JsonSerializer.Deserialize<Dictionary<string, Person>>(str);

        }
    }
}
