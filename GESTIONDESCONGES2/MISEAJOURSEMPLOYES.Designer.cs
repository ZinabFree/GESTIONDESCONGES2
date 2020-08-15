namespace GESTIONDESCONGES2
{
    partial class MISEAJOURSEMPLOYES
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.tprenomAR = new System.Windows.Forms.TextBox();
            this.tnomAR = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnew = new System.Windows.Forms.Button();
            this.bsearch = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tserviceAR = new System.Windows.Forms.TextBox();
            this.tidservice = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tservice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tgradeAR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tstatue = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tnom = new System.Windows.Forms.TextBox();
            this.tdure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tgrade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 274);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1469, 432);
            this.grid.TabIndex = 47;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // tprenomAR
            // 
            this.tprenomAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprenomAR.Location = new System.Drawing.Point(21, 57);
            this.tprenomAR.Multiline = true;
            this.tprenomAR.Name = "tprenomAR";
            this.tprenomAR.Size = new System.Drawing.Size(253, 26);
            this.tprenomAR.TabIndex = 13;
            // 
            // tnomAR
            // 
            this.tnomAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnomAR.Location = new System.Drawing.Point(21, 29);
            this.tnomAR.Multiline = true;
            this.tnomAR.Name = "tnomAR";
            this.tnomAR.Size = new System.Drawing.Size(253, 26);
            this.tnomAR.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.bnew);
            this.groupBox3.Controls.Add(this.bsearch);
            this.groupBox3.Controls.Add(this.bdelete);
            this.groupBox3.Controls.Add(this.badd);
            this.groupBox3.Controls.Add(this.bupdate);
            this.groupBox3.Location = new System.Drawing.Point(1181, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 257);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // bnew
            // 
            this.bnew.BackColor = System.Drawing.Color.White;
            this.bnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnew.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnew.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnew.Location = new System.Drawing.Point(16, 210);
            this.bnew.Name = "bnew";
            this.bnew.Size = new System.Drawing.Size(133, 39);
            this.bnew.TabIndex = 4;
            this.bnew.Text = "Nouveau";
            this.bnew.UseVisualStyleBackColor = false;
            this.bnew.Click += new System.EventHandler(this.bnew_Click);
            // 
            // bsearch
            // 
            this.bsearch.BackColor = System.Drawing.Color.White;
            this.bsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bsearch.Location = new System.Drawing.Point(16, 160);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(133, 39);
            this.bsearch.TabIndex = 3;
            this.bsearch.Text = "Rechercher";
            this.bsearch.UseVisualStyleBackColor = false;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.White;
            this.bdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bdelete.Location = new System.Drawing.Point(16, 111);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(133, 40);
            this.bdelete.TabIndex = 1;
            this.bdelete.Text = "Supprimer";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.White;
            this.badd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.badd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.badd.Location = new System.Drawing.Point(16, 15);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(133, 40);
            this.badd.TabIndex = 0;
            this.badd.Text = "Ajouter";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.White;
            this.bupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bupdate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bupdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bupdate.Location = new System.Drawing.Point(16, 63);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(133, 40);
            this.bupdate.TabIndex = 2;
            this.bupdate.Text = "Modifier";
            this.bupdate.UseVisualStyleBackColor = false;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(340, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "الصف";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.tserviceAR);
            this.groupBox4.Controls.Add(this.tidservice);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tservice);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(134, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1041, 68);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "choisir un service";
            // 
            // tserviceAR
            // 
            this.tserviceAR.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tserviceAR.Location = new System.Drawing.Point(668, 29);
            this.tserviceAR.Multiline = true;
            this.tserviceAR.Name = "tserviceAR";
            this.tserviceAR.Size = new System.Drawing.Size(296, 25);
            this.tserviceAR.TabIndex = 21;
            // 
            // tidservice
            // 
            this.tidservice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidservice.FormattingEnabled = true;
            this.tidservice.Location = new System.Drawing.Point(113, 30);
            this.tidservice.Name = "tidservice";
            this.tidservice.Size = new System.Drawing.Size(62, 25);
            this.tidservice.TabIndex = 35;
            this.tidservice.SelectedIndexChanged += new System.EventHandler(this.tidservice_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(969, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "الخدمة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "N°service";
            // 
            // tservice
            // 
            this.tservice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tservice.ForeColor = System.Drawing.Color.Black;
            this.tservice.FormattingEnabled = true;
            this.tservice.Location = new System.Drawing.Point(271, 29);
            this.tservice.Name = "tservice";
            this.tservice.Size = new System.Drawing.Size(391, 25);
            this.tservice.TabIndex = 7;
            this.tservice.SelectedIndexChanged += new System.EventHandler(this.tservice_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Service :";
            // 
            // tgradeAR
            // 
            this.tgradeAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgradeAR.Location = new System.Drawing.Point(21, 85);
            this.tgradeAR.Multiline = true;
            this.tgradeAR.Name = "tgradeAR";
            this.tgradeAR.Size = new System.Drawing.Size(253, 26);
            this.tgradeAR.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(289, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "الإسم الشخصي ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tstatue);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tprenomAR);
            this.groupBox2.Controls.Add(this.tnomAR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tgradeAR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(664, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 195);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات بالعربية";
            // 
            // tstatue
            // 
            this.tstatue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tstatue.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstatue.FormattingEnabled = true;
            this.tstatue.Location = new System.Drawing.Point(112, 134);
            this.tstatue.Name = "tstatue";
            this.tstatue.Size = new System.Drawing.Size(162, 25);
            this.tstatue.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 37;
            this.label12.Text = "Statue :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(302, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "الإسم العائلي";
            // 
            // tnom
            // 
            this.tnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnom.Location = new System.Drawing.Point(143, 58);
            this.tnom.Multiline = true;
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(297, 25);
            this.tnom.TabIndex = 3;
            // 
            // tdure
            // 
            this.tdure.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdure.Location = new System.Drawing.Point(143, 142);
            this.tdure.Multiline = true;
            this.tdure.Name = "tdure";
            this.tdure.Size = new System.Drawing.Size(297, 25);
            this.tdure.TabIndex = 19;
            this.tdure.Click += new System.EventHandler(this.tdure_Click);
            this.tdure.TextChanged += new System.EventHandler(this.tdure_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Duree rest :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID dote     :";
            // 
            // tid
            // 
            this.tid.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tid.Location = new System.Drawing.Point(143, 30);
            this.tid.MaxLength = 10;
            this.tid.Multiline = true;
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(297, 25);
            this.tid.TabIndex = 1;
            this.tid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom     :";
            // 
            // tprenom
            // 
            this.tprenom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprenom.Location = new System.Drawing.Point(143, 86);
            this.tprenom.Multiline = true;
            this.tprenom.Name = "tprenom";
            this.tprenom.Size = new System.Drawing.Size(297, 25);
            this.tprenom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grade        :";
            // 
            // tgrade
            // 
            this.tgrade.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgrade.Location = new System.Drawing.Point(143, 114);
            this.tgrade.Multiline = true;
            this.tgrade.Name = "tgrade";
            this.tgrade.Size = new System.Drawing.Size(297, 25);
            this.tgrade.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tnom);
            this.groupBox1.Controls.Add(this.tdure);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tprenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tgrade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(134, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 195);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les info francais";
            // 
            // MISEAJOURSEMPLOYES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1493, 718);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MISEAJOURSEMPLOYES";
            this.Text = "MISEAJOURSEMPLOYES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MISEAJOURSEMPLOYES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox tprenomAR;
        private System.Windows.Forms.TextBox tnomAR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnew;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tserviceAR;
        private System.Windows.Forms.ComboBox tidservice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tservice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tgradeAR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.TextBox tdure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tgrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tstatue;
        private System.Windows.Forms.Label label12;
    }
}