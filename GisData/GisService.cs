using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace GisData
{
    public class GisService
    {
        private String _gisMeteoLocal = ConfigurationManager.AppSettings.Get("gismeteo.local");
        private String _gisMeteoData = null;        
        private Dictionary<long, String> _cities = null;        

        public String GismeteoURL { get; } = ConfigurationManager.AppSettings.Get("gismeteo.url");

        public String GismeteoData
        {
            get
            {
                return _gisMeteoData;
            }
        }

        public Dictionary<long, String> Cities
        {
            get
            {
                if (_cities == null)
                {
                    parseHtml();
                }                
                return _cities;
            }
        }

        public GisService()
        {

        }

        public void getLocalData()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(_gisMeteoLocal))
                {
                    // Read the stream to a string, and write the string to the console.
                    _gisMeteoData = sr.ReadToEnd();
                    //Console.WriteLine(_gisMeteoData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }            
        }

        private void parseHtml()
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(_gisMeteoData);

            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//div[@class='cities_item']");

            _cities = (nodes.Count > 0) ? new Dictionary<long, String>(): null;

            foreach (HtmlNode node in nodes){ //получаем Id городов и названия из атрибутов и текста                
                HtmlNode hRef = node.ChildNodes["a"]; // нода ссылки содержащая Id города                
                string cityIdStr = Regex.Match(hRef.GetAttributeValue("href", ""), @"\d+").Value; // из атрибута href выбираем Id (цифры из ссылки) 
                HtmlNode span = hRef.SelectSingleNode("./span[@class='cities_name']");// нода span содержащая название города                
                _cities.Add(Int32.Parse(cityIdStr), Regex.Replace(span.InnerHtml, "[^\\w\\.()_]", ""));//добавляем назнавания городов, исключаем все лишние символы                
            }
        }


        public void getData()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(GismeteoURL);
            _gisMeteoData = doc.DocumentNode.InnerHtml;
        }
         
    }
}
