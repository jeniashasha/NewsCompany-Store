using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            Console.WriteLine("Madonna has a new boyfriend");
        }
    }
}
