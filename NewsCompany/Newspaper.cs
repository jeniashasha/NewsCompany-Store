using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Newspaper
    {
        private string[] _stories = new string[] { "politicStory", "healthStory", "gossipStory" };
        private float price;
        public static object newspaper;

        public string[] GetStories()
        {
            return this._stories;
        }
        public void SetStories(string [] _newstories) 
        {
            this._stories = _newstories;
        }
        public float GetPrice()
        {
            return this.price;
        }
        public void SetPrice(float newPrice)
        {
            if (newPrice > 0)
            {
                this.price = newPrice;

            }
            else
            {
                Console.WriteLine("illegal price");
            }
            
        }
        public void Read()
        {
            Console.WriteLine($"Reading {_stories}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} sories : {_stories}, price : {price} ";
        }
    }
}
