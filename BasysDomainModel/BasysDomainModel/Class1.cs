using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Basys.Model.Workplan;
using Newtonsoft.Json;

namespace BasysDomainModel
{
    public class Test
    {

        public void TestSerialization()
        {
            WorkplanInstance s = new WorkplanInstance()
            {
                ProductInstanceId = Guid.NewGuid().ToString(),
                WorkstepInstances = {
                    new WorkstepInstance()
                    {
                        Id = Guid.NewGuid().ToString(),
                        IsAutomatic = true,
                        Name = "Automatischer Arbeitsschritt",
                        StationId = "5"
                    },
                    new WorkstepInstance()
                    {
                        Id = Guid.NewGuid().ToString(),
                        IsAutomatic = false,
                        Name = "Manueller Arbeitsschritt",
                        StationId = "5"
                    }
                } 
            };

            string json = JsonConvert.SerializeObject(s,Formatting.Indented);

            Console.WriteLine(json);

            WorkplanInstance s2 = JsonConvert.DeserializeObject<WorkplanInstance>(json);

            string json2 = JsonConvert.SerializeObject(s2, Formatting.Indented);

            Console.WriteLine(json2);

            if (json.Equals(json2))
                Console.WriteLine("Strings match!");
            else
                Console.WriteLine("Strings DO NOT match!");
        }


        static int Main(string[] args)
        {
            Test test = new Test();
            test.TestSerialization();
            Console.ReadLine();

            return 0;
        }
    }
}
