using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class PoliticsTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            Console.WriteLine("Kanye West is the new President of the USA");
        }
        internal override void AddStyle()
        {
            Console.WriteLine("column");
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
