
namespace yazilim_yapim
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borsaDataSet = new yazilim_yapim.borsaDataSet();
            this.borsaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.alici_onay = new System.Windows.Forms.Button();
            this.alici_sil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaliciId = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borsaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // borsaDataSet
            // 
            this.borsaDataSet.DataSetName = "borsaDataSet";
            this.borsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borsaDataSetBindingSource
            // 
            this.borsaDataSetBindingSource.DataSource = this.borsaDataSet;
            this.borsaDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Satıcı ve Ürün Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yeni Satıcı ve Ürün Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Alıcı listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Alıcı Para Güncelle ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(648, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "ONAYLA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(502, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "SİL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Satıcı Id :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(566, 259);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            // 
            // alici_onay
            // 
            this.alici_onay.Location = new System.Drawing.Point(181, 186);
            this.alici_onay.Name = "alici_onay";
            this.alici_onay.Size = new System.Drawing.Size(102, 42);
            this.alici_onay.TabIndex = 9;
            this.alici_onay.Text = "ONAYLA ALICI";
            this.alici_onay.UseVisualStyleBackColor = true;
            this.alici_onay.Click += new System.EventHandler(this.alici_onay_Click);
            // 
            // alici_sil
            // 
            this.alici_sil.Location = new System.Drawing.Point(307, 187);
            this.alici_sil.Name = "alici_sil";
            this.alici_sil.Size = new System.Drawing.Size(92, 41);
            this.alici_sil.TabIndex = 10;
            this.alici_sil.Text = "SİL ALICI";
            this.alici_sil.UseVisualStyleBackColor = true;
            this.alici_sil.Click += new System.EventHandler(this.alici_sil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alıcı Id :";
            // 
            // txtaliciId
            // 
            this.txtaliciId.Location = new System.Drawing.Point(235, 254);
            this.txtaliciId.Name = "txtaliciId";
            this.txtaliciId.Size = new System.Drawing.Size(72, 20);
            this.txtaliciId.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 130);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Çıkış Yap";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtaliciId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alici_sil);
            this.Controls.Add(this.alici_onay);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borsaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource borsaDataSetBindingSource;
        private borsaDataSet borsaDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button alici_onay;
        private System.Windows.Forms.Button alici_sil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaliciId;
        private System.Windows.Forms.Button button7;
    }
}