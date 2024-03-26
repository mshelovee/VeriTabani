namespace VeriTabanı___96
{
    partial class Form1
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.AllowUserToAddRows = false;
            this.dgwFilmler.AllowUserToDeleteRows = false;
            this.dgwFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFilmler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(14, 296);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.ReadOnly = true;
            this.dgwFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFilmler.Size = new System.Drawing.Size(747, 252);
            this.dgwFilmler.TabIndex = 0;
            this.dgwFilmler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFilmler_CellEnter);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(31, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(133, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(31, 120);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(133, 20);
            this.txtYonetmen.TabIndex = 2;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(31, 242);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(133, 20);
            this.txtSure.TabIndex = 3;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(31, 182);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(133, 20);
            this.txtYil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yıl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yönetmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Süre";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(195, 182);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 80);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "♻";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(773, 560);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

