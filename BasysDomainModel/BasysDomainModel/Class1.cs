using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Basys;
using Newtonsoft.Json;
using Basys.Model.Domain;

namespace BasysDomainModel
{
    public class Test
    {

        public void TestSerialization()
        {
            Workplan s = new Workplan()
            {
                ProductVariantId = Guid.NewGuid().ToString(),
                //Worksteps = {
                //    new Workstep()
                //    {
                //        Duration = 10,
                //        Id = Guid.NewGuid().ToString(),
                //        Bom = new BOM()
                //        {
                //            Enties =
                //            {
                //                Amount = 4, 
                //                MaterialId = Guid.NewGuid().ToString(),
                //            }
                //        }
                //    }
                //} 
            };

            string json = JsonConvert.SerializeObject(s,Formatting.Indented);

            Console.WriteLine(json);

            Workplan s2 = JsonConvert.DeserializeObject<Workplan>(json);

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
