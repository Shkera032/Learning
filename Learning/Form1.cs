using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
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

        private async void button1_Click_1(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://www.cbr-xml-daily.ru/daily.xml");
            using HttpResponseMessage response = await httpClient.SendAsync(request);
            string  content = await response.Content.ReadAsStringAsync();
            XDocument xdoc = XDocument.Parse(content);
            var dateVal = xdoc.Element("ValCurs");
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string courseDate = dateVal.Attribute("Date").Value;
            MessageBox.Show($"Доллар на {courseDate} составляет: {dollar} рублей");
        }

        private async void getCoursJSON_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://www.cbr-xml-daily.ru/daily_json.js");
            using HttpResponseMessage response = await httpClient.SendAsync(request);
            string content = await response.Content.ReadAsStringAsync();
            var dateVal = JsonObject.Parse(content)["Date"].ToString();
            var dollar = JsonObject.Parse(content)["Valute"]["USD"]["Value"].ToString();
            MessageBox.Show($"Доллар на {dateVal} составляет: {dollar} рублей");

        }
    }
}