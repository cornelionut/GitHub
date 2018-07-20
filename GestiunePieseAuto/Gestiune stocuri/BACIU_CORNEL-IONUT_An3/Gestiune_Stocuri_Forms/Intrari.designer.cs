namespace GestiuneStocuri
{
    partial class INTRARI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INTRARI));
            this.tb_Produs = new System.Windows.Forms.TextBox();
            this.tb_Cantitate = new System.Windows.Forms.TextBox();
            this.tb_Pret = new System.Windows.Forms.TextBox();
            this.tb_Valoare = new System.Windows.Forms.TextBox();
            this.lb_Produs = new System.Windows.Forms.Label();
            this.lb_Cantitate = new System.Windows.Forms.Label();
            this.lb_Pret = new System.Windows.Forms.Label();
            this.lb_Valoare = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.btn_Calculeaza = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Adauga = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_pagPrincipala = new System.Windows.Forms.Button();
            this.radio_da = new System.Windows.Forms.RadioButton();
            this.radio_nu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Produs
            // 
            this.tb_Produs.Location = new System.Drawing.Point(10, 50);
            this.tb_Produs.Name = "tb_Produs";
            this.tb_Produs.Size = new System.Drawing.Size(95, 20);
            this.tb_Produs.TabIndex = 1;
            // 
            // tb_Cantitate
            // 
            this.tb_Cantitate.Location = new System.Drawing.Point(120, 50);
            this.tb_Cantitate.Name = "tb_Cantitate";
            this.tb_Cantitate.Size = new System.Drawing.Size(95, 20);
            this.tb_Cantitate.TabIndex = 2;
            // 
            // tb_Pret
            // 
            this.tb_Pret.Location = new System.Drawing.Point(230, 50);
            this.tb_Pret.Name = "tb_Pret";
            this.tb_Pret.Size = new System.Drawing.Size(95, 20);
            this.tb_Pret.TabIndex = 3;
            this.tb_Pret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pret_KeyPress);
            // 
            // tb_Valoare
            // 
            this.tb_Valoare.Location = new System.Drawing.Point(343, 50);
            this.tb_Valoare.Name = "tb_Valoare";
            this.tb_Valoare.ReadOnly = true;
            this.tb_Valoare.Size = new System.Drawing.Size(95, 20);
            this.tb_Valoare.TabIndex = 4;
            // 
            // lb_Produs
            // 
            this.lb_Produs.AutoSize = true;
            this.lb_Produs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Produs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Produs.Location = new System.Drawing.Point(12, 30);
            this.lb_Produs.Name = "lb_Produs";
            this.lb_Produs.Size = new System.Drawing.Size(48, 17);
            this.lb_Produs.TabIndex = 5;
            this.lb_Produs.Text = "Produs";
            // 
            // lb_Cantitate
            // 
            this.lb_Cantitate.AutoSize = true;
            this.lb_Cantitate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Cantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cantitate.Location = new System.Drawing.Point(135, 30);
            this.lb_Cantitate.Name = "lb_Cantitate";
            this.lb_Cantitate.Size = new System.Drawing.Size(57, 17);
            this.lb_Cantitate.TabIndex = 6;
            this.lb_Cantitate.Text = "Cantitate";
            // 
            // lb_Pret
            // 
            this.lb_Pret.AutoSize = true;
            this.lb_Pret.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pret.Location = new System.Drawing.Point(263, 30);
            this.lb_Pret.Name = "lb_Pret";
            this.lb_Pret.Size = new System.Drawing.Size(31, 17);
            this.lb_Pret.TabIndex = 7;
            this.lb_Pret.Text = "Pret";
            // 
            // lb_Valoare
            // 
            this.lb_Valoare.AutoSize = true;
            this.lb_Valoare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Valoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Valoare.Location = new System.Drawing.Point(361, 26);
            this.lb_Valoare.Name = "lb_Valoare";
            this.lb_Valoare.Size = new System.Drawing.Size(51, 17);
            this.lb_Valoare.TabIndex = 8;
            this.lb_Valoare.Text = "Valoare";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(722, 62);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(36, 17);
            this.lb_Total.TabIndex = 9;
            this.lb_Total.Text = "Total";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(695, 82);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(95, 20);
            this.tb_Total.TabIndex = 10;
            // 
            // btn_Calculeaza
            // 
            this.btn_Calculeaza.AutoSize = true;
            this.btn_Calculeaza.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Calculeaza.Location = new System.Drawing.Point(584, 80);
            this.btn_Calculeaza.Name = "btn_Calculeaza";
            this.btn_Calculeaza.Size = new System.Drawing.Size(89, 23);
            this.btn_Calculeaza.TabIndex = 11;
            this.btn_Calculeaza.Text = "CALCULEAZA";
            this.btn_Calculeaza.UseVisualStyleBackColor = false;
            this.btn_Calculeaza.Click += new System.EventHandler(this.btn_Calculeaza_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AutoSize = true;
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Clear.Location = new System.Drawing.Point(583, 333);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(90, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Adauga
            // 
            this.btn_Adauga.AutoSize = true;
            this.btn_Adauga.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Adauga.Location = new System.Drawing.Point(583, 26);
            this.btn_Adauga.Name = "btn_Adauga";
            this.btn_Adauga.Size = new System.Drawing.Size(90, 23);
            this.btn_Adauga.TabIndex = 13;
            this.btn_Adauga.Text = "PRODUS NOU";
            this.btn_Adauga.UseVisualStyleBackColor = false;
            this.btn_Adauga.Click += new System.EventHandler(this.btn_Adauga_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_pagPrincipala
            // 
            this.btn_pagPrincipala.AutoSize = true;
            this.btn_pagPrincipala.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_pagPrincipala.Location = new System.Drawing.Point(701, 333);
            this.btn_pagPrincipala.Name = "btn_pagPrincipala";
            this.btn_pagPrincipala.Size = new System.Drawing.Size(89, 23);
            this.btn_pagPrincipala.TabIndex = 15;
            this.btn_pagPrincipala.Text = "BACK";
            this.btn_pagPrincipala.UseVisualStyleBackColor = false;
            this.btn_pagPrincipala.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // radio_da
            // 
            this.radio_da.AutoSize = true;
            this.radio_da.Location = new System.Drawing.Point(473, 51);
            this.radio_da.Name = "radio_da";
            this.radio_da.Size = new System.Drawing.Size(39, 17);
            this.radio_da.TabIndex = 18;
            this.radio_da.TabStop = true;
            this.radio_da.Text = "Da";
            this.radio_da.UseVisualStyleBackColor = true;
            // 
            // radio_nu
            // 
            this.radio_nu.AutoSize = true;
            this.radio_nu.Location = new System.Drawing.Point(518, 51);
            this.radio_nu.Name = "radio_nu";
            this.radio_nu.Size = new System.Drawing.Size(39, 17);
            this.radio_nu.TabIndex = 19;
            this.radio_nu.TabStop = true;
            this.radio_nu.Text = "Nu";
            this.radio_nu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(473, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "TVA inclus?";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(584, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "TIPARESTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(695, 164);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(100, 20);
            this.tb_discount.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(695, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Total cu Discount";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(584, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "&DISCOUNT 10%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // INTRARI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(814, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_discount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_nu);
            this.Controls.Add(this.radio_da);
            this.Controls.Add(this.btn_pagPrincipala);
            this.Controls.Add(this.btn_Adauga);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculeaza);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.lb_Valoare);
            this.Controls.Add(this.lb_Pret);
            this.Controls.Add(this.lb_Cantitate);
            this.Controls.Add(this.lb_Produs);
            this.Controls.Add(this.tb_Valoare);
            this.Controls.Add(this.tb_Pret);
            this.Controls.Add(this.tb_Cantitate);
            this.Controls.Add(this.tb_Produs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "INTRARI";
            this.Text = "BonFiscal";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Produs;
        private System.Windows.Forms.TextBox tb_Cantitate;
        private System.Windows.Forms.TextBox tb_Pret;
        private System.Windows.Forms.TextBox tb_Valoare;
        private System.Windows.Forms.Label lb_Produs;
        private System.Windows.Forms.Label lb_Cantitate;
        private System.Windows.Forms.Label lb_Pret;
        private System.Windows.Forms.Label lb_Valoare;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Button btn_Calculeaza;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Adauga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_pagPrincipala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_nu;
        private System.Windows.Forms.RadioButton radio_da;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_discount;
    }
}