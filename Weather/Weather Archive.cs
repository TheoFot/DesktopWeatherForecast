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
    public partial class Weather_Archive : Form
    {
       private string _citiesname;
        
        public Weather_Archive(string CityName)
        {
            _citiesname = CityName;        
        }
        public Weather_Archive()
        {
            InitializeComponent();
        }       
        private void citiesName_TextChanged(object sender, EventArgs e)
        {
            _citiesname = citiesName.Text;
        }
        private void Weather_Archive_Load(object sender, EventArgs e)
        { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }    
        private void search_buttton_Click(object sender, EventArgs e)
        {
            Weather_Archive archive = new Weather_Archive();
            archive._citiesname = citiesName.Text;
            List<StoryWeatherTemplate> storyweathers = new List<StoryWeatherTemplate>();
            storyweathers = DataBaseModel.GetWeatherArchiveFromDB(archive._citiesname);
            if (storyweathers.Count == 0)
            {
                DataTable tableArchive = new DataTable();
                tableArchive.Columns.Add("There is no data for this city", typeof(string));
                dataGridView1.DataSource = tableArchive;
            }
            else
            {
                DataTable tableArchive = new DataTable();
                tableArchive.Columns.Add("id", typeof(int));
                tableArchive.Columns.Add("name", typeof(string));
                tableArchive.Columns.Add("temperature", typeof(string));
                tableArchive.Columns.Add("time", typeof(DateTime));

                foreach (var item in storyweathers)
                {
                    tableArchive.Rows.Add(item.id, item.name, item.temperature, item.time);
                }

                dataGridView1.DataSource = tableArchive;
            }

        }
    }
}
