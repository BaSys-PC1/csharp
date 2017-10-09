using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basys.Model.Base
{
    public partial class Entity
    {
        public Entity()
        {
            Metadata = new Metadata()
            {
                Creator = "me",
                CreationDate = DateTime.Now,
                ExpiryDate = DateTime.Now.AddHours(1)
            };
        }
    }
}
