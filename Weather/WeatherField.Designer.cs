using System;
using System.Windows.Forms;

namespace Weather
{
    public partial class WeatherField 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherField));
            this.showbutton = new System.Windows.Forms.Button();
            this.citiesName = new System.Windows.Forms.TextBox();
            this.countriesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.theweatherinformation = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showbutton
            // 
            this.showbutton.AutoSize = true;
            this.showbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showbutton.BackColor = System.Drawing.Color.LightBlue;
            this.showbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.showbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showbutton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.showbutton.Location = new System.Drawing.Point(62, 422);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(103, 23);
            this.showbutton.TabIndex = 0;
            this.showbutton.Text = "Show the weather";
            this.showbutton.UseVisualStyleBackColor = false;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // citiesName
            // 
            this.citiesName.BackColor = System.Drawing.Color.LightBlue;
            this.citiesName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.citiesName.Location = new System.Drawing.Point(186, 53);
            this.citiesName.Multiline = true;
            this.citiesName.Name = "citiesName";
            this.citiesName.Size = new System.Drawing.Size(447, 20);
            this.citiesName.TabIndex = 1;
            this.citiesName.TextChanged += new System.EventHandler(this.citiesName_TextChanged);
            // 
            // countriesName
            // 
            this.countriesName.BackColor = System.Drawing.Color.LightBlue;
            this.countriesName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.countriesName.Location = new System.Drawing.Point(186, 119);
            this.countriesName.Multiline = true;
            this.countriesName.Name = "countriesName";
            this.countriesName.Size = new System.Drawing.Size(447, 20);
            this.countriesName.TabIndex = 2;
            this.countriesName.TextChanged += new System.EventHandler(this.countriesName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(186, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the city name( New York,Warsaw,Kyiv...)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(183, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the country( US,PL,UA...)\r\nOnly 2 letters";
            // 
            // theweatherinformation
            // 
            this.theweatherinformation.BackColor = System.Drawing.Color.LightBlue;
            this.theweatherinformation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.theweatherinformation.Location = new System.Drawing.Point(186, 166);
            this.theweatherinformation.Multiline = true;
            this.theweatherinformation.Name = "theweatherinformation";
            this.theweatherinformation.Size = new System.Drawing.Size(444, 229);
            this.theweatherinformation.TabIndex = 5;
            this.theweatherinformation.TextChanged += new System.EventHandler(this.theweatherinformation_TextChanged);
            // 
            // buttonclear
            // 
            this.buttonclear.AutoSize = true;
            this.buttonclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonclear.BackColor = System.Drawing.Color.LightBlue;
            this.buttonclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonclear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonclear.Location = new System.Drawing.Point(373, 422);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(41, 23);
            this.buttonclear.TabIndex = 6;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // WeatherField
            // 
            this.AcceptButton = this.showbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Weather.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 468);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.theweatherinformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countriesName);
            this.Controls.Add(this.citiesName);
            this.Controls.Add(this.showbutton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherField";
            this.Text = "Weather";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton;
        private TextBox citiesName;
        private TextBox countriesName;
        private Label label1;
        private Label label2;
        private TextBox theweatherinformation;
        private Button buttonclear;
    }
}

