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
using System.Xml.Linq;


namespace Hava_Durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string api = "1d343ef75913b686e9865c2c46b6462d";

        private const string baglanti = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&mode=xml&lang=tr&units=metric&appid=" + api;

        private void Form1_Load(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToShortDateString();

            XDocument hava = XDocument.Load(baglanti);

            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            label_derece.Text = sicaklik.ToString() + "°";

            var durum = hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;

            label_durum.Text = durum.ToString();

            var yer = hava.Descendants("city").ElementAt(0).Attribute("name").Value;

            label_yer.Text = yer.ToString();

            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;

            label_nem.Text= nem + "%";


            if (durum.Contains("clouds") == true)
            {
                picture_bulutlu.Visible = true;
            }
            else if (durum.Contains("sun") == true)
            {
                picture_bulutlu.Visible = false;
                picture_gunesli.Visible = true;
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
