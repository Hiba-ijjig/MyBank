
namespace UI_Bank
{
    
    partial class Auth
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SeConnecter = new System.Windows.Forms.Panel();
            this.connecter = new System.Windows.Forms.Button();
            this.creation = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.creer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SeConnecter.SuspendLayout();
            this.creation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Se connecter";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Gainsboro;
            this.login.Location = new System.Drawing.Point(158, 71);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(204, 20);
            this.login.TabIndex = 2;
            // 
            // mdp
            // 
            this.mdp.BackColor = System.Drawing.Color.Gainsboro;
            this.mdp.Location = new System.Drawing.Point(158, 130);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(204, 20);
            this.mdp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(54, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "MDP: ";
            // 
            // SeConnecter
            // 
            this.SeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SeConnecter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeConnecter.Controls.Add(this.connecter);
            this.SeConnecter.Controls.Add(this.label2);
            this.SeConnecter.Controls.Add(this.label4);
            this.SeConnecter.Controls.Add(this.label3);
            this.SeConnecter.Controls.Add(this.login);
            this.SeConnecter.Controls.Add(this.mdp);
            this.SeConnecter.Location = new System.Drawing.Point(246, 246);
            this.SeConnecter.Name = "SeConnecter";
            this.SeConnecter.Size = new System.Drawing.Size(433, 215);
            this.SeConnecter.TabIndex = 6;
            // 
            // connecter
            // 
            this.connecter.BackColor = System.Drawing.Color.DarkGray;
            this.connecter.Location = new System.Drawing.Point(343, 179);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(75, 23);
            this.connecter.TabIndex = 6;
            this.connecter.Text = "Valider";
            this.connecter.UseVisualStyleBackColor = false;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // creation
            // 
            this.creation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.creation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creation.Controls.Add(this.label11);
            this.creation.Controls.Add(this.label10);
            this.creation.Controls.Add(this.label9);
            this.creation.Controls.Add(this.pwd);
            this.creation.Controls.Add(this.label8);
            this.creation.Controls.Add(this.creer);
            this.creation.Controls.Add(this.label5);
            this.creation.Controls.Add(this.label6);
            this.creation.Controls.Add(this.label7);
            this.creation.Controls.Add(this.fn);
            this.creation.Controls.Add(this.ln);
            this.creation.Location = new System.Drawing.Point(246, 13);
            this.creation.Name = "creation";
            this.creation.Size = new System.Drawing.Size(433, 227);
            this.creation.TabIndex = 7;
            this.creation.Paint += new System.Windows.Forms.PaintEventHandler(this.creation_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(145, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "prenom.nom@mybank";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Votre login sera sous la forme suivante:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(38, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Login:";
            // 
            // pwd
            // 
            this.pwd.BackColor = System.Drawing.Color.Gainsboro;
            this.pwd.Location = new System.Drawing.Point(115, 123);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(204, 20);
            this.pwd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(48, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "mdp:";
            // 
            // creer
            // 
            this.creer.BackColor = System.Drawing.Color.DarkGray;
            this.creer.Location = new System.Drawing.Point(343, 190);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 6;
            this.creer.Text = "Valider";
            this.creer.UseVisualStyleBackColor = false;
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Créer compte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(8, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fist name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last name:";
            // 
            // fn
            // 
            this.fn.BackColor = System.Drawing.Color.Gainsboro;
            this.fn.Location = new System.Drawing.Point(115, 53);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(204, 20);
            this.fn.TabIndex = 2;
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.Gainsboro;
            this.ln.Location = new System.Drawing.Point(115, 88);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(204, 20);
            this.ln.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 467);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyBank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(780, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.creation);
            this.Controls.Add(this.SeConnecter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Auth";
            this.Text = "MyBank";
            this.Load += new System.EventHandler(this.firstPage_Load);
            this.SeConnecter.ResumeLayout(false);
            this.SeConnecter.PerformLayout();
            this.creation.ResumeLayout(false);
            this.creation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SeConnecter;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Panel creation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Button creer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

