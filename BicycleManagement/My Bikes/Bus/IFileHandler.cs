using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mybikes.Bus
{
    interface IFileHandler
    {
       // void WriteToXmlFileMountian(List<Mountainbike> listOfMountain);
      //  void WriteToXmlFileRoad(List<Roadbike> listOfRoad);
        void WriteToXmlFileBike(List<Bike> Bikelist);
        //List<Mountainbike> ReadFromXmlFileM();
       // List<Roadbike> ReadFromXmlFileR();
        List<Bike> ReadFromXmlFileA();
        List<Loginpage> ReadFromLoginfile();
    }
}
