using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Mybikes.Bus
{
    public class FileHandler : IFileHandler
    {

        private static String xmlFilePathA = @"../../Data/Allbikes.xml";
        private static String xmlFilePathM = @"../../Data/Mountain.xml";
        private static String xmlFilePathR = @"../../Data/Road.xml";
        private static String LoginFilePath = @"../../Data/login.txt";


        public void WriteToXmlFileMountian(List<Mountainbike> listOfMountain)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePathM); //  mountian   
            XmlSerializer serializer = new XmlSerializer(typeof(List<Mountainbike>));
            serializer.Serialize(writer, listOfMountain);
            writer.Close();
        }


        public void WriteToXmlFileRoad(List<Roadbike> listOfRoad)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePathR); //  road  
            XmlSerializer serializer = new XmlSerializer(typeof(List<Roadbike>));
            serializer.Serialize(writer, listOfRoad);
            writer.Close();
        }


        public void WriteToXmlFileBike(List<Bike> Bikelist)
        {
            XmlWriter writer1 = XmlWriter.Create(xmlFilePathA); //  All bike  
            XmlSerializer serializer1 = new XmlSerializer(typeof(List<Bike>));
            serializer1.Serialize(writer1, Bikelist);
            writer1.Close();

        }


        public List<Mountainbike> ReadFromXmlFileM()
        {
            List<Mountainbike> tempmountainbikeslist = new List<Mountainbike>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Mountainbike>));
            StreamReader reader = new StreamReader(xmlFilePathM);
            tempmountainbikeslist = (List<Mountainbike>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return tempmountainbikeslist;
        }


        public List<Roadbike> ReadFromXmlFileR()
        {
            List<Roadbike> temproadbikeslist = new List<Roadbike>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Roadbike>));
            StreamReader reader = new StreamReader(xmlFilePathR);
            temproadbikeslist = (List<Roadbike>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return temproadbikeslist;
        }


        public List<Bike> ReadFromXmlFileA()
        {
            List<Bike> tempbikelist = new List<Bike>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));
            StreamReader reader = new StreamReader(xmlFilePathA);
            tempbikelist = (List<Bike>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return tempbikelist;
        }


        public List<Loginpage> ReadFromLoginfile()

        {
            List<Loginpage> temploginlist = new List<Loginpage>();
            StreamReader reader = new StreamReader(LoginFilePath);

            String line = null;
            line = reader.ReadLine();

            while (line != null)
            {
                Loginpage login = new Loginpage();
                String[] tokens = line.Split('|');
                login.Username = tokens[0];
                login.Password = tokens[1];
                temploginlist.Add(login);
                line = reader.ReadLine();
            }
            reader.Close();
            return temploginlist;
        }

    }
}
