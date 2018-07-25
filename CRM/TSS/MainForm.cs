using System;
using System.Windows.Forms;

namespace TSS
{
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            add_car_button.Click += Add_car_button_Click;
            del_car_button.Click += Del_car_button_Click;
            add_service_button.Click += Add_service_button_Click;
            del_services_button.Click += Del_service_button_Click;
            cars_dataGridView.SelectionChanged += Cars_dataGridView_SelectionChanged;
            FormClosing += MainForm_FormClosing;
        }

        #region Реализация IView
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form_closing != null) Form_closing(this, EventArgs.Empty);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Form_load != null) Form_load(this, EventArgs.Empty);
        }

        private void Add_car_button_Click(object sender, EventArgs e)
        {
            if (Add_car_click != null) Add_car_click(this, EventArgs.Empty);
        }

        private void Del_service_button_Click(object sender, EventArgs e)
        {
            if (Del_serv_click != null) Del_serv_click(this, EventArgs.Empty);
        }

        private void Add_service_button_Click(object sender, EventArgs e)
        {
            if (Add_serv_click != null) Add_serv_click(this, EventArgs.Empty);
        }

        private void Del_car_button_Click(object sender, EventArgs e)
        {
            if (Del_car_click != null) Del_car_click(this, EventArgs.Empty);
        }

        private void Cars_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Cars_selection_changed != null) Cars_selection_changed(this, EventArgs.Empty);
        }

        public int Get_brand
        {
            get { return brand_car_comboBox.SelectedIndex; }
        }

        public string Get_model
        {
            get { return model_textBox.Text; }
        }

        public int Get_color
        {
            get { return color_car_comboBox.SelectedIndex; }
        }

        public int Get_body
        {
            get { return body_car_comboBox.SelectedIndex; }
        }

        public int Get_type
        {
            get { return service_type_comboBox.SelectedIndex; }
        }

        public int Get_price
        {
            get { return Int32.Parse(price_textBox.Text); }
        }

        public int Row_cars
        {
            get { return cars_dataGridView.CurrentRow.Index; }
            set { cars_dataGridView.RowCount = value; }
        }

        public int Row_services
        {
            get { return serv_dataGridView.CurrentRow.Index; }
            set { serv_dataGridView.RowCount = value; }
        }

        public void Set_brand(object[] brend_enum)
        {
            brand_car_comboBox.Items.AddRange(brend_enum);
        }

        public void Set_color(object[] color_enum)
        {
            color_car_comboBox.Items.AddRange(color_enum);
        }

        public void Set_body(object[] body_enum)
        {
            body_car_comboBox.Items.AddRange(body_enum);
        }

        public void Set_type(object[] type_enum)
        {
            service_type_comboBox.Items.AddRange(type_enum);
        }

        public void Set_cars(int i, string value_one, string value_two, string value_three, string value_four)
        {
            cars_dataGridView[0, i].Value = i+1;
            cars_dataGridView[1, i].Value = value_one;
            cars_dataGridView[2, i].Value = value_two;
            cars_dataGridView[3, i].Value = value_three;
            cars_dataGridView[4, i].Value = value_four;
        }

        public void Set_services(int i, string value_one, string value_two)
        {
            serv_dataGridView[0, i].Value = i + 1;
            serv_dataGridView[1, i].Value = value_one;
            serv_dataGridView[2, i].Value = value_two;
        }

        public void Show_message(string message)
        {
            MessageBox.Show(message);
        }

        public event EventHandler Form_load;
        public event EventHandler Add_car_click;
        public event EventHandler Del_car_click;
        public event EventHandler Add_serv_click;
        public event EventHandler Del_serv_click;
        public event EventHandler Cars_selection_changed;
        public event EventHandler Form_closing;
        #endregion
    }
}