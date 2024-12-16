namespace GestionTheatreGUI
{
    partial class Dashboard
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
            this.pieceButton = new System.Windows.Forms.Button();
            this.syntheseButton = new System.Windows.Forms.Button();
            this.reservationButton = new System.Windows.Forms.Button();
            this.representationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pieceButton
            // 
            this.pieceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.pieceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pieceButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceButton.ForeColor = System.Drawing.Color.White;
            this.pieceButton.Location = new System.Drawing.Point(99, 158);
            this.pieceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pieceButton.Name = "pieceButton";
            this.pieceButton.Size = new System.Drawing.Size(252, 50);
            this.pieceButton.TabIndex = 1;
            this.pieceButton.Text = "Pièces";
            this.pieceButton.UseVisualStyleBackColor = false;
            this.pieceButton.Click += new System.EventHandler(this.pieceButton_Click);
            // 
            // syntheseButton
            // 
            this.syntheseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.syntheseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syntheseButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntheseButton.ForeColor = System.Drawing.Color.White;
            this.syntheseButton.Location = new System.Drawing.Point(99, 60);
            this.syntheseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.syntheseButton.Name = "syntheseButton";
            this.syntheseButton.Size = new System.Drawing.Size(252, 50);
            this.syntheseButton.TabIndex = 0;
            this.syntheseButton.Text = "Synthèse";
            this.syntheseButton.UseVisualStyleBackColor = false;
            // 
            // reservationButton
            // 
            this.reservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.reservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationButton.ForeColor = System.Drawing.Color.White;
            this.reservationButton.Location = new System.Drawing.Point(395, 60);
            this.reservationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(252, 50);
            this.reservationButton.TabIndex = 2;
            this.reservationButton.Text = "Réservations";
            this.reservationButton.UseVisualStyleBackColor = false;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // representationButton
            // 
            this.representationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.representationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.representationButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.representationButton.ForeColor = System.Drawing.Color.White;
            this.representationButton.Location = new System.Drawing.Point(395, 158);
            this.representationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.representationButton.Name = "representationButton";
            this.representationButton.Size = new System.Drawing.Size(252, 50);
            this.representationButton.TabIndex = 3;
            this.representationButton.Text = "Représentations";
            this.representationButton.UseVisualStyleBackColor = false;
            this.representationButton.Click += new System.EventHandler(this.representationButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 274);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.representationButton);
            this.Controls.Add(this.syntheseButton);
            this.Controls.Add(this.pieceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pieceButton;
        private System.Windows.Forms.Button syntheseButton;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button representationButton;
    }
}