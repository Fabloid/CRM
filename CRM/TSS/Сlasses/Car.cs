using System;
using System.Collections.Generic;
using TSS.Enumes.Transport;
using TSS.Enumes.Car;
using TSS.Interfaces;

namespace TSS.Classes
{
    [Serializable]
    public class Car : Transport, IRemove
    {
        private Body_car _body;
        private List<Car> _cars = new List<Car>();

        public Car() { }
        public Car(int brand_car, string model_car, int color_car, int body)
        {
            Brand = (Brand_tr)brand_car;
            Info = model_car;
            Color = (Color_tr)color_car;
            Services_List = new List<Service>();
            Body = (Body_car)body;
        }

        public void Add_car(int brand_car, string model_car, int color_car, int body_car)
        {
            _cars.Add(new Car(brand_car, model_car, color_car, body_car));
        }

        public List<Car> Print_cars()
        {
            return _cars;
        }

        public Car Print_car(int num)
        {
            return _cars[num - 1];
        }

        public void Remove(int num, int car = 0)
        {
            Cars_list.RemoveAt(num - 1);
        }

        public List<Car> Cars_list
        {
            get { return _cars; }
            set { _cars = value; }
        }

        public Body_car Body
        {
            get { return _body; }
            set
            {
                if (value > (Body_car)4)
                    _body = (Body_car)4;
                else
                    _body = value;
            }
        }

        public override Brand_tr Brand
        {
            get => base.Brand;
            set
            {
                if (value > (Brand_tr)5)
                    base.Brand = (Brand_tr)5;
                else
                    base.Brand = value;
            }
        }

        public override Color_tr Color
        {
            get => base.Color;
            set
            {
                if (value > (Color_tr)5)
                    base.Color = (Color_tr)5;
                else
                    base.Color = value;
            }
        }
    }
}