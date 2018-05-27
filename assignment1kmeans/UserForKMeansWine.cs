using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1kmeans
{
    class UserForKMeansWine
    {
        public Dictionary<int, Boolean> transactions;
        public int number;
        public UserForKMeansWine(int number)
        {
            transactions = new Dictionary<int, bool>();
            this.number = number;
        }

        public void AddTransaction(int item, Boolean ordered)
        {
            transactions.Add(item, ordered);
        }
        public float distancebetweenthisanduser(UserForKMeansWine user2)
        {
            float[] set1 = new float[32];
            float[] set2 = new float[32];
            foreach(KeyValuePair<int,Boolean> transaction in transactions)
            {
                set1[transaction.Key] = Convert.ToInt16(transactions[transaction.Key]);
                set2[transaction.Key] = Convert.ToInt16(user2.transactions[transaction.Key]);
            }
            return Clustering.calculateEuclidianDistance(set1, set2);
        }
    }
}
