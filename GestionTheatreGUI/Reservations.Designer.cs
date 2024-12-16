namespace GestionTheatreGUI
{
    partial class Reservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reservationsGridView = new System.Windows.Forms.DataGridView();
            this.gestion_theatresDataSet = new GestionTheatreGUI.gestion_theatresDataSet();
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderRepresentation = new System.Windows.Forms.ErrorProvider(this.components);
            this.representationComboBox = new System.Windows.Forms.ComboBox();
            this.representationLabel = new System.Windows.Forms.Label();
            this.tarifByPlaceTextBox = new System.Windows.Forms.TextBox();
            this.tarifLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.telLabel = new System.Windows.Forms.Label();
            this.resultTarifTextBox = new System.Windows.Forms.TextBox();
            this.resultTarifLabel = new System.Windows.Forms.Label();
            this.nbPlaceTextBox = new System.Windows.Forms.TextBox();
            this.nbPlaceLabel = new System.Windows.Forms.Label();
            this.pieceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNbPlace = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_theatresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNbPlace)).BeginInit();
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
            // reservationsGridView
            // 
            this.reservationsGridView.AllowUserToAddRows = false;
            this.reservationsGridView.AllowUserToDeleteRows = false;
            this.reservationsGridView.AllowUserToOrderColumns = true;
            this.reservationsGridView.AllowUserToResizeColumns = false;
            this.reservationsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.reservationsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reservationsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reservationsGridView.BackgroundColor = System.Drawing.Color.White;
            this.reservationsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reservationsGridView.ColumnHeadersHeight = 40;
            this.reservationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.reservationsGridView.EnableHeadersVisualStyles = false;
            this.reservationsGridView.GridColor = System.Drawing.Color.White;
            this.reservationsGridView.Location = new System.Drawing.Point(16, 15);
            this.reservationsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsGridView.MultiSelect = false;
            this.reservationsGridView.Name = "reservationsGridView";
            this.reservationsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.reservationsGridView.RowHeadersVisible = false;
            this.reservationsGridView.RowHeadersWidth = 120;
            this.reservationsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reservationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationsGridView.ShowCellErrors = false;
            this.reservationsGridView.ShowCellToolTips = false;
            this.reservationsGridView.ShowEditingIcon = false;
            this.reservationsGridView.ShowRowErrors = false;
            this.reservationsGridView.Size = new System.Drawing.Size(1304, 369);
            this.reservationsGridView.TabIndex = 0;
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
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(823, 843);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(247, 50);
            this.addButton.TabIndex = 12;
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
            this.cancelButton.Location = new System.Drawing.Point(1075, 843);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(247, 50);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.Black;
            this.firstNameLabel.Location = new System.Drawing.Point(159, 566);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(66, 19);
            this.firstNameLabel.TabIndex = 20;
            this.firstNameLabel.Text = "Prénom";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderFirstName.SetIconAlignment(this.firstNameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFirstName.SetIconPadding(this.firstNameTextBox, 2);
            this.firstNameTextBox.Location = new System.Drawing.Point(163, 589);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(399, 27);
            this.firstNameTextBox.TabIndex = 11;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            // 
            // errorProviderRepresentation
            // 
            this.errorProviderRepresentation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRepresentation.ContainerControl = this;
            // 
            // representationComboBox
            // 
            this.representationComboBox.BackColor = System.Drawing.Color.White;
            this.representationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.representationComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.representationComboBox.ForeColor = System.Drawing.Color.Black;
            this.representationComboBox.FormattingEnabled = true;
            this.errorProviderRepresentation.SetIconAlignment(this.representationComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderRepresentation.SetIconPadding(this.representationComboBox, 2);
            this.representationComboBox.Location = new System.Drawing.Point(163, 510);
            this.representationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.representationComboBox.Name = "representationComboBox";
            this.representationComboBox.Size = new System.Drawing.Size(399, 27);
            this.representationComboBox.TabIndex = 23;
            this.representationComboBox.SelectedValueChanged += new System.EventHandler(this.representationComboBox_SelectedValueChanged);
            this.representationComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.representationComboBox_Validating);
            // 
            // representationLabel
            // 
            this.representationLabel.AutoSize = true;
            this.representationLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.representationLabel.ForeColor = System.Drawing.Color.Black;
            this.representationLabel.Location = new System.Drawing.Point(159, 489);
            this.representationLabel.Name = "representationLabel";
            this.representationLabel.Size = new System.Drawing.Size(118, 19);
            this.representationLabel.TabIndex = 24;
            this.representationLabel.Text = "Représentation";
            // 
            // tarifByPlaceTextBox
            // 
            this.tarifByPlaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarifByPlaceTextBox.Enabled = false;
            this.tarifByPlaceTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifByPlaceTextBox.ForeColor = System.Drawing.Color.Black;
            this.tarifByPlaceTextBox.Location = new System.Drawing.Point(769, 511);
            this.tarifByPlaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tarifByPlaceTextBox.Name = "tarifByPlaceTextBox";
            this.tarifByPlaceTextBox.Size = new System.Drawing.Size(399, 27);
            this.tarifByPlaceTextBox.TabIndex = 25;
            // 
            // tarifLabel
            // 
            this.tarifLabel.AutoSize = true;
            this.tarifLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifLabel.ForeColor = System.Drawing.Color.Black;
            this.tarifLabel.Location = new System.Drawing.Point(765, 488);
            this.tarifLabel.Name = "tarifLabel";
            this.tarifLabel.Size = new System.Drawing.Size(113, 19);
            this.tarifLabel.TabIndex = 26;
            this.tarifLabel.Text = "Tarif par place";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(765, 566);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 19);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Nom";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderName.SetIconAlignment(this.nameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderName.SetIconPadding(this.nameTextBox, 2);
            this.nameTextBox.Location = new System.Drawing.Point(769, 589);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(399, 27);
            this.nameTextBox.TabIndex = 27;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderMail.SetIconAlignment(this.mailTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderMail.SetIconPadding(this.mailTextBox, 2);
            this.mailTextBox.Location = new System.Drawing.Point(163, 673);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(399, 27);
            this.mailTextBox.TabIndex = 29;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            this.mailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.mailTextBox_Validating);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLabel.ForeColor = System.Drawing.Color.Black;
            this.mailLabel.Location = new System.Drawing.Point(159, 650);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(103, 19);
            this.mailLabel.TabIndex = 30;
            this.mailLabel.Text = "Adresse mail";
            // 
            // telTextBox
            // 
            this.telTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderTel.SetIconAlignment(this.telTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderTel.SetIconPadding(this.telTextBox, 2);
            this.telTextBox.Location = new System.Drawing.Point(769, 673);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(399, 27);
            this.telTextBox.TabIndex = 31;
            this.telTextBox.TextChanged += new System.EventHandler(this.telTextBox_TextChanged);
            this.telTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telTextBox_Validating);
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telLabel.ForeColor = System.Drawing.Color.Black;
            this.telLabel.Location = new System.Drawing.Point(765, 650);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(164, 19);
            this.telLabel.TabIndex = 32;
            this.telLabel.Text = "Numéro de téléphone";
            // 
            // resultTarifTextBox
            // 
            this.resultTarifTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTarifTextBox.Enabled = false;
            this.resultTarifTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTarifTextBox.ForeColor = System.Drawing.Color.Black;
            this.resultTarifTextBox.Location = new System.Drawing.Point(769, 758);
            this.resultTarifTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultTarifTextBox.Name = "resultTarifTextBox";
            this.resultTarifTextBox.Size = new System.Drawing.Size(399, 27);
            this.resultTarifTextBox.TabIndex = 33;
            // 
            // resultTarifLabel
            // 
            this.resultTarifLabel.AutoSize = true;
            this.resultTarifLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTarifLabel.ForeColor = System.Drawing.Color.Black;
            this.resultTarifLabel.Location = new System.Drawing.Point(765, 735);
            this.resultTarifLabel.Name = "resultTarifLabel";
            this.resultTarifLabel.Size = new System.Drawing.Size(165, 19);
            this.resultTarifLabel.TabIndex = 34;
            this.resultTarifLabel.Text = "Tarif de la réservation";
            // 
            // nbPlaceTextBox
            // 
            this.nbPlaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbPlaceTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPlaceTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderNbPlace.SetIconAlignment(this.nbPlaceTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderNbPlace.SetIconPadding(this.nbPlaceTextBox, 2);
            this.nbPlaceTextBox.Location = new System.Drawing.Point(163, 758);
            this.nbPlaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbPlaceTextBox.Name = "nbPlaceTextBox";
            this.nbPlaceTextBox.Size = new System.Drawing.Size(399, 27);
            this.nbPlaceTextBox.TabIndex = 35;
            this.nbPlaceTextBox.TextChanged += new System.EventHandler(this.nbPlaceTextBox_TextChanged);
            this.nbPlaceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nbPlaceTextBox_Validating);
            // 
            // nbPlaceLabel
            // 
            this.nbPlaceLabel.AutoSize = true;
            this.nbPlaceLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPlaceLabel.ForeColor = System.Drawing.Color.Black;
            this.nbPlaceLabel.Location = new System.Drawing.Point(159, 735);
            this.nbPlaceLabel.Name = "nbPlaceLabel";
            this.nbPlaceLabel.Size = new System.Drawing.Size(141, 19);
            this.nbPlaceLabel.TabIndex = 36;
            this.nbPlaceLabel.Text = "Nombre de places";
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMail.ContainerControl = this;
            // 
            // errorProviderTel
            // 
            this.errorProviderTel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTel.ContainerControl = this;
            // 
            // errorProviderNbPlace
            // 
            this.errorProviderNbPlace.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNbPlace.ContainerControl = this;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1336, 906);
            this.Controls.Add(this.nbPlaceTextBox);
            this.Controls.Add(this.nbPlaceLabel);
            this.Controls.Add(this.resultTarifTextBox);
            this.Controls.Add(this.resultTarifLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tarifByPlaceTextBox);
            this.Controls.Add(this.tarifLabel);
            this.Controls.Add(this.representationComboBox);
            this.Controls.Add(this.representationLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.reservationsGridView);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.deleteButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservations";
            this.ShowIcon = false;
            this.Text = "Réservations";
            this.Load += new System.EventHandler(this.Representations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_theatresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNbPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView reservationsGridView;
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

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderRepresentation;
        private System.Windows.Forms.TextBox tarifByPlaceTextBox;
        private System.Windows.Forms.Label tarifLabel;
        private System.Windows.Forms.ComboBox representationComboBox;
        private System.Windows.Forms.Label representationLabel;
        private System.Windows.Forms.TextBox nbPlaceTextBox;
        private System.Windows.Forms.Label nbPlaceLabel;
        private System.Windows.Forms.TextBox resultTarifTextBox;
        private System.Windows.Forms.Label resultTarifLabel;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderTel;
        private System.Windows.Forms.ErrorProvider errorProviderNbPlace;
    }
}