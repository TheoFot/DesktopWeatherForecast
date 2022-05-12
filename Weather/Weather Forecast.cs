using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class WeatherForecast : Form
    {
        private Form active;
        public WeatherForecast()
        {
            InitializeComponent();
        }

       

        private void weatherarchive_Click(object sender, EventArgs e)
        {
            OpenPanel(new Weather_Archive());
        }
        private void forecasrweather_Click(object sender, EventArgs e)
        {

            OpenPanel(new WeatherField());

        }
        private void OpenForm_Load(object sender, EventArgs e)
        {
            OpenPanel(new WeatherField());
            
        }
        private void OpenPanel(Form fm)
        {
            if (active!= null)
            {
                active.Close();
            }
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.openwindow.Controls.Add(fm);
            this.openwindow.Tag = fm;
            fm.BringToFront();
            fm.Show();

        }

        

       

        

        
    }
}
