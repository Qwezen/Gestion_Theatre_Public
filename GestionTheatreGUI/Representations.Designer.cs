namespace GestionTheatreGUI
{
    partial class Representations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteButton = new System.Windows.Forms.Button();
            this.representationsGridView = new System.Windows.Forms.DataGridView();
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pieceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterPieceComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstDateTextBox = new System.Windows.Forms.TextBox();
            this.secondDateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nbPlaceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tarifComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHours = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTarif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNbPlace = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPiece = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFirstDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSecondDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFilterPiece = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.representationsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_theatresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNbPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecondDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFilterPiece)).BeginInit();
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
            // representationsGridView
            // 
            this.representationsGridView.AllowUserToAddRows = false;
            this.representationsGridView.AllowUserToDeleteRows = false;
            this.representationsGridView.AllowUserToOrderColumns = true;
            this.representationsGridView.AllowUserToResizeColumns = false;
            this.representationsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.representationsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.representationsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.representationsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.representationsGridView.BackgroundColor = System.Drawing.Color.White;
            this.representationsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.representationsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.representationsGridView.ColumnHeadersHeight = 40;
            this.representationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.representationsGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.representationsGridView.EnableHeadersVisualStyles = false;
            this.representationsGridView.GridColor = System.Drawing.Color.White;
            this.representationsGridView.Location = new System.Drawing.Point(16, 15);
            this.representationsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.representationsGridView.MultiSelect = false;
            this.representationsGridView.Name = "representationsGridView";
            this.representationsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.representationsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.representationsGridView.RowHeadersVisible = false;
            this.representationsGridView.RowHeadersWidth = 120;
            this.representationsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.representationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.representationsGridView.ShowCellErrors = false;
            this.representationsGridView.ShowCellToolTips = false;
            this.representationsGridView.ShowEditingIcon = false;
            this.representationsGridView.ShowRowErrors = false;
            this.representationsGridView.Size = new System.Drawing.Size(1304, 369);
            this.representationsGridView.TabIndex = 0;
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
            this.addButton.Location = new System.Drawing.Point(823, 869);
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
            this.cancelButton.Location = new System.Drawing.Point(1075, 869);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(247, 50);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pieceComboBox
            // 
            this.pieceComboBox.BackColor = System.Drawing.Color.White;
            this.pieceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pieceComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceComboBox.ForeColor = System.Drawing.Color.Black;
            this.pieceComboBox.FormattingEnabled = true;
            this.errorProviderPiece.SetIconAlignment(this.pieceComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderPiece.SetIconPadding(this.pieceComboBox, 2);
            this.pieceComboBox.Location = new System.Drawing.Point(769, 665);
            this.pieceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pieceComboBox.Name = "pieceComboBox";
            this.pieceComboBox.Size = new System.Drawing.Size(399, 27);
            this.pieceComboBox.TabIndex = 10;
            this.pieceComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.pieceComboBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(761, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pièce";
            // 
            // filterPieceComboBox
            // 
            this.filterPieceComboBox.BackColor = System.Drawing.Color.White;
            this.filterPieceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterPieceComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPieceComboBox.ForeColor = System.Drawing.Color.Black;
            this.filterPieceComboBox.FormattingEnabled = true;
            this.errorProviderFilterPiece.SetIconAlignment(this.filterPieceComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFilterPiece.SetIconPadding(this.filterPieceComboBox, 2);
            this.filterPieceComboBox.Location = new System.Drawing.Point(474, 46);
            this.filterPieceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterPieceComboBox.Name = "filterPieceComboBox";
            this.filterPieceComboBox.Size = new System.Drawing.Size(325, 27);
            this.filterPieceComboBox.TabIndex = 5;
            this.filterPieceComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.filterPieceComboBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(466, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pièce";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(214, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "au";
            // 
            // firstDateTextBox
            // 
            this.firstDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstDateTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDateTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderFirstDate.SetIconAlignment(this.firstDateTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFirstDate.SetIconPadding(this.firstDateTextBox, 2);
            this.firstDateTextBox.Location = new System.Drawing.Point(46, 46);
            this.firstDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstDateTextBox.Name = "firstDateTextBox";
            this.firstDateTextBox.Size = new System.Drawing.Size(152, 27);
            this.firstDateTextBox.TabIndex = 3;
            this.firstDateTextBox.TextChanged += new System.EventHandler(this.firstDateTextBox_TextChanged);
            this.firstDateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstDateTextBox_Validating);
            // 
            // secondDateTextBox
            // 
            this.secondDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondDateTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDateTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderSecondDate.SetIconAlignment(this.secondDateTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderSecondDate.SetIconPadding(this.secondDateTextBox, 2);
            this.secondDateTextBox.Location = new System.Drawing.Point(262, 46);
            this.secondDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondDateTextBox.Name = "secondDateTextBox";
            this.secondDateTextBox.Size = new System.Drawing.Size(166, 27);
            this.secondDateTextBox.TabIndex = 4;
            this.secondDateTextBox.TextChanged += new System.EventHandler(this.secondDateTextBox_TextChanged);
            this.secondDateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.secondDateTextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date (D/M/YYYY)";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(827, 32);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(247, 50);
            this.filterButton.TabIndex = 6;
            this.filterButton.Text = "Filtrer";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.secondDateTextBox);
            this.panel2.Controls.Add(this.firstDateTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.filterPieceComboBox);
            this.panel2.Location = new System.Drawing.Point(116, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 121);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(761, 732);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre de places";
            // 
            // nbPlaceTextBox
            // 
            this.nbPlaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbPlaceTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPlaceTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderNbPlace.SetIconAlignment(this.nbPlaceTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderNbPlace.SetIconPadding(this.nbPlaceTextBox, 2);
            this.nbPlaceTextBox.Location = new System.Drawing.Point(765, 755);
            this.nbPlaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbPlaceTextBox.Name = "nbPlaceTextBox";
            this.nbPlaceTextBox.Size = new System.Drawing.Size(399, 27);
            this.nbPlaceTextBox.TabIndex = 11;
            this.nbPlaceTextBox.TextChanged += new System.EventHandler(this.nbPlaceTextBox_TextChanged);
            this.nbPlaceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nbPlaceTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 734);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tarif";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderDate.SetIconAlignment(this.dateTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderDate.SetIconPadding(this.dateTextBox, 2);
            this.dateTextBox.Location = new System.Drawing.Point(175, 666);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(165, 27);
            this.dateTextBox.TabIndex = 7;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            this.dateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dateTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(167, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date (D/M/YYYY)";
            // 
            // tarifComboBox
            // 
            this.tarifComboBox.BackColor = System.Drawing.Color.White;
            this.tarifComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarifComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifComboBox.ForeColor = System.Drawing.Color.Black;
            this.tarifComboBox.FormattingEnabled = true;
            this.errorProviderTarif.SetIconAlignment(this.tarifComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderTarif.SetIconPadding(this.tarifComboBox, 2);
            this.tarifComboBox.Location = new System.Drawing.Point(163, 755);
            this.tarifComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tarifComboBox.Name = "tarifComboBox";
            this.tarifComboBox.Size = new System.Drawing.Size(399, 27);
            this.tarifComboBox.TabIndex = 9;
            this.tarifComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.tarifComboBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(362, 645);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Heure (HH:MM)";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorProviderHours.SetIconAlignment(this.hoursTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderHours.SetIconPadding(this.hoursTextBox, 2);
            this.hoursTextBox.Location = new System.Drawing.Point(366, 666);
            this.hoursTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(179, 27);
            this.hoursTextBox.TabIndex = 8;
            this.hoursTextBox.TextChanged += new System.EventHandler(this.hoursTextBox_TextChanged);
            this.hoursTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.hoursTextBox_Validating);
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderHours
            // 
            this.errorProviderHours.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderHours.ContainerControl = this;
            // 
            // errorProviderTarif
            // 
            this.errorProviderTarif.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTarif.ContainerControl = this;
            // 
            // errorProviderNbPlace
            // 
            this.errorProviderNbPlace.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNbPlace.ContainerControl = this;
            // 
            // errorProviderPiece
            // 
            this.errorProviderPiece.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPiece.ContainerControl = this;
            // 
            // errorProviderFirstDate
            // 
            this.errorProviderFirstDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFirstDate.ContainerControl = this;
            // 
            // errorProviderSecondDate
            // 
            this.errorProviderSecondDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSecondDate.ContainerControl = this;
            // 
            // errorProviderFilterPiece
            // 
            this.errorProviderFilterPiece.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFilterPiece.ContainerControl = this;
            // 
            // Representations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1336, 928);
            this.Controls.Add(this.tarifComboBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nbPlaceTextBox);
            this.Controls.Add(this.representationsGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pieceComboBox);
            this.Controls.Add(this.deleteButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Representations";
            this.ShowIcon = false;
            this.Text = "Représentations";
            this.Load += new System.EventHandler(this.Representations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.representationsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_theatresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNbPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecondDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFilterPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView representationsGridView;
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
        private System.Windows.Forms.ComboBox pieceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filterPieceComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstDateTextBox;
        private System.Windows.Forms.TextBox secondDateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nbPlaceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tarifComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderHours;
        private System.Windows.Forms.ErrorProvider errorProviderTarif;
        private System.Windows.Forms.ErrorProvider errorProviderNbPlace;
        private System.Windows.Forms.ErrorProvider errorProviderPiece;
        private System.Windows.Forms.ErrorProvider errorProviderFirstDate;
        private System.Windows.Forms.ErrorProvider errorProviderSecondDate;
        private System.Windows.Forms.ErrorProvider errorProviderFilterPiece;

    }
}