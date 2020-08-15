namespace GESTIONDESCONGES2
{
    partial class typeConge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(typeConge));
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bsupprimer = new System.Windows.Forms.Button();
            this.bmodifier = new System.Windows.Forms.Button();
            this.bajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tlebeleconge = new System.Windows.Forms.RichTextBox();
            this.tnbjours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "(jours)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 27);
            this.button4.TabIndex = 23;
            this.button4.Text = "Fermmer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bsupprimer
            // 
            this.bsupprimer.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupprimer.Location = new System.Drawing.Point(444, 100);
            this.bsupprimer.Name = "bsupprimer";
            this.bsupprimer.Size = new System.Drawing.Size(87, 28);
            this.bsupprimer.TabIndex = 22;
            this.bsupprimer.Text = "Supprimer";
            this.bsupprimer.UseVisualStyleBackColor = true;
            this.bsupprimer.Click += new System.EventHandler(this.bsupprimer_Click);
            // 
            // bmodifier
            // 
            this.bmodifier.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodifier.Location = new System.Drawing.Point(444, 62);
            this.bmodifier.Name = "bmodifier";
            this.bmodifier.Size = new System.Drawing.Size(87, 28);
            this.bmodifier.TabIndex = 21;
            this.bmodifier.Text = "Modifier";
            this.bmodifier.UseVisualStyleBackColor = true;
            this.bmodifier.Click += new System.EventHandler(this.bmodifier_Click);
            // 
            // bajouter
            // 
            this.bajouter.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajouter.Location = new System.Drawing.Point(444, 25);
            this.bajouter.Name = "bajouter";
            this.bajouter.Size = new System.Drawing.Size(87, 28);
            this.bajouter.TabIndex = 20;
            this.bajouter.Text = "Ajouter";
            this.bajouter.UseVisualStyleBackColor = true;
            this.bajouter.Click += new System.EventHandler(this.bajouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 253);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tlebeleconge
            // 
            this.tlebeleconge.Location = new System.Drawing.Point(130, 36);
            this.tlebeleconge.Name = "tlebeleconge";
            this.tlebeleconge.Size = new System.Drawing.Size(249, 54);
            this.tlebeleconge.TabIndex = 18;
            this.tlebeleconge.Text = "";
            // 
            // tnbjours
            // 
            this.tnbjours.Location = new System.Drawing.Point(130, 96);
            this.tnbjours.Multiline = true;
            this.tnbjours.Name = "tnbjours";
            this.tnbjours.Size = new System.Drawing.Size(40, 26);
            this.tnbjours.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre de jours :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Libelle de conge :";
            // 
            // tnumero
            // 
            this.tnumero.Location = new System.Drawing.Point(207, 4);
            this.tnumero.Multiline = true;
            this.tnumero.Name = "tnumero";
            this.tnumero.ReadOnly = true;
            this.tnumero.Size = new System.Drawing.Size(40, 26);
            this.tnumero.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "N° :";
            // 
            // typeConge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(667, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bsupprimer);
            this.Controls.Add(this.bmodifier);
            this.Controls.Add(this.bajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tlebeleconge);
            this.Controls.Add(this.tnbjours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tnumero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "typeConge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "typeConge";
            this.Load += new System.EventHandler(this.typeConge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bsupprimer;
        private System.Windows.Forms.Button bmodifier;
        private System.Windows.Forms.Button bajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox tlebeleconge;
        private System.Windows.Forms.TextBox tnbjours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tnumero;
        private System.Windows.Forms.Label label1;
    }
}