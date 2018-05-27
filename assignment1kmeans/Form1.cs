using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1kmeans
{
    public partial class Form1 : Form
    {
        public String filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filebrowser = new OpenFileDialog();
            filebrowser.ShowDialog();
            filepath = filebrowser.FileName;
            textBoxFilename.Text = filepath;
            ButtonRUN.Enabled = true;
            ButtonRUN.BackColor = Color.MediumPurple;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Dictionary<int,UserForKMeansWine> users = Clustering.parseintousers(textBoxFilename.Text);
            Tuple<float, List<Cluster>> results = Clustering.kmeans((int)numericUpDown2.Value, (int)numericUpDown1.Value, users);
            int currentcluster = 1;
            foreach(Cluster cluster in results.Item2)
            {
                string clustername = "cluster " + currentcluster;
                
                chart1.Series.Add(clustername);

                cluster.countamountofoffers().ToList().ForEach(x => chart1.Series[clustername].Points.AddY(x));
                string[] views = cluster.listofclustermember();
                listView1.Items.Add("Cluster " + currentcluster + ":");
                foreach (string view in views)
                {
                    listView1.Items.Add("user " + view + " part of cluster " + currentcluster);
                }


                currentcluster++;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            float[] set1 = { 6f , 4f};
            float[] set2 = { 3f, 8f};
            listView1.Items.Add(new ListViewItem(Clustering.calculateEuclidianDistance(set1, set2).ToString()));
             }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
