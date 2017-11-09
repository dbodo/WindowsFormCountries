using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace form
{
    public partial class Form1 : Form
    {
        public List<Country> lCountries;
        public Form1()
        {
            InitializeComponent();
            /*DATA GRID*/
            lCountries = GetCountries();
            dataGridViewCountries.DataSource = lCountries;

            /*COMBO BOX FILTRIRANJE*/
            List<String> lRegions = lCountries.Where(o => o.sRegion != "").Select(o => o.sRegion).Distinct().ToList();
            lRegions.Insert(0, "Svi Kontinenti");
            comboBoxRegion.DataSource = lRegions;

            /*COMBO BOX SORTIRANJE*/
            List<string> lSortCriterias = new List<string>()
            {
                    "‐",
                    "Glavni grad",
                    "Naziv",
                    "Broj stanovnika",
                    "Površina"
            };
            comboBoxSortiraj.DataSource = lSortCriterias;

        }
        public List<Country> GetCountries()
        {
            //Citanje vrijednosti iz JSON-a
            List<Country> lRESTCountries = new List<Country>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiURL"];
            string sJson = CallRestMethod(sUrl);
            JArray json = JArray.Parse(sJson);
            //float area = (float)item.GetValue("area");
            float area = -1;
            foreach (JObject item in json)
            {
                string code = (string)item.GetValue("alpha2Code");
                string name = (string)item.GetValue("name");
                string capital = (string)item.GetValue("capital");
                int population = (int)item.GetValue("population");
                if (item.GetValue("area").Type == JTokenType.Null)
                {
                    area = 0;
                }
                else
                {
                    area = (float)item.GetValue("area");
                }
                string region = (string)item.GetValue("region");
                //Dodavanje objekata u listu
                lRESTCountries.Add(new Country
                {
                    sCode = code,
                    sName = name,
                    sCapital = capital,
                    nPopulation = population,
                    fArea = area,
                    sRegion = region,
                });
            }
            return lRESTCountries;
        }
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        private void dataGridViewCountries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sRegion = (string)comboBoxRegion.SelectedItem; // odabrana vrijednost
            lCountries = GetCountries();
            if (sRegion != "Svi kontinenti")
            {
                lCountries = lCountries.Where(o => o.sRegion == sRegion).ToList();
                dataGridViewCountries.DataSource = lCountries;
            }
            else
            {
                dataGridViewCountries.DataSource = lCountries;
            }
        }

        private void comboBoxSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSortCriterias = (string)comboBoxSortiraj.SelectedItem;
            lCountries = GetCountries();
            dataGridViewCountries.DataSource = lCountries;
            switch (sSortCriterias)
            {
                case "-":
                case "Glavni grad":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sCapital).ToList();
                    break;
                case "Naziv":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sName).ToList();
                    break;
                case "Broj stanovnika":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.nPopulation).ToList();
                    break;
                case "Površina":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.fArea).ToList();
                    break;
            }
        }
        private void tbPretraži_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
