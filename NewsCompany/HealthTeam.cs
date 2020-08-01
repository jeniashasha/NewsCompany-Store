using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
  internal class HealthTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            Console.WriteLine("Coronovirus is defeated");
        }
        internal override void AddStyle()
        {
            Console.WriteLine("research article");
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
