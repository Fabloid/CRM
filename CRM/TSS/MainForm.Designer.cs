namespace TSS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brand_car_comboBox = new System.Windows.Forms.ComboBox();
            this.color_car_comboBox = new System.Windows.Forms.ComboBox();
            this.add_car_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_services_button = new System.Windows.Forms.Button();
            this.add_service_button = new System.Windows.Forms.Button();
            this.service_type_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.del_car_button = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cars_dataGridView = new System.Windows.Forms.DataGridView();
            this.serv_dataGridView = new System.Windows.Forms.DataGridView();
            this.num_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.body_car_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.body_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serv_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(113, 37);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(214, 22);
            this.model_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка авто:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер авто:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цвет авто:";
            // 
            // brand_car_comboBox
            // 
            this.brand_car_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brand_car_comboBox.FormattingEnabled = true;
            this.brand_car_comboBox.Location = new System.Drawing.Point(113, 7);
            this.brand_car_comboBox.Name = "brand_car_comboBox";
            this.brand_car_comboBox.Size = new System.Drawing.Size(214, 24);
            this.brand_car_comboBox.TabIndex = 7;
            this.brand_car_comboBox.Tag = "1";
            // 
            // color_car_comboBox
            // 
            this.color_car_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_car_comboBox.FormattingEnabled = true;
            this.color_car_comboBox.Location = new System.Drawing.Point(113, 65);
            this.color_car_comboBox.Name = "color_car_comboBox";
            this.color_car_comboBox.Size = new System.Drawing.Size(214, 24);
            this.color_car_comboBox.TabIndex = 8;
            this.color_car_comboBox.Tag = "2";
            // 
            // add_car_button
            // 
            this.add_car_button.Location = new System.Drawing.Point(6, 131);
            this.add_car_button.Name = "add_car_button";
            this.add_car_button.Size = new System.Drawing.Size(150, 23);
            this.add_car_button.TabIndex = 9;
            this.add_car_button.Text = "Записать";
            this.add_car_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.del_services_button);
            this.panel1.Controls.Add(this.add_service_button);
            this.panel1.Controls.Add(this.service_type_comboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.price_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(735, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 96);
            this.panel1.TabIndex = 11;
            // 
            // del_services_button
            // 
            this.del_services_button.Location = new System.Drawing.Point(177, 66);
            this.del_services_button.Name = "del_services_button";
            this.del_services_button.Size = new System.Drawing.Size(150, 23);
            this.del_services_button.TabIndex = 14;
            this.del_services_button.Text = "Удалить";
            this.del_services_button.UseVisualStyleBackColor = true;
            // 
            // add_service_button
            // 
            this.add_service_button.Location = new System.Drawing.Point(3, 66);
            this.add_service_button.Name = "add_service_button";
            this.add_service_button.Size = new System.Drawing.Size(153, 23);
            this.add_service_button.TabIndex = 12;
            this.add_service_button.Text = "Записать";
            this.add_service_button.UseVisualStyleBackColor = true;
            // 
            // service_type_comboBox
            // 
            this.service_type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_type_comboBox.FormattingEnabled = true;
            this.service_type_comboBox.Location = new System.Drawing.Point(107, 8);
            this.service_type_comboBox.Name = "service_type_comboBox";
            this.service_type_comboBox.Size = new System.Drawing.Size(220, 24);
            this.service_type_comboBox.TabIndex = 12;
            this.service_type_comboBox.Tag = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тип работы:";
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(144, 38);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(183, 22);
            this.price_textBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Стоимость работы:";
            // 
            // del_car_button
            // 
            this.del_car_button.Location = new System.Drawing.Point(177, 131);
            this.del_car_button.Name = "del_car_button";
            this.del_car_button.Size = new System.Drawing.Size(150, 23);
            this.del_car_button.TabIndex = 13;
            this.del_car_button.Text = "Удалить";
            this.del_car_button.UseVisualStyleBackColor = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // cars_dataGridView
            // 
            this.cars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cars_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_car,
            this.brand_car,
            this.model_car,
            this.color_car,
            this.body_car});
            this.cars_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.cars_dataGridView.Name = "cars_dataGridView";
            this.cars_dataGridView.RowHeadersVisible = false;
            this.cars_dataGridView.RowTemplate.Height = 24;
            this.cars_dataGridView.Size = new System.Drawing.Size(684, 200);
            this.cars_dataGridView.TabIndex = 14;
            // 
            // serv_dataGridView
            // 
            this.serv_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serv_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_serv,
            this.type_serv,
            this.price_serv});
            this.serv_dataGridView.Location = new System.Drawing.Point(12, 218);
            this.serv_dataGridView.Name = "serv_dataGridView";
            this.serv_dataGridView.RowHeadersVisible = false;
            this.serv_dataGridView.RowTemplate.Height = 24;
            this.serv_dataGridView.Size = new System.Drawing.Size(684, 192);
            this.serv_dataGridView.TabIndex = 15;
            // 
            // num_serv
            // 
            this.num_serv.HeaderText = "№";
            this.num_serv.Name = "num_serv";
            // 
            // type_serv
            // 
            this.type_serv.HeaderText = "Тип работ";
            this.type_serv.Name = "type_serv";
            // 
            // price_serv
            // 
            this.price_serv.HeaderText = "Стоимость";
            this.price_serv.Name = "price_serv";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.body_car_comboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.model_textBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.del_car_button);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.brand_car_comboBox);
            this.panel2.Controls.Add(this.add_car_button);
            this.panel2.Controls.Add(this.color_car_comboBox);
            this.panel2.Location = new System.Drawing.Point(735, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 166);
            this.panel2.TabIndex = 16;
            // 
            // body_car_comboBox
            // 
            this.body_car_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.body_car_comboBox.FormattingEnabled = true;
            this.body_car_comboBox.Location = new System.Drawing.Point(113, 96);
            this.body_car_comboBox.Name = "body_car_comboBox";
            this.body_car_comboBox.Size = new System.Drawing.Size(214, 24);
            this.body_car_comboBox.TabIndex = 15;
            this.body_car_comboBox.Tag = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кузов авто:";
            // 
            // num_car
            // 
            this.num_car.HeaderText = "№";
            this.num_car.Name = "num_car";
            // 
            // brand_car
            // 
            this.brand_car.HeaderText = "Марка";
            this.brand_car.Name = "brand_car";
            // 
            // model_car
            // 
            this.model_car.HeaderText = "Номер";
            this.model_car.Name = "model_car";
            // 
            // color_car
            // 
            this.color_car.HeaderText = "Цвет";
            this.color_car.Name = "color_car";
            // 
            // body_car
            // 
            this.body_car.HeaderText = "Кузов";
            this.body_car.Name = "body_car";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.serv_dataGridView);
            this.Controls.Add(this.cars_dataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гараж";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serv_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox brand_car_comboBox;
        private System.Windows.Forms.ComboBox color_car_comboBox;
        private System.Windows.Forms.Button add_car_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_service_button;
        private System.Windows.Forms.ComboBox service_type_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button del_car_button;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.DataGridView cars_dataGridView;
        private System.Windows.Forms.DataGridView serv_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_serv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button del_services_button;
        private System.Windows.Forms.ComboBox body_car_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn body_car;
    }
}