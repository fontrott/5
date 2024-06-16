namespace PR4
{
    partial class Buses
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buses));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_OnTheRoute = new System.Windows.Forms.Button();
            this.btn_InThePark = new System.Windows.Forms.Button();
            this.txt_SearchBuses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buses_TextBox = new System.Windows.Forms.TextBox();
            this.btn_Close1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_OnTheRoute = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RouteNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DriverNameAndSurname = new System.Windows.Forms.TextBox();
            this.btn_AddBus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_BusNumber = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddBus2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Close2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.меню.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 556);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(677, 547);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Расчеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox4.Controls.Add(this.btn_OnTheRoute);
            this.groupBox4.Controls.Add(this.btn_InThePark);
            this.groupBox4.Controls.Add(this.txt_SearchBuses);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buses_TextBox);
            this.groupBox4.Controls.Add(this.btn_Close1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(313, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 463);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат:";
            // 
            // btn_OnTheRoute
            // 
            this.btn_OnTheRoute.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_OnTheRoute.Location = new System.Drawing.Point(28, 319);
            this.btn_OnTheRoute.Name = "btn_OnTheRoute";
            this.btn_OnTheRoute.Size = new System.Drawing.Size(148, 26);
            this.btn_OnTheRoute.TabIndex = 13;
            this.btn_OnTheRoute.Text = "На маршруте";
            this.btn_OnTheRoute.UseVisualStyleBackColor = false;
            this.btn_OnTheRoute.Click += new System.EventHandler(this.btn_OnTheRoute_Click);
            // 
            // btn_InThePark
            // 
            this.btn_InThePark.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_InThePark.Location = new System.Drawing.Point(186, 319);
            this.btn_InThePark.Name = "btn_InThePark";
            this.btn_InThePark.Size = new System.Drawing.Size(148, 26);
            this.btn_InThePark.TabIndex = 12;
            this.btn_InThePark.Text = "В парке";
            this.btn_InThePark.UseVisualStyleBackColor = false;
            this.btn_InThePark.Click += new System.EventHandler(this.btn_InThePark_Click);
            // 
            // txt_SearchBuses
            // 
            this.txt_SearchBuses.Location = new System.Drawing.Point(186, 56);
            this.txt_SearchBuses.Multiline = true;
            this.txt_SearchBuses.Name = "txt_SearchBuses";
            this.txt_SearchBuses.ReadOnly = true;
            this.txt_SearchBuses.Size = new System.Drawing.Size(154, 217);
            this.txt_SearchBuses.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Какие автобусы вывести?";
            // 
            // buses_TextBox
            // 
            this.buses_TextBox.Location = new System.Drawing.Point(22, 56);
            this.buses_TextBox.Multiline = true;
            this.buses_TextBox.Name = "buses_TextBox";
            this.buses_TextBox.ReadOnly = true;
            this.buses_TextBox.Size = new System.Drawing.Size(154, 217);
            this.buses_TextBox.TabIndex = 9;
            // 
            // btn_Close1
            // 
            this.btn_Close1.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Close1.Location = new System.Drawing.Point(110, 409);
            this.btn_Close1.Name = "btn_Close1";
            this.btn_Close1.Size = new System.Drawing.Size(148, 26);
            this.btn_Close1.TabIndex = 8;
            this.btn_Close1.Text = "Выход";
            this.btn_Close1.UseVisualStyleBackColor = false;
            this.btn_Close1.Click += new System.EventHandler(this.btn_Close1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Данные об автобусах:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.chk_OnTheRoute);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txt_RouteNumber);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_DriverNameAndSurname);
            this.groupBox5.Controls.Add(this.btn_AddBus);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_BusNumber);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(3, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 463);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Исходные данные:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // chk_OnTheRoute
            // 
            this.chk_OnTheRoute.AutoSize = true;
            this.chk_OnTheRoute.Location = new System.Drawing.Point(39, 189);
            this.chk_OnTheRoute.Name = "chk_OnTheRoute";
            this.chk_OnTheRoute.Size = new System.Drawing.Size(221, 17);
            this.chk_OnTheRoute.TabIndex = 9;
            this.chk_OnTheRoute.Text = "Автобус на маршруте ( иначе в парке )";
            this.chk_OnTheRoute.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите номер маршрута:";
            // 
            // txt_RouteNumber
            // 
            this.txt_RouteNumber.Location = new System.Drawing.Point(39, 154);
            this.txt_RouteNumber.Name = "txt_RouteNumber";
            this.txt_RouteNumber.Size = new System.Drawing.Size(224, 20);
            this.txt_RouteNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите имя и фамилию водителя:";
            // 
            // txt_DriverNameAndSurname
            // 
            this.txt_DriverNameAndSurname.Location = new System.Drawing.Point(39, 104);
            this.txt_DriverNameAndSurname.Name = "txt_DriverNameAndSurname";
            this.txt_DriverNameAndSurname.Size = new System.Drawing.Size(224, 20);
            this.txt_DriverNameAndSurname.TabIndex = 12;
            // 
            // btn_AddBus
            // 
            this.btn_AddBus.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_AddBus.Location = new System.Drawing.Point(75, 410);
            this.btn_AddBus.Name = "btn_AddBus";
            this.btn_AddBus.Size = new System.Drawing.Size(146, 25);
            this.btn_AddBus.TabIndex = 7;
            this.btn_AddBus.Text = "Добавить автобус!";
            this.btn_AddBus.UseVisualStyleBackColor = false;
            this.btn_AddBus.Click += new System.EventHandler(this.btn_AddBus_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Введите номер автобуса:";
            // 
            // txt_BusNumber
            // 
            this.txt_BusNumber.Location = new System.Drawing.Point(39, 56);
            this.txt_BusNumber.Name = "txt_BusNumber";
            this.txt_BusNumber.Size = new System.Drawing.Size(224, 20);
            this.txt_BusNumber.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(671, 72);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(72, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(523, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "                                                    Здравствуйте! \r\nВ этой програ" +
    "мме вы можете получить все необходимые данные о автобусах!\r\n";
            // 
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.WhiteSmoke;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(685, 24);
            this.меню.TabIndex = 8;
            this.меню.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculate,
            this.btn_Clear,
            this.btn_Close2});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calculate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddBus2});
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 22);
            this.calculate.Text = "Вычислить";
            // 
            // btn_AddBus2
            // 
            this.btn_AddBus2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddBus2.Name = "btn_AddBus2";
            this.btn_AddBus2.Size = new System.Drawing.Size(175, 22);
            this.btn_AddBus2.Text = "Добавить автобус!";
            this.btn_AddBus2.Click += new System.EventHandler(this.btn_AddBus2_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(135, 22);
            this.btn_Clear.Text = "Очистить";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Close2
            // 
            this.btn_Close2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close2.Name = "btn_Close2";
            this.btn_Close2.Size = new System.Drawing.Size(135, 22);
            this.btn_Close2.Text = "Выход";
            this.btn_Close2.Click += new System.EventHandler(this.btn_Close2_Click);
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgram});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(65, 20);
            this.reference.Text = "Справка";
            // 
            // aboutTheProgram
            // 
            this.aboutTheProgram.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            this.aboutTheProgram.Click += new System.EventHandler(this.aboutTheProgram_Click);
            // 
            // Buses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 581);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.меню);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buses";
            this.Text = "Автобусы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Close1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_AddBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_BusNumber;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem btn_AddBus2;
        private System.Windows.Forms.ToolStripMenuItem btn_Clear;
        private System.Windows.Forms.ToolStripMenuItem btn_Close2;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
        private System.Windows.Forms.CheckBox chk_OnTheRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RouteNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DriverNameAndSurname;
        private System.Windows.Forms.TextBox buses_TextBox;
        private System.Windows.Forms.Button btn_OnTheRoute;
        private System.Windows.Forms.Button btn_InThePark;
        private System.Windows.Forms.TextBox txt_SearchBuses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

