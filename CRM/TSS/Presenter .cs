using System;
using TSS.Enumes.Work;
using TSS.Enumes.Transport;
using TSS.Enumes.Car;
using TSS.Classes;
using System.IO;

namespace TSS
{
    public class Presenter
    {
        private readonly IView _view;
        private Garage g = new Garage();

        public Presenter(IView view)
        {
            _view = view;

            _view.Form_load += _view_Form_load;
            _view.Add_car_click += _view_Add_car_click;
            _view.Add_serv_click += _view_Add_serv_click;
            _view.Del_car_click += _view_Del_car_click;
            _view.Del_serv_click += _view_Del_serv_click;
            _view.Cars_selection_changed += _view_Cars_selection_changed;
            _view.Form_closing += _view_Form_closing;
        }

        private void _view_Form_closing(object sender, EventArgs e)
        {
            Serialization s = new Serialization();
            s.Serializer_cars(g);
        }

        private void _view_Cars_selection_changed(object sender, EventArgs e)
        {
            Print_services();
        }

        private void _view_Form_load(object sender, EventArgs e)
        {
            object[] item_values;
            Array en;

            item_values = new object[Enum.GetValues(typeof(Brand_tr)).Length-1];
            en = Enum.GetValues(typeof(Brand_tr));
            for (int i = 0; i < Enum.GetValues(typeof(Brand_tr)).Length-1; i++)
            {
                item_values[i] = en.GetValue(i+1);
            }
            _view.Set_brand(item_values);

            item_values = new object[Enum.GetValues(typeof(Color_tr)).Length-1];
            en = Enum.GetValues(typeof(Color_tr));
            for (int i = 0; i < Enum.GetValues(typeof(Color_tr)).Length-1; i++)
            {
                item_values[i] = en.GetValue(i+1);
            }
            _view.Set_color(item_values);

            item_values = new object[Enum.GetValues(typeof(Serviсe_type)).Length-1];
            en = Enum.GetValues(typeof(Serviсe_type));
            for (int i = 0; i < Enum.GetValues(typeof(Serviсe_type)).Length-1; i++)
            {
                item_values[i] = en.GetValue(i+1);
            }
            _view.Set_type(item_values);

            item_values = new object[Enum.GetValues(typeof(Body_car)).Length-1];
            en = Enum.GetValues(typeof(Body_car));
            for (int i = 0; i < Enum.GetValues(typeof(Body_car)).Length-1; i++)
            {
                item_values[i] = en.GetValue(i+1);
            }
            _view.Set_body(item_values);

            if (File.Exists("List_cars.xml"))
            {
                Serialization s = new Serialization();
                s.Deserializer_cars(g);
                Print_cars();
            }            
        }

        private void _view_Del_serv_click(object sender, EventArgs e)
        {
            try
            {
                int selected_row_car = _view.Row_cars;
                int selected_row_serv = _view.Row_services;
                if (g.GetCars.Cars_list[selected_row_car].Services_List.Count > 0)
                    g.Remove(selected_row_car + 1, selected_row_serv + 1);
                Print_services();
            }
            catch (Exception ex)
            {
                _view.Show_message(ex.Message);
            }
        }

        private void _view_Del_car_click(object sender, EventArgs e)
        {
            int num_car = _view.Row_cars;
            if (g.GetCars.Cars_list.Count != 0)
                g.GetCars.Remove(num_car+1);
            Print_cars();
        }

        private void _view_Add_serv_click(object sender, EventArgs e)
        {
            try
            {
                int num_car = _view.Row_cars;
                int type = _view.Get_type+1;
                int price = _view.Get_price;
                g.Add_service(num_car + 1, type, price);
                Print_services();
            }
            catch (Exception ex)
            {
                _view.Show_message(ex.Message);
            }
        }

        private void _view_Add_car_click(object sender, EventArgs e)
        {
            int brand = _view.Get_brand + 1, color = _view.Get_color + 1, body = _view.Get_body + 1;
            string model = _view.Get_model;            
            g.GetCars.Add_car(brand, model, color, body);

            Print_cars();
        }

        private void Print_cars()
        {
            _view.Row_cars = 1;
            _view.Set_cars(0, null, null, null, null);
            if (g.GetCars.Cars_list.Count > 0)
            {
                _view.Row_cars = g.GetCars.Print_cars().Count;
                for (int i = 0; i < g.GetCars.Print_cars().Count; i++)
                {
                    string one = g.GetCars.Print_cars()[i].Brand.ToString();
                    string two = g.GetCars.Print_cars()[i].Info;
                    string three = g.GetCars.Print_cars()[i].Color.ToString();
                    string four = g.GetCars.Print_car(i + 1).Body.ToString();
                    _view.Set_cars(i, one, two, three, four);
                }
            }
        }

        private void Print_services()
        {
            _view.Row_services = 1;
            _view.Set_services(0, null, null);
            int selected_car = _view.Row_cars;
            if (g.Print_services(selected_car + 1).Count > 0)
            {
                _view.Row_services = g.Print_services(selected_car + 1).Count;
                for (int i = 0; i < g.Print_services(selected_car + 1).Count; i++)
                {
                    string value_one = g.Print_services(selected_car + 1)[i].Type.ToString();
                    string value_two = g.Print_services(selected_car + 1)[i].Price.ToString();
                    _view.Set_services(i, value_one, value_two);
                }
            }
        }
    }
}
