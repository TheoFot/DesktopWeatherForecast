namespace Weather
{
    partial class WeatherForecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForecast));
            this.weatherarchive = new System.Windows.Forms.Button();
            this.openwindow = new System.Windows.Forms.Panel();
            this.forecasrweather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weatherarchive
            // 
            this.weatherarchive.BackColor = System.Drawing.Color.LightBlue;
            this.weatherarchive.Location = new System.Drawing.Point(10, 88);
            this.weatherarchive.Name = "weatherarchive";
            this.weatherarchive.Size = new System.Drawing.Size(109, 46);
            this.weatherarchive.TabIndex = 2;
            this.weatherarchive.Text = "Archive";
            this.weatherarchive.UseVisualStyleBackColor = false;
            this.weatherarchive.Click += new System.EventHandler(this.weatherarchive_Click);
            // 
            // openwindow
            // 
            this.openwindow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.openwindow.AutoSize = true;
            this.openwindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openwindow.BackgroundImage")));
            this.openwindow.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::Weather.Properties.Settings.Default, "We", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.openwindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openwindow.Location = new System.Drawing.Point(0, 0);
            this.openwindow.Name = "openwindow";
            this.openwindow.Size = new System.Drawing.Size(923, 494);
            this.openwindow.TabIndex = 0;
            this.openwindow.Visible = global::Weather.Properties.Settings.Default.We;
            // 
            // forecasrweather
            // 
            this.forecasrweather.BackColor = System.Drawing.Color.LightBlue;
            this.forecasrweather.Location = new System.Drawing.Point(10, 21);
            this.forecasrweather.Name = "forecasrweather";
            this.forecasrweather.Size = new System.Drawing.Size(109, 46);
            this.forecasrweather.TabIndex = 3;
            this.forecasrweather.Text = "Forecast";
            this.forecasrweather.UseVisualStyleBackColor = false;
            this.forecasrweather.Click += new System.EventHandler(this.forecasrweather_Click);
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 494);
            this.Controls.Add(this.forecasrweather);
            this.Controls.Add(this.weatherarchive);
            this.Controls.Add(this.openwindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherForecast";
            this.Text = "Weather Forecast";
            this.Load += new System.EventHandler(this.OpenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel openwindow;
        
        private System.Windows.Forms.Button weatherarchive;
        private System.Windows.Forms.Button forecasrweather;
    }
}