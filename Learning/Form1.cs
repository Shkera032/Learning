using System.Net;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace Learning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var dateVal = xdoc.Element("ValCurs");
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string courseDate = dateVal.Attribute("Date").Value;
            MessageBox.Show($"Доллар на {courseDate} составляет: {dollar} рублей");
        }
    }
}