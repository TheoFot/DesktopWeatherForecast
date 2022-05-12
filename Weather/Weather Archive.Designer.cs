namespace Weather
{
    partial class Weather_Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather_Archive));
            this.label1 = new System.Windows.Forms.Label();
            this.citiesName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_buttton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(290, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(233, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the city name( New York,Warsaw,Kyiv...)";
            // 
            // citiesName
            // 
            this.citiesName.BackColor = System.Drawing.Color.Tan;
            this.citiesName.ForeColor = System.Drawing.Color.DarkRed;
            this.citiesName.Location = new System.Drawing.Point(293, 80);
            this.citiesName.Multiline = true;
            this.citiesName.Name = "citiesName";
            this.citiesName.Size = new System.Drawing.Size(277, 20);
            this.citiesName.TabIndex = 5;
            this.citiesName.TextChanged += new System.EventHandler(this.citiesName_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.Location = new System.Drawing.Point(150, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 306);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_buttton
            // 
            this.search_buttton.BackColor = System.Drawing.Color.Tan;
            this.search_buttton.ForeColor = System.Drawing.Color.DarkRed;
            this.search_buttton.Location = new System.Drawing.Point(590, 80);
            this.search_buttton.Name = "search_buttton";
            this.search_buttton.Size = new System.Drawing.Size(90, 20);
            this.search_buttton.TabIndex = 7;
            this.search_buttton.Text = "Search";
            this.search_buttton.UseVisualStyleBackColor = false;
            this.search_buttton.Click += new System.EventHandler(this.search_buttton_Click);
            // 
            // Weather_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 452);
            this.Controls.Add(this.search_buttton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.citiesName);
            this.Controls.Add(this.label1);
            this.Name = "Weather_Archive";
            this.Text = "Weather_Archive";
            this.Load += new System.EventHandler(this.Weather_Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox citiesName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_buttton;
    }
}