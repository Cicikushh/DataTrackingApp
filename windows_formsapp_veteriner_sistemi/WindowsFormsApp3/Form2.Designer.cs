namespace WindowsFormsApp3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.hayvanisimlbl = new System.Windows.Forms.Label();
            this.hayvancinslbl = new System.Windows.Forms.Label();
            this.hayvanyaslbl = new System.Windows.Forms.Label();
            this.asilarlbl = new System.Windows.Forms.Label();
            this.hayvanisimtxt = new System.Windows.Forms.TextBox();
            this.hayvanyastxt = new System.Windows.Forms.TextBox();
            this.asilartxt = new System.Windows.Forms.TextBox();
            this.hayvaneklebutton = new System.Windows.Forms.Button();
            this.hayvansilbutton = new System.Windows.Forms.Button();
            this.hayvanguncellebutton = new System.Windows.Forms.Button();
            this.kayitEklemeTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayit_ekleDataSet1 = new WindowsFormsApp3.kayit_ekleDataSet1();
            this.kayit_Ekleme_TbTableAdapter = new WindowsFormsApp3.kayit_ekleDataSet1TableAdapters.Kayit_Ekleme_TbTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitEklemeTbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayit_ekleDataSet3 = new WindowsFormsApp3.kayit_ekleDataSet3();
            this.kayit_Ekleme_TbTableAdapter1 = new WindowsFormsApp3.kayit_ekleDataSet3TableAdapters.Kayit_Ekleme_TbTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hayvanİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvanCinsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvanYaşıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aşılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvanCinsiyetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitEklemeTbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kayit_ekleDataSet4 = new WindowsFormsApp3.kayit_ekleDataSet4();
            this.kayit_Ekleme_TbTableAdapter2 = new WindowsFormsApp3.kayit_ekleDataSet4TableAdapters.Kayit_Ekleme_TbTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hayvancinsicombobox = new System.Windows.Forms.ComboBox();
            this.hayvancinsiyetcombobox = new System.Windows.Forms.ComboBox();
            this.kayit_ekleDataSet5 = new WindowsFormsApp3.kayit_ekleDataSet5();
            this.kayitEklemeTbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kayit_Ekleme_TbTableAdapter3 = new WindowsFormsApp3.kayit_ekleDataSet5TableAdapters.Kayit_Ekleme_TbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // hayvanisimlbl
            // 
            this.hayvanisimlbl.AutoSize = true;
            this.hayvanisimlbl.BackColor = System.Drawing.Color.Transparent;
            this.hayvanisimlbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayvanisimlbl.ForeColor = System.Drawing.Color.Black;
            this.hayvanisimlbl.Location = new System.Drawing.Point(267, 41);
            this.hayvanisimlbl.Name = "hayvanisimlbl";
            this.hayvanisimlbl.Size = new System.Drawing.Size(92, 20);
            this.hayvanisimlbl.TabIndex = 0;
            this.hayvanisimlbl.Text = "Hayvan İsmi:";
            // 
            // hayvancinslbl
            // 
            this.hayvancinslbl.AutoSize = true;
            this.hayvancinslbl.BackColor = System.Drawing.Color.Transparent;
            this.hayvancinslbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayvancinslbl.ForeColor = System.Drawing.Color.Black;
            this.hayvancinslbl.Location = new System.Drawing.Point(262, 87);
            this.hayvancinslbl.Name = "hayvancinslbl";
            this.hayvancinslbl.Size = new System.Drawing.Size(97, 20);
            this.hayvancinslbl.TabIndex = 1;
            this.hayvancinslbl.Text = "Hayvan Cinsi:";
            // 
            // hayvanyaslbl
            // 
            this.hayvanyaslbl.AutoSize = true;
            this.hayvanyaslbl.BackColor = System.Drawing.Color.Transparent;
            this.hayvanyaslbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayvanyaslbl.ForeColor = System.Drawing.Color.Black;
            this.hayvanyaslbl.Location = new System.Drawing.Point(267, 170);
            this.hayvanyaslbl.Name = "hayvanyaslbl";
            this.hayvanyaslbl.Size = new System.Drawing.Size(92, 20);
            this.hayvanyaslbl.TabIndex = 2;
            this.hayvanyaslbl.Text = "Hayvan Yaşı:";
            // 
            // asilarlbl
            // 
            this.asilarlbl.AutoSize = true;
            this.asilarlbl.BackColor = System.Drawing.Color.Transparent;
            this.asilarlbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asilarlbl.ForeColor = System.Drawing.Color.Black;
            this.asilarlbl.Location = new System.Drawing.Point(309, 211);
            this.asilarlbl.Name = "asilarlbl";
            this.asilarlbl.Size = new System.Drawing.Size(50, 20);
            this.asilarlbl.TabIndex = 3;
            this.asilarlbl.Text = "Aşılar:";
            // 
            // hayvanisimtxt
            // 
            this.hayvanisimtxt.Location = new System.Drawing.Point(373, 41);
            this.hayvanisimtxt.Name = "hayvanisimtxt";
            this.hayvanisimtxt.Size = new System.Drawing.Size(100, 20);
            this.hayvanisimtxt.TabIndex = 4;
            // 
            // hayvanyastxt
            // 
            this.hayvanyastxt.Location = new System.Drawing.Point(373, 170);
            this.hayvanyastxt.Name = "hayvanyastxt";
            this.hayvanyastxt.Size = new System.Drawing.Size(100, 20);
            this.hayvanyastxt.TabIndex = 6;
            // 
            // asilartxt
            // 
            this.asilartxt.Location = new System.Drawing.Point(373, 211);
            this.asilartxt.Name = "asilartxt";
            this.asilartxt.Size = new System.Drawing.Size(100, 20);
            this.asilartxt.TabIndex = 7;
            // 
            // hayvaneklebutton
            // 
            this.hayvaneklebutton.BackColor = System.Drawing.Color.Lime;
            this.hayvaneklebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayvaneklebutton.ForeColor = System.Drawing.Color.White;
            this.hayvaneklebutton.Location = new System.Drawing.Point(521, 36);
            this.hayvaneklebutton.Name = "hayvaneklebutton";
            this.hayvaneklebutton.Size = new System.Drawing.Size(89, 41);
            this.hayvaneklebutton.TabIndex = 8;
            this.hayvaneklebutton.Text = "EKLE";
            this.hayvaneklebutton.UseVisualStyleBackColor = false;
            this.hayvaneklebutton.Click += new System.EventHandler(this.hayvaneklebutton_Click);
            // 
            // hayvansilbutton
            // 
            this.hayvansilbutton.BackColor = System.Drawing.Color.Red;
            this.hayvansilbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayvansilbutton.ForeColor = System.Drawing.Color.White;
            this.hayvansilbutton.Location = new System.Drawing.Point(521, 114);
            this.hayvansilbutton.Name = "hayvansilbutton";
            this.hayvansilbutton.Size = new System.Drawing.Size(89, 39);
            this.hayvansilbutton.TabIndex = 9;
            this.hayvansilbutton.Text = "SİL";
            this.hayvansilbutton.UseVisualStyleBackColor = false;
            this.hayvansilbutton.Click += new System.EventHandler(this.hayvansilbutton_Click);
            // 
            // hayvanguncellebutton
            // 
            this.hayvanguncellebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hayvanguncellebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayvanguncellebutton.ForeColor = System.Drawing.Color.White;
            this.hayvanguncellebutton.Location = new System.Drawing.Point(521, 193);
            this.hayvanguncellebutton.Name = "hayvanguncellebutton";
            this.hayvanguncellebutton.Size = new System.Drawing.Size(89, 39);
            this.hayvanguncellebutton.TabIndex = 10;
            this.hayvanguncellebutton.Text = "GÜNCELLE";
            this.hayvanguncellebutton.UseVisualStyleBackColor = false;
            this.hayvanguncellebutton.Click += new System.EventHandler(this.hayvanguncellebutton_Click);
            // 
            // kayitEklemeTbBindingSource
            // 
            this.kayitEklemeTbBindingSource.DataMember = "Kayit Ekleme_Tb";
            this.kayitEklemeTbBindingSource.DataSource = this.kayit_ekleDataSet1;
            // 
            // kayit_ekleDataSet1
            // 
            this.kayit_ekleDataSet1.DataSetName = "kayit_ekleDataSet1";
            this.kayit_ekleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayit_Ekleme_TbTableAdapter
            // 
            this.kayit_Ekleme_TbTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(238, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hayvan Cinsiyeti:";
            // 
            // kayitEklemeTbBindingSource1
            // 
            this.kayitEklemeTbBindingSource1.DataMember = "Kayit Ekleme_Tb";
            this.kayitEklemeTbBindingSource1.DataSource = this.kayit_ekleDataSet3;
            // 
            // kayit_ekleDataSet3
            // 
            this.kayit_ekleDataSet3.DataSetName = "kayit_ekleDataSet3";
            this.kayit_ekleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayit_Ekleme_TbTableAdapter1
            // 
            this.kayit_Ekleme_TbTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hayvanİsmiDataGridViewTextBoxColumn,
            this.hayvanCinsiDataGridViewTextBoxColumn,
            this.hayvanYaşıDataGridViewTextBoxColumn,
            this.aşılarDataGridViewTextBoxColumn,
            this.hayvanCinsiyetiDataGridViewTextBoxColumn,
            this.ıDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayitEklemeTbBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(72, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 174);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hayvanİsmiDataGridViewTextBoxColumn
            // 
            this.hayvanİsmiDataGridViewTextBoxColumn.DataPropertyName = "Hayvan İsmi";
            this.hayvanİsmiDataGridViewTextBoxColumn.HeaderText = "Hayvan İsmi";
            this.hayvanİsmiDataGridViewTextBoxColumn.Name = "hayvanİsmiDataGridViewTextBoxColumn";
            // 
            // hayvanCinsiDataGridViewTextBoxColumn
            // 
            this.hayvanCinsiDataGridViewTextBoxColumn.DataPropertyName = "Hayvan Cinsi";
            this.hayvanCinsiDataGridViewTextBoxColumn.HeaderText = "Hayvan Cinsi";
            this.hayvanCinsiDataGridViewTextBoxColumn.Name = "hayvanCinsiDataGridViewTextBoxColumn";
            // 
            // hayvanYaşıDataGridViewTextBoxColumn
            // 
            this.hayvanYaşıDataGridViewTextBoxColumn.DataPropertyName = "Hayvan Yaşı";
            this.hayvanYaşıDataGridViewTextBoxColumn.HeaderText = "Hayvan Yaşı";
            this.hayvanYaşıDataGridViewTextBoxColumn.Name = "hayvanYaşıDataGridViewTextBoxColumn";
            // 
            // aşılarDataGridViewTextBoxColumn
            // 
            this.aşılarDataGridViewTextBoxColumn.DataPropertyName = "Aşılar";
            this.aşılarDataGridViewTextBoxColumn.HeaderText = "Aşılar";
            this.aşılarDataGridViewTextBoxColumn.Name = "aşılarDataGridViewTextBoxColumn";
            // 
            // hayvanCinsiyetiDataGridViewTextBoxColumn
            // 
            this.hayvanCinsiyetiDataGridViewTextBoxColumn.DataPropertyName = "Hayvan Cinsiyeti";
            this.hayvanCinsiyetiDataGridViewTextBoxColumn.HeaderText = "Hayvan Cinsiyeti";
            this.hayvanCinsiyetiDataGridViewTextBoxColumn.Name = "hayvanCinsiyetiDataGridViewTextBoxColumn";
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kayitEklemeTbBindingSource2
            // 
            this.kayitEklemeTbBindingSource2.DataMember = "Kayit Ekleme_Tb";
            this.kayitEklemeTbBindingSource2.DataSource = this.kayit_ekleDataSet4;
            // 
            // kayit_ekleDataSet4
            // 
            this.kayit_ekleDataSet4.DataSetName = "kayit_ekleDataSet4";
            this.kayit_ekleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayit_Ekleme_TbTableAdapter2
            // 
            this.kayit_Ekleme_TbTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // hayvancinsicombobox
            // 
            this.hayvancinsicombobox.FormattingEnabled = true;
            this.hayvancinsicombobox.Items.AddRange(new object[] {
            "Kedi",
            "Köpek",
            "Kuş"});
            this.hayvancinsicombobox.Location = new System.Drawing.Point(373, 87);
            this.hayvancinsicombobox.Name = "hayvancinsicombobox";
            this.hayvancinsicombobox.Size = new System.Drawing.Size(100, 21);
            this.hayvancinsicombobox.TabIndex = 18;
            // 
            // hayvancinsiyetcombobox
            // 
            this.hayvancinsiyetcombobox.FormattingEnabled = true;
            this.hayvancinsiyetcombobox.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.hayvancinsiyetcombobox.Location = new System.Drawing.Point(373, 127);
            this.hayvancinsiyetcombobox.Name = "hayvancinsiyetcombobox";
            this.hayvancinsiyetcombobox.Size = new System.Drawing.Size(100, 21);
            this.hayvancinsiyetcombobox.TabIndex = 19;
            // 
            // kayit_ekleDataSet5
            // 
            this.kayit_ekleDataSet5.DataSetName = "kayit_ekleDataSet5";
            this.kayit_ekleDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitEklemeTbBindingSource3
            // 
            this.kayitEklemeTbBindingSource3.DataMember = "Kayit Ekleme_Tb";
            this.kayitEklemeTbBindingSource3.DataSource = this.kayit_ekleDataSet5;
            // 
            // kayit_Ekleme_TbTableAdapter3
            // 
            this.kayit_Ekleme_TbTableAdapter3.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hayvancinsiyetcombobox);
            this.Controls.Add(this.hayvancinsicombobox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hayvanguncellebutton);
            this.Controls.Add(this.hayvansilbutton);
            this.Controls.Add(this.hayvaneklebutton);
            this.Controls.Add(this.asilartxt);
            this.Controls.Add(this.hayvanyastxt);
            this.Controls.Add(this.hayvanisimtxt);
            this.Controls.Add(this.asilarlbl);
            this.Controls.Add(this.hayvanyaslbl);
            this.Controls.Add(this.hayvancinslbl);
            this.Controls.Add(this.hayvanisimlbl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_ekleDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitEklemeTbBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hayvanisimlbl;
        private System.Windows.Forms.Label hayvancinslbl;
        private System.Windows.Forms.Label hayvanyaslbl;
        private System.Windows.Forms.Label asilarlbl;
        private System.Windows.Forms.TextBox hayvanisimtxt;
        private System.Windows.Forms.TextBox hayvanyastxt;
        private System.Windows.Forms.TextBox asilartxt;
        private System.Windows.Forms.Button hayvaneklebutton;
        private System.Windows.Forms.Button hayvansilbutton;
        private System.Windows.Forms.Button hayvanguncellebutton;
        private kayit_ekleDataSet1 kayit_ekleDataSet1;
        private System.Windows.Forms.BindingSource kayitEklemeTbBindingSource;
        private kayit_ekleDataSet1TableAdapters.Kayit_Ekleme_TbTableAdapter kayit_Ekleme_TbTableAdapter;
        private System.Windows.Forms.Label label1;
        private kayit_ekleDataSet3 kayit_ekleDataSet3;
        private System.Windows.Forms.BindingSource kayitEklemeTbBindingSource1;
        private kayit_ekleDataSet3TableAdapters.Kayit_Ekleme_TbTableAdapter kayit_Ekleme_TbTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kayit_ekleDataSet4 kayit_ekleDataSet4;
        private System.Windows.Forms.BindingSource kayitEklemeTbBindingSource2;
        private kayit_ekleDataSet4TableAdapters.Kayit_Ekleme_TbTableAdapter kayit_Ekleme_TbTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hayvanİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hayvanCinsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hayvanYaşıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aşılarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hayvanCinsiyetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox hayvancinsicombobox;
        private System.Windows.Forms.ComboBox hayvancinsiyetcombobox;
        private kayit_ekleDataSet5 kayit_ekleDataSet5;
        private System.Windows.Forms.BindingSource kayitEklemeTbBindingSource3;
        private kayit_ekleDataSet5TableAdapters.Kayit_Ekleme_TbTableAdapter kayit_Ekleme_TbTableAdapter3;
    }
}