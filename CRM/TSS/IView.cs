using System;

namespace TSS
{
    public interface IView
    {
        int Get_brand { get; }
        string Get_model { get; }
        int Get_color { get; }
        int Get_body { get; }
        int Get_type { get; }
        int Get_price { get; }
        int Row_cars { get; set; }
        int Row_services { get; set; }
        void Set_brand(object[] brand_enum);
        void Set_color(object[] color_enum);
        void Set_body(object[] body_enum);
        void Set_type(object[] type_enum);
        void Set_cars(int i, string value_one, string value_two, string value_three, string value_four);
        void Set_services(int i, string value_one, string value_two);
        void Show_message(string message);
        event EventHandler Form_load;
        event EventHandler Add_car_click;
        event EventHandler Del_car_click;
        event EventHandler Add_serv_click;
        event EventHandler Del_serv_click;
        event EventHandler Cars_selection_changed;
        event EventHandler Form_closing;
    }
}
