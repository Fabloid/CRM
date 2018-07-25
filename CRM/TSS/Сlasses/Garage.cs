using System.Collections.Generic;
using TSS.Interfaces;

namespace TSS.Classes
{
    public class Garage : IRemove
    {
        private Car _cars = new Car();

        public void Add_service(int car, int service_type, int price)
        {
            GetCars.Cars_list[car - 1].Services_List.Add(new Service(service_type, price));
        }

        public List<Service> Print_services(int car)
        {
            return GetCars.Cars_list[car - 1].Services_List;
        }

        public void Remove(int car, int serv)
        {
            GetCars.Cars_list[car - 1].Services_List.RemoveAt(serv - 1);
        }

        public Car GetCars
        {
            get { return _cars; }
        }
    }
}