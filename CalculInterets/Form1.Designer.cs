namespace CalculInterets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCapitalDepart = new Label();
            lblTauxInterets = new Label();
            lblNombreAnnees = new Label();
            txtCapitalDepart = new TextBox();
            txtNombreAnnees = new TextBox();
            txtTauxInteret = new TextBox();
            btnCalculer = new Button();
            btnRaz = new Button();
            btnQuitter = new Button();
            lblResultat = new Label();
            SuspendLayout();
            // 
            // lblCapitalDepart
            // 
            lblCapitalDepart.AutoSize = true;
            lblCapitalDepart.Location = new Point(94, 127);
            lblCapitalDepart.Name = "lblCapitalDepart";
            lblCapitalDepart.Size = new Size(292, 32);
            lblCapitalDepart.TabIndex = 0;
            lblCapitalDepart.Text = "Entrez le capital de départ";
            // 
            // lblTauxInterets
            // 
            lblTauxInterets.AutoSize = true;
            lblTauxInterets.Location = new Point(94, 190);
            lblTauxInterets.Name = "lblTauxInterets";
            lblTauxInterets.Size = new Size(255, 32);
            lblTauxInterets.TabIndex = 1;
            lblTauxInterets.Text = "Entrez le taux d'interet";
            // 
            // lblNombreAnnees
            // 
            lblNombreAnnees.AutoSize = true;
            lblNombreAnnees.Location = new Point(94, 251);
            lblNombreAnnees.Name = "lblNombreAnnees";
            lblNombreAnnees.Size = new Size(300, 32);
            lblNombreAnnees.TabIndex = 2;
            lblNombreAnnees.Text = "Entrez le nombre d'années";
            // 
            // txtCapitalDepart
            // 
            txtCapitalDepart.Location = new Point(414, 120);
            txtCapitalDepart.Name = "txtCapitalDepart";
            txtCapitalDepart.Size = new Size(200, 39);
            txtCapitalDepart.TabIndex = 3;
            txtCapitalDepart.KeyPress += txtCapitalDepart_KeyPress;
            txtCapitalDepart.Leave += txtCapitalDepart_Leave;
            // 
            // txtNombreAnnees
            // 
            txtNombreAnnees.Location = new Point(414, 248);
            txtNombreAnnees.Name = "txtNombreAnnees";
            txtNombreAnnees.Size = new Size(200, 39);
            txtNombreAnnees.TabIndex = 4;
            txtNombreAnnees.KeyPress += txtNombreAnnees_KeyPress;
            // 
            // txtTauxInteret
            // 
            txtTauxInteret.Location = new Point(414, 183);
            txtTauxInteret.Name = "txtTauxInteret";
            txtTauxInteret.Size = new Size(200, 39);
            txtTauxInteret.TabIndex = 5;
            txtTauxInteret.KeyPress += txtTauxInteret_KeyPress;
            txtTauxInteret.Leave += txtTauxInteret_Leave;
            // 
            // btnCalculer
            // 
            btnCalculer.Location = new Point(584, 450);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(150, 46);
            btnCalculer.TabIndex = 6;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = true;
            btnCalculer.Click += btnCalculer_Click;
            // 
            // btnRaz
            // 
            btnRaz.Location = new Point(414, 450);
            btnRaz.Name = "btnRaz";
            btnRaz.Size = new Size(150, 46);
            btnRaz.TabIndex = 7;
            btnRaz.Text = "RAZ";
            btnRaz.UseVisualStyleBackColor = true;
            btnRaz.Click += btnRaz_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(765, 450);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(150, 46);
            btnQuitter.TabIndex = 8;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.Location = new Point(96, 336);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(117, 32);
            lblResultat.TabIndex = 9;
            lblResultat.Text = "Resultat : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 521);
            Controls.Add(lblResultat);
            Controls.Add(btnQuitter);
            Controls.Add(btnRaz);
            Controls.Add(btnCalculer);
            Controls.Add(txtTauxInteret);
            Controls.Add(txtNombreAnnees);
            Controls.Add(txtCapitalDepart);
            Controls.Add(lblNombreAnnees);
            Controls.Add(lblTauxInterets);
            Controls.Add(lblCapitalDepart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCapitalDepart;
        private Label lblTauxInterets;
        private Label lblNombreAnnees;
        private TextBox txtCapitalDepart;
        private TextBox txtNombreAnnees;
        private TextBox txtTauxInteret;
        private Button btnCalculer;
        private Button btnRaz;
        private Button btnQuitter;
        private Label lblResultat;
    }
}