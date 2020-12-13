using IRFVideogames.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                 if (game.IGNRating < 8.0 )
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
    }
}
