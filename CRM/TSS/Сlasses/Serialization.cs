using TSS.Classes;
using System.Xml.Serialization;
using System.IO;

namespace TSS.Classes
{
    public class Serialization
    {
        private XmlSerializer xml = new XmlSerializer(typeof(Car));

        public void Serializer_cars(Garage g)
        {
            using (FileStream fs = new FileStream("List_cars.xml", FileMode.Create))
            {
                xml.Serialize(fs, g.GetCars);
            }
        }

        public void Deserializer_cars(Garage g)
        {
            using (FileStream fs = new FileStream("List_cars.xml", FileMode.Open))
            {
                Car cars = (Car)xml.Deserialize(fs);
                g.GetCars.Cars_list.AddRange(cars.Cars_list);
            }
        }
    }
}
