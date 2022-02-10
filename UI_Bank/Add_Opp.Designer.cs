
namespace UI_Bank
{
    partial class Add_Opp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nom = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.LinkLabel();
            this.retrait = new System.Windows.Forms.LinkLabel();
            this.verser = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.add_somme = new System.Windows.Forms.Panel();
            this.valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.TextBox();
            this.lst_cpt = new System.Windows.Forms.ComboBox();
            this.vers = new System.Windows.Forms.Panel();
            this.ok = new System.Windows.Forms.Button();
            this.m_op = new System.Windows.Forms.TextBox();
            this.mycpt = new System.Windows.Forms.ComboBox();
            this.hiscpt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.add_somme.SuspendLayout();
            this.vers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.retrait);
            this.panel1.Controls.Add(this.verser);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 450);
            this.panel1.TabIndex = 10;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nom.Location = new System.Drawing.Point(31, 72);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(54, 19);
            this.nom.TabIndex = 10;
            this.nom.Text = "label2";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.LinkColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(27, 116);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(130, 17);
            this.add.TabIndex = 9;
            this.add.TabStop = true;
            this.add.Text = "Ajouter une somme";
            this.add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.add_LinkClicked);
            // 
            // retrait
            // 
            this.retrait.AutoSize = true;
            this.retrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrait.LinkColor = System.Drawing.Color.White;
            this.retrait.Location = new System.Drawing.Point(32, 155);
            this.retrait.Name = "retrait";
            this.retrait.Size = new System.Drawing.Size(50, 17);
            this.retrait.TabIndex = 8;
            this.retrait.TabStop = true;
            this.retrait.Text = "Retrait";
            // 
            // verser
            // 
            this.verser.AutoSize = true;
            this.verser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verser.LinkColor = System.Drawing.Color.White;
            this.verser.Location = new System.Drawing.Point(32, 191);
            this.verser.Name = "verser";
            this.verser.Size = new System.Drawing.Size(50, 17);
            this.verser.TabIndex = 7;
            this.verser.TabStop = true;
            this.verser.Text = "Verser";
            this.verser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.verser_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(25, 72);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 17);
            this.linkLabel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyBank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_somme
            // 
            this.add_somme.Controls.Add(this.valider);
            this.add_somme.Controls.Add(this.label2);
            this.add_somme.Controls.Add(this.Cname);
            this.add_somme.Controls.Add(this.montant);
            this.add_somme.Controls.Add(this.lst_cpt);
            this.add_somme.Location = new System.Drawing.Point(229, 29);
            this.add_somme.Name = "add_somme";
            this.add_somme.Size = new System.Drawing.Size(513, 179);
            this.add_somme.TabIndex = 11;
            this.add_somme.Visible = false;
            this.add_somme.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.DarkGray;
            this.valider.Location = new System.Drawing.Point(411, 135);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 7;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Montant de l\'opération:";
            // 
            // Cname
            // 
            this.Cname.AutoSize = true;
            this.Cname.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cname.Location = new System.Drawing.Point(16, 41);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(191, 19);
            this.Cname.TabIndex = 3;
            this.Cname.Text = "Choisissez votre compte:";
            // 
            // montant
            // 
            this.montant.Location = new System.Drawing.Point(241, 110);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(121, 20);
            this.montant.TabIndex = 1;
            // 
            // lst_cpt
            // 
            this.lst_cpt.FormattingEnabled = true;
            this.lst_cpt.Location = new System.Drawing.Point(241, 39);
            this.lst_cpt.Name = "lst_cpt";
            this.lst_cpt.Size = new System.Drawing.Size(121, 21);
            this.lst_cpt.TabIndex = 0;
            this.lst_cpt.SelectedIndexChanged += new System.EventHandler(this.lst_cpt_SelectedIndexChanged);
            // 
            // vers
            // 
            this.vers.Controls.Add(this.ok);
            this.vers.Controls.Add(this.m_op);
            this.vers.Controls.Add(this.mycpt);
            this.vers.Controls.Add(this.hiscpt);
            this.vers.Controls.Add(this.label5);
            this.vers.Controls.Add(this.label4);
            this.vers.Controls.Add(this.label3);
            this.vers.Location = new System.Drawing.Point(229, 239);
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(513, 182);
            this.vers.TabIndex = 12;
            this.vers.Visible = false;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.DarkGray;
            this.ok.Location = new System.Drawing.Point(411, 139);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 10;
            this.ok.Text = "Valider";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // m_op
            // 
            this.m_op.Location = new System.Drawing.Point(323, 113);
            this.m_op.Name = "m_op";
            this.m_op.Size = new System.Drawing.Size(121, 20);
            this.m_op.TabIndex = 9;
            // 
            // mycpt
            // 
            this.mycpt.FormattingEnabled = true;
            this.mycpt.Location = new System.Drawing.Point(323, 21);
            this.mycpt.Name = "mycpt";
            this.mycpt.Size = new System.Drawing.Size(121, 21);
            this.mycpt.TabIndex = 8;
            this.mycpt.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // hiscpt
            // 
            this.hiscpt.FormattingEnabled = true;
            this.hiscpt.Location = new System.Drawing.Point(323, 66);
            this.hiscpt.Name = "hiscpt";
            this.hiscpt.Size = new System.Drawing.Size(121, 21);
            this.hiscpt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Montant de l\'opération:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choisissez le compte du destinataire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choisissez votre compte:";
            // 
            // Add_Opp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vers);
            this.Controls.Add(this.add_somme);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Opp";
            this.Text = "Add_Opp";
            this.Load += new System.EventHandler(this.Add_Opp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.add_somme.ResumeLayout(false);
            this.add_somme.PerformLayout();
            this.vers.ResumeLayout(false);
            this.vers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel add_somme;
        private System.Windows.Forms.Panel vers;
        private System.Windows.Forms.LinkLabel add;
        private System.Windows.Forms.LinkLabel retrait;
        private System.Windows.Forms.LinkLabel verser;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.ComboBox lst_cpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cname;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox m_op;
        private System.Windows.Forms.ComboBox mycpt;
        private System.Windows.Forms.ComboBox hiscpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ok;
    }
}