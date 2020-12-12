using IRFVideogames.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace IRFVideogames
{
    public partial class Form1 : Form
    {
        BindingList<GameData> Games = new BindingList<GameData>();
        public Form1()
        {
            InitializeComponent();
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comm Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("Name");
                sw.Write(";");
                sw.Write("Copies Sold in Millions");
                sw.Write(";");
                sw.Write("Publisher");
                sw.Write(";");
                sw.Write("Developer");
                sw.Write(";");
                sw.Write("Release Date");
                sw.Write(";");
                sw.Write("Multiplayer");
                sw.Write(";");
                sw.Write("IGN Rating");
                sw.WriteLine();
                foreach (var jatek in Games)
                {
                    sw.Write(jatek.Name);
                    sw.Write(";");
                    sw.Write(jatek.CopiesSold);
                    sw.Write(";");
                    sw.Write(jatek.Publisher);
                    sw.Write(";");
                    sw.Write(jatek.Developer);
                    sw.Write(";");
                    sw.Write(jatek.ReleaseDate.ToString("yyyy/MM/dd"));
                    sw.Write(";");
                    sw.Write(jatek.Multiplayer);
                    sw.Write(";");
                    sw.Write(jatek.IGNRating);
                    sw.WriteLine();

                }
            }
               
        }
        Controller controller = new Controller();


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void controller1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void controller2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
        
    }
}
