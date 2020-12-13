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

namespace IRFVideogames
{
    public partial class Form2 : Form
    {
        BindingList<GameData> Games = new BindingList<GameData>();
        public Form2()
        {
            InitializeComponent();
            LoadGameDataXML();
            dataGridView1.DataSource = Games;
        }
        private void LoadGameDataXML()
        {
            var xml = new XmlDocument();
            xml.Load("videogames.xml");
            foreach (XmlElement element in xml.DocumentElement)
            {
                var game = new GameData();

                var firstchildElement = (XmlElement)element.ChildNodes[0];
                game.Name = firstchildElement.InnerText;
                var secondchildElement = (XmlElement)element.ChildNodes[1];
                game.CopiesSold = double.Parse(secondchildElement.InnerText);
                var thirdchildElement = (XmlElement)element.ChildNodes[2];
                game.Publisher = thirdchildElement.InnerText;
                var fourthchildElement = (XmlElement)element.ChildNodes[3];
                game.Developer = fourthchildElement.InnerText;
                var fifthchildElement = (XmlElement)element.ChildNodes[4];
                double d = double.Parse(fifthchildElement.InnerText);
                game.ReleaseDate = DateTime.FromOADate(d);
                var sixthchildElement = (XmlElement)element.ChildNodes[5];
                game.Multiplayer = bool.Parse(sixthchildElement.InnerText);
                var seventhchildElement = (XmlElement)element.ChildNodes[6];
                game.IGNRating = double.Parse(seventhchildElement.InnerText);
                Games.Add(game);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<GameData> GamestoRemove = new BindingList<GameData>();
            foreach (GameData game in Games)
            {
                if (game.IGNRating < 9.0)
                {
                    GamestoRemove.Add(game);
                }
            }
            foreach (GameData game in GamestoRemove)
            {
                Games.Remove(game);
            }
            dataGridView1.DataSource = Games;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadGameDataXML();
           
            dataGridView1.DataSource = Games;
        }

        private void datebtn_Click(object sender, EventArgs e)
        {
            BindingList<GameData> GamestoRemove = new BindingList<GameData>();
            DateTime date = new DateTime(2015, 1, 1, 0, 0, 0);
            foreach (GameData game in Games)
            {
                int hasonlit = DateTime.Compare(game.ReleaseDate, date);
                if (hasonlit<0)
                {
                    GamestoRemove.Add(game);
                }
            }
            foreach (GameData game in GamestoRemove)
            {
                Games.Remove(game);
            }
            dataGridView1.DataSource = Games;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BindingList<GameData> GamestoRemove = new BindingList<GameData>();
            DateTime date = new DateTime(2015, 1, 1, 0, 0, 0);
            foreach (GameData game in Games)
            {
                if (!game.Multiplayer)
                {
                    GamestoRemove.Add(game);
                }
            }
            foreach (GameData game in GamestoRemove)
            {
                Games.Remove(game);
            }
            dataGridView1.DataSource = Games;
        }

        private void home1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
