using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1kmeans
{
    class Cluster
    {
        public UserForKMeansWine currentcentroid;
        public List<UserForKMeansWine> clustermembers;


        public Cluster()
        {
            clustermembers = new List<UserForKMeansWine>();
        }
        public int getoffercount(int offer)
        {
            return clustermembers.Where(e => e.transactions[offer]).ToList().Count();
        }

        public string[] toStringarray()
        {
            int products = 31;
            string[] returnstrings = new string[products + 1];
            while (products != 0)
            {
                returnstrings[products] = "offer " + (products + 1).ToString() + " taken by " + getoffercount(products).ToString() + " in cluster ";
                products--;
            }
            return returnstrings;
        }
        public string[] listofclustermember()
        {
            string[] returner = new string[clustermembers.Count];
            int index = 0;
            foreach (UserForKMeansWine member in clustermembers)
            {
                returner[index] = member.number.ToString();
                index++;
            }
            return returner;
        }
        public int[] countamountofoffers()
        {
            int products = 31;
            int[] returnints = new int[products + 1];
            while (products != 0)
            {
                returnints[products] = getoffercount(products);
                products--;
            }
            return returnints;
        }
        public void updatecentroid()
        {
            Dictionary<int,float> averages = new Dictionary<int, float>();
            int usercount = 0;
            foreach(UserForKMeansWine user in clustermembers)
            {
                usercount++;
                foreach(KeyValuePair<int,Boolean> rating in user.transactions)
                {
                    if(!averages.ContainsKey(rating.Key))
                    {
                        averages.Add(rating.Key, Convert.ToInt16(rating.Value));
                    }
                    else
                    {
                        averages[rating.Key] = (averages[rating.Key] + Convert.ToInt16(rating.Value));
                    }
                }
            }
            Dictionary<int, Boolean> newcentroidcoords = new Dictionary<int, bool>();
            
            foreach (KeyValuePair<int,float> pair in averages)
            {
                Boolean result = (Math.Round(pair.Value / usercount)==1);
                newcentroidcoords.Add(pair.Key, result);
            }
            currentcentroid = new UserForKMeansWine(int.MaxValue);
            currentcentroid.transactions = newcentroidcoords;
        }

    }
}
