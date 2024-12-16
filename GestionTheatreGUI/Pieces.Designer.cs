using System.Windows.Forms;

namespace GestionTheatreGUI
{
    partial class Pieces
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pieceGridView = new System.Windows.Forms.DataGridView();
            this.gestion_theatresDataSet = new GestionTheatreGUI.gestion_theatresDataSet();
            this.pieceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pieceTableAdapter = new GestionTheatreGUI.gestion_theatresDataSetTableAdapters.pieceTableAdapter();
            this.idpieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionpieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureepieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifpieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idthemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtpublicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idauteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcompagnieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tarifTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.auteurComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.publicComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.compagnieComboBox = new System.Windows.Forms.ComboBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTarif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTheme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAuteur = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPublic = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCompagnie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pieceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_theatresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCompagnie)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1075, 390);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(247, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderName.SetIconAlignment(this.nameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderName.SetIconPadding(this.nameTextBox, 2);
            this.nameTextBox.Location = new System.Drawing.Point(163, 508);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(399, 27);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // pieceGridView
            // 
            this.pieceGridView.AllowUserToAddRows = false;
            this.pieceGridView.AllowUserToDeleteRows = false;
            this.pieceGridView.AllowUserToOrderColumns = true;
            this.pieceGridView.AllowUserToResizeColumns = false;
            this.pieceGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.pieceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.pieceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pieceGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pieceGridView.BackgroundColor = System.Drawing.Color.White;
            this.pieceGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pieceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.pieceGridView.ColumnHeadersHeight = 40;
            this.pieceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pieceGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.pieceGridView.EnableHeadersVisualStyles = false;
            this.pieceGridView.GridColor = System.Drawing.Color.White;
            this.pieceGridView.Location = new System.Drawing.Point(16, 15);
            this.pieceGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pieceGridView.MultiSelect = false;
            this.pieceGridView.Name = "pieceGridView";
            this.pieceGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pieceGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.pieceGridView.RowHeadersVisible = false;
            this.pieceGridView.RowHeadersWidth = 120;
            this.pieceGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pieceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pieceGridView.ShowCellErrors = false;
            this.pieceGridView.ShowCellToolTips = false;
            this.pieceGridView.ShowEditingIcon = false;
            this.pieceGridView.ShowRowErrors = false;
            this.pieceGridView.Size = new System.Drawing.Size(1304, 369);
            this.pieceGridView.TabIndex = 0;
            // 
            // gestion_theatresDataSet
            // 
            this.gestion_theatresDataSet.DataSetName = "gestion_theatresDataSet";
            this.gestion_theatresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pieceTableAdapter
            // 
            this.pieceTableAdapter.ClearBeforeFill = true;
            // 
            // idpieceDataGridViewTextBoxColumn
            // 
            this.idpieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpieceDataGridViewTextBoxColumn.Name = "idpieceDataGridViewTextBoxColumn";
            this.idpieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nompieceDataGridViewTextBoxColumn
            // 
            this.nompieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nompieceDataGridViewTextBoxColumn.Name = "nompieceDataGridViewTextBoxColumn";
            this.nompieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionpieceDataGridViewTextBoxColumn
            // 
            this.descriptionpieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionpieceDataGridViewTextBoxColumn.Name = "descriptionpieceDataGridViewTextBoxColumn";
            this.descriptionpieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dureepieceDataGridViewTextBoxColumn
            // 
            this.dureepieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dureepieceDataGridViewTextBoxColumn.Name = "dureepieceDataGridViewTextBoxColumn";
            this.dureepieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarifpieceDataGridViewTextBoxColumn
            // 
            this.tarifpieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifpieceDataGridViewTextBoxColumn.Name = "tarifpieceDataGridViewTextBoxColumn";
            this.tarifpieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // idthemeDataGridViewTextBoxColumn
            // 
            this.idthemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idthemeDataGridViewTextBoxColumn.Name = "idthemeDataGridViewTextBoxColumn";
            this.idthemeDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtpublicDataGridViewTextBoxColumn
            // 
            this.idtpublicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtpublicDataGridViewTextBoxColumn.Name = "idtpublicDataGridViewTextBoxColumn";
            this.idtpublicDataGridViewTextBoxColumn.Width = 125;
            // 
            // idauteurDataGridViewTextBoxColumn
            // 
            this.idauteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idauteurDataGridViewTextBoxColumn.Name = "idauteurDataGridViewTextBoxColumn";
            this.idauteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcompagnieDataGridViewTextBoxColumn
            // 
            this.idcompagnieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcompagnieDataGridViewTextBoxColumn.Name = "idcompagnieDataGridViewTextBoxColumn";
            this.idcompagnieDataGridViewTextBoxColumn.Width = 125;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(823, 390);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(247, 50);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Modifier";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(155, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tarif";
            // 
            // tarifTextBox
            // 
            this.tarifTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarifTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderTarif.SetIconAlignment(this.tarifTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderTarif.SetIconPadding(this.tarifTextBox, 2);
            this.tarifTextBox.Location = new System.Drawing.Point(163, 588);
            this.tarifTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tarifTextBox.Name = "tarifTextBox";
            this.tarifTextBox.Size = new System.Drawing.Size(399, 27);
            this.tarifTextBox.TabIndex = 4;
            this.tarifTextBox.TextChanged += new System.EventHandler(this.tarifTextBox_TextChanged);
            this.tarifTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.tarifTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(155, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Durée (minutes)";
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderTime.SetIconAlignment(this.timeTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderTime.SetIconPadding(this.timeTextBox, 2);
            this.timeTextBox.Location = new System.Drawing.Point(163, 668);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(399, 27);
            this.timeTextBox.TabIndex = 5;
            this.timeTextBox.TextChanged += new System.EventHandler(this.timeTextBox_TextChanged);
            this.timeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.timeTextBox_Validating);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(823, 874);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(247, 50);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(1075, 874);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(247, 50);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // themeComboBox
            // 
            this.themeComboBox.BackColor = System.Drawing.Color.White;
            this.themeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeComboBox.ForeColor = System.Drawing.Color.Black;
            this.themeComboBox.FormattingEnabled = true;
            this.errorProviderTheme.SetIconAlignment(this.themeComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderTheme.SetIconPadding(this.themeComboBox, 2);
            this.themeComboBox.Location = new System.Drawing.Point(773, 508);
            this.themeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(399, 27);
            this.themeComboBox.TabIndex = 7;
            this.themeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.themeComboBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(765, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thème";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(765, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Auteur";
            // 
            // auteurComboBox
            // 
            this.auteurComboBox.BackColor = System.Drawing.Color.White;
            this.auteurComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auteurComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteurComboBox.ForeColor = System.Drawing.Color.Black;
            this.auteurComboBox.FormattingEnabled = true;
            this.errorProviderAuteur.SetIconAlignment(this.auteurComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderAuteur.SetIconPadding(this.auteurComboBox, 2);
            this.auteurComboBox.Location = new System.Drawing.Point(773, 588);
            this.auteurComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.auteurComboBox.Name = "auteurComboBox";
            this.auteurComboBox.Size = new System.Drawing.Size(399, 27);
            this.auteurComboBox.TabIndex = 8;
            this.auteurComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.auteurComboBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(765, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Type de publique";
            // 
            // publicComboBox
            // 
            this.publicComboBox.BackColor = System.Drawing.Color.White;
            this.publicComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publicComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicComboBox.ForeColor = System.Drawing.Color.Black;
            this.publicComboBox.FormattingEnabled = true;
            this.errorProviderPublic.SetIconAlignment(this.publicComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderPublic.SetIconPadding(this.publicComboBox, 2);
            this.publicComboBox.Location = new System.Drawing.Point(773, 668);
            this.publicComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicComboBox.Name = "publicComboBox";
            this.publicComboBox.Size = new System.Drawing.Size(399, 27);
            this.publicComboBox.TabIndex = 9;
            this.publicComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.publicComboBox_Validating);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderDescription.SetIconAlignment(this.descriptionTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderDescription.SetIconPadding(this.descriptionTextBox, 2);
            this.descriptionTextBox.Location = new System.Drawing.Point(163, 750);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(521, 123);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(155, 729);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(765, 729);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Compagnie";
            // 
            // compagnieComboBox
            // 
            this.compagnieComboBox.BackColor = System.Drawing.Color.White;
            this.compagnieComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compagnieComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compagnieComboBox.ForeColor = System.Drawing.Color.Black;
            this.compagnieComboBox.FormattingEnabled = true;
            this.errorProviderCompagnie.SetIconAlignment(this.compagnieComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderCompagnie.SetIconPadding(this.compagnieComboBox, 2);
            this.compagnieComboBox.Location = new System.Drawing.Point(773, 750);
            this.compagnieComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compagnieComboBox.Name = "compagnieComboBox";
            this.compagnieComboBox.Size = new System.Drawing.Size(399, 27);
            this.compagnieComboBox.TabIndex = 10;
            this.compagnieComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.compagnieComboBox_Validating);
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkRate = 1000;
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderTarif
            // 
            this.errorProviderTarif.BlinkRate = 1000;
            this.errorProviderTarif.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTarif.ContainerControl = this;
            // 
            // errorProviderTime
            // 
            this.errorProviderTime.BlinkRate = 1000;
            this.errorProviderTime.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTime.ContainerControl = this;
            // 
            // errorProviderDescription
            // 
            this.errorProviderDescription.BlinkRate = 1000;
            this.errorProviderDescription.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDescription.ContainerControl = this;
            // 
            // errorProviderTheme
            // 
            this.errorProviderTheme.BlinkRate = 1000;
            this.errorProviderTheme.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTheme.ContainerControl = this;
            // 
            // errorProviderAuteur
            // 
            this.errorProviderAuteur.BlinkRate = 1000;
            this.errorProviderAuteur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAuteur.ContainerControl = this;
            // 
            // errorProviderPublic
            // 
            this.errorProviderPublic.BlinkRate = 1000;
            this.errorProviderPublic.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPublic.ContainerControl = this;
            // 
            // errorProviderCompagnie
            // 
            this.errorProviderCompagnie.BlinkRate = 1000;
            this.errorProviderCompagnie.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCompagnie.ContainerControl = this;
            // 
            // Pieces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1336, 935);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.compagnieComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.publicComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.auteurComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tarifTextBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.pieceGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deleteButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pieces";
            this.ShowIcon = false;
            this.Text = "Pièces";
            this.Load += new System.EventHandler(this.Pieces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_theatresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCompagnie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView pieceGridView;
        private gestion_theatresDataSet gestion_theatresDataSet;
        private System.Windows.Forms.BindingSource pieceBindingSource;
        private gestion_theatresDataSetTableAdapters.pieceTableAdapter pieceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionpieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureepieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifpieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idthemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtpublicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompagnieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tarifTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox auteurComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox publicComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox compagnieComboBox;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private ErrorProvider errorProviderTarif;
        private ErrorProvider errorProviderTime;
        private ErrorProvider errorProviderDescription;
        private ErrorProvider errorProviderTheme;
        private ErrorProvider errorProviderAuteur;
        private ErrorProvider errorProviderPublic;
        private ErrorProvider errorProviderCompagnie;
    }
}