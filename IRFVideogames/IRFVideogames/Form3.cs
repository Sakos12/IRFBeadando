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

    public partial class Form3 : Form
    {
        BindingList<GameData> Games = new BindingList<GameData>();
        public Form3()
        {
            InitializeComponent();
            LoadGameDataXML();
            dataGridView1.DataSource = Games;
            Evszamlista()
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
        private void Evszamlista()
        {
            for (int i = 2000; i <= 2020; i++)
            {
                gamelistBox.Items.Add(i);
            }
        }

        private void gamenamebox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gamelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var datum = gamelistBox.SelectedItem.ToString();
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
                if (game.ReleaseDate.ToString() == datum)
                {
                    Games.Add(game);
                }

            }
        }
    }
}
