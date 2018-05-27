using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace assignment1kmeans
{
    static class Clustering
    {
        public static Dictionary<int,UserForKMeansWine> parseintousers(String filepath)
        {
            Dictionary<int, UserForKMeansWine> users = new Dictionary<int, UserForKMeansWine>();

            using (TextFieldParser parser = new TextFieldParser(filepath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                int currentitem = 0;
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    int currentuser = 0;
                    
                    foreach (string field in fields)
                    {
                        if(! users.ContainsKey(currentuser))
                        {
                            users.Add(currentuser, new UserForKMeansWine(currentuser));
                        }
                        Boolean result = true;
                        if (field.Equals("0"))
                        {
                            result = false;
                        }
                        users[currentuser].AddTransaction(currentitem, result);
                        currentuser++;
                    }
                    currentitem++;
                }
            }
                      
            return users;
        }
        public static Tuple<float,List<Cluster>> kmeans(int iterations, int clusters, Dictionary<int, UserForKMeansWine> users)
        {
            Tuple<float, List<Cluster>> highestresult = new Tuple<float, List<Cluster>>(0f,null);
            while (iterations != 0)
            {
                Tuple<float,  List<Cluster>>  iterationresult = kmeaniteration(clusters, users,initialCentrioidSelection.RandomUser);

                if (highestresult.Item1 < iterationresult.Item1)
                {
                    highestresult = iterationresult;
                }
                iterations--;
            }

            return highestresult;
        }

        public static Tuple<float, List<Cluster>> kmeaniteration(int clusters, Dictionary<int, UserForKMeansWine> users, initialCentrioidSelection selectiontypes)
        {
            List<Cluster> listofclusters = initiateClusters(clusters, selectiontypes, users);
            foreach (KeyValuePair<int,UserForKMeansWine> user in users)
            {
                try
                {
                    Cluster usercluster = getClusterWithClosestCentroidForUser(listofclusters, user.Value);
                    usercluster.clustermembers.Add(user.Value);
                    
                }catch(ArgumentException e)
                {
                    System.Console.Out.Write(e.Message);
                    MessageBox.Show("e.message");
                }
                

            }
            foreach (Cluster cluster in listofclusters)
            {
                cluster.updatecentroid();
            }
            return new Tuple<float,  List<Cluster>>(2f, listofclusters);
        }
        public static Cluster getClusterWithClosestCentroidForUser(List<Cluster> clusters, UserForKMeansWine user)
        {
            float lowestdistance = float.PositiveInfinity;
            Cluster currentcluster = null;
            foreach (Cluster cluster in clusters)
            {
                float currentdistance = user.distancebetweenthisanduser(cluster.currentcentroid);
                if(currentdistance < lowestdistance)
                {
                    lowestdistance = currentdistance;
                    currentcluster = cluster;
                }
            }
            if(currentcluster == null)
            {
                throw new ArgumentException("No clusters found to compute");
            }
            return currentcluster;
        }
        public static List<Cluster> initiateClusters(int amount,initialCentrioidSelection selectiontype, Dictionary<int, UserForKMeansWine> users)
        {
            Random picker = new Random();
            List<Cluster> returnlist = new List<Cluster>();
            while(amount != 0)
            {
                Cluster clusterconstruct = new Cluster();
                if(selectiontype == initialCentrioidSelection.RandomUser)
                {
                    int randomuser = picker.Next(users.Count);
                    clusterconstruct.currentcentroid = users[randomuser];

                }
                returnlist.Add(clusterconstruct);
                amount--;
            }
            return returnlist;
        }

        public static float calculateEuclidianDistance(float[] set1, float[] set2)
        {
            int incr = 0;
            double sum = 0f;
            while (incr != set1.Count())
            {
                float innerresult = (set1[incr] - set2[incr]);
                sum = sum +  Math.Pow(innerresult,2);
                incr++;
            }
            return (float)Math.Pow(sum, 0.5);

        }
    }
    public enum initialCentrioidSelection
    {
        RandomPoints,
        RandomUser,
        Test
    }


}
