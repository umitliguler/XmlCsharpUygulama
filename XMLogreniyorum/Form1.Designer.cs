namespace XMLogreniyorum
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.btnVeriBul = new System.Windows.Forms.Button();
            this.btnVeriBul2 = new System.Windows.Forms.Button();
            this.btnVeriDegistir = new System.Windows.Forms.Button();
            this.btnVeriBul3 = new System.Windows.Forms.Button();
            this.btnVeriSil = new System.Windows.Forms.Button();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.btnSQLtoXML = new System.Windows.Forms.Button();
            this.btnXmlToSql = new System.Windows.Forms.Button();
            this.btnSema = new System.Windows.Forms.Button();
            this.BtnXmlToSqlWithSchema = new System.Windows.Forms.Button();
            this.btnXmlSchemaValidation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(119, 242);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(89, 38);
            this.btnVeriOku.TabIndex = 1;
            this.btnVeriOku.Text = "Veri Oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // btnVeriBul
            // 
            this.btnVeriBul.Location = new System.Drawing.Point(25, 242);
            this.btnVeriBul.Name = "btnVeriBul";
            this.btnVeriBul.Size = new System.Drawing.Size(89, 38);
            this.btnVeriBul.TabIndex = 2;
            this.btnVeriBul.Text = "Veri Bul";
            this.btnVeriBul.UseVisualStyleBackColor = true;
            this.btnVeriBul.Click += new System.EventHandler(this.btnVeriBul_Click);
            // 
            // btnVeriBul2
            // 
            this.btnVeriBul2.Location = new System.Drawing.Point(25, 286);
            this.btnVeriBul2.Name = "btnVeriBul2";
            this.btnVeriBul2.Size = new System.Drawing.Size(89, 35);
            this.btnVeriBul2.TabIndex = 3;
            this.btnVeriBul2.Text = "Veri Bul 2";
            this.btnVeriBul2.UseVisualStyleBackColor = true;
            this.btnVeriBul2.Click += new System.EventHandler(this.btnVeriBul2_Click);
            // 
            // btnVeriDegistir
            // 
            this.btnVeriDegistir.Location = new System.Drawing.Point(119, 286);
            this.btnVeriDegistir.Name = "btnVeriDegistir";
            this.btnVeriDegistir.Size = new System.Drawing.Size(89, 35);
            this.btnVeriDegistir.TabIndex = 4;
            this.btnVeriDegistir.Text = "Veri Degistir";
            this.btnVeriDegistir.UseVisualStyleBackColor = true;
            this.btnVeriDegistir.Click += new System.EventHandler(this.btnVeriDegistir_Click);
            // 
            // btnVeriBul3
            // 
            this.btnVeriBul3.Location = new System.Drawing.Point(25, 327);
            this.btnVeriBul3.Name = "btnVeriBul3";
            this.btnVeriBul3.Size = new System.Drawing.Size(91, 35);
            this.btnVeriBul3.TabIndex = 5;
            this.btnVeriBul3.Text = "Veri Bul 3";
            this.btnVeriBul3.UseVisualStyleBackColor = true;
            this.btnVeriBul3.Click += new System.EventHandler(this.btnVeriBul3_Click);
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.Location = new System.Drawing.Point(119, 324);
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.Size = new System.Drawing.Size(89, 38);
            this.btnVeriSil.TabIndex = 6;
            this.btnVeriSil.Text = "Veri Sil";
            this.btnVeriSil.UseVisualStyleBackColor = true;
            this.btnVeriSil.Click += new System.EventHandler(this.btnVeriSil_Click);
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.Location = new System.Drawing.Point(213, 242);
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.Size = new System.Drawing.Size(89, 38);
            this.btnVeriEkle.TabIndex = 7;
            this.btnVeriEkle.Text = "Veri ekle";
            this.btnVeriEkle.UseVisualStyleBackColor = true;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click);
            // 
            // btnSQLtoXML
            // 
            this.btnSQLtoXML.Location = new System.Drawing.Point(213, 286);
            this.btnSQLtoXML.Name = "btnSQLtoXML";
            this.btnSQLtoXML.Size = new System.Drawing.Size(89, 35);
            this.btnSQLtoXML.TabIndex = 8;
            this.btnSQLtoXML.Text = "Sql to Xml";
            this.btnSQLtoXML.UseVisualStyleBackColor = true;
            this.btnSQLtoXML.Click += new System.EventHandler(this.btnSQLtoXML_Click);
            // 
            // btnXmlToSql
            // 
            this.btnXmlToSql.Location = new System.Drawing.Point(213, 325);
            this.btnXmlToSql.Name = "btnXmlToSql";
            this.btnXmlToSql.Size = new System.Drawing.Size(89, 34);
            this.btnXmlToSql.TabIndex = 9;
            this.btnXmlToSql.Text = "Xml to Sql";
            this.btnXmlToSql.UseVisualStyleBackColor = true;
            this.btnXmlToSql.Click += new System.EventHandler(this.btnXmlToSql_Click);
            // 
            // btnSema
            // 
            this.btnSema.Location = new System.Drawing.Point(308, 242);
            this.btnSema.Name = "btnSema";
            this.btnSema.Size = new System.Drawing.Size(89, 37);
            this.btnSema.TabIndex = 10;
            this.btnSema.Text = "Şema";
            this.btnSema.UseVisualStyleBackColor = true;
            this.btnSema.Click += new System.EventHandler(this.btnSema_Click);
            // 
            // BtnXmlToSqlWithSchema
            // 
            this.BtnXmlToSqlWithSchema.Location = new System.Drawing.Point(308, 282);
            this.BtnXmlToSqlWithSchema.Name = "BtnXmlToSqlWithSchema";
            this.BtnXmlToSqlWithSchema.Size = new System.Drawing.Size(89, 39);
            this.BtnXmlToSqlWithSchema.TabIndex = 11;
            this.BtnXmlToSqlWithSchema.Text = "Xml to Sql Şemaya Göre";
            this.BtnXmlToSqlWithSchema.UseVisualStyleBackColor = true;
            this.BtnXmlToSqlWithSchema.Click += new System.EventHandler(this.BtnXmlToSqlWithSchema_Click);
            // 
            // btnXmlSchemaValidation
            // 
            this.btnXmlSchemaValidation.Location = new System.Drawing.Point(309, 324);
            this.btnXmlSchemaValidation.Name = "btnXmlSchemaValidation";
            this.btnXmlSchemaValidation.Size = new System.Drawing.Size(88, 35);
            this.btnXmlSchemaValidation.TabIndex = 12;
            this.btnXmlSchemaValidation.Text = "Xml Şema Doğrulaması";
            this.btnXmlSchemaValidation.UseVisualStyleBackColor = true;
            this.btnXmlSchemaValidation.Click += new System.EventHandler(this.btnXmlSchemaValidation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 388);
            this.Controls.Add(this.btnXmlSchemaValidation);
            this.Controls.Add(this.BtnXmlToSqlWithSchema);
            this.Controls.Add(this.btnSema);
            this.Controls.Add(this.btnXmlToSql);
            this.Controls.Add(this.btnSQLtoXML);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.btnVeriSil);
            this.Controls.Add(this.btnVeriBul3);
            this.Controls.Add(this.btnVeriDegistir);
            this.Controls.Add(this.btnVeriBul2);
            this.Controls.Add(this.btnVeriBul);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.Button btnVeriBul;
        private System.Windows.Forms.Button btnVeriBul2;
        private System.Windows.Forms.Button btnVeriDegistir;
        private System.Windows.Forms.Button btnVeriBul3;
        private System.Windows.Forms.Button btnVeriSil;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Button btnSQLtoXML;
        private System.Windows.Forms.Button btnXmlToSql;
        private System.Windows.Forms.Button btnSema;
        private System.Windows.Forms.Button BtnXmlToSqlWithSchema;
        private System.Windows.Forms.Button btnXmlSchemaValidation;
    }
}

