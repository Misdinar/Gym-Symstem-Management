namespace GymManagementSystem
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Periode = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PaymentDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.NameCb = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.searchName = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(1059, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(487, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "Payments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(464, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "GYMGYMAN";
            // 
            // AmountTb
            // 
            this.AmountTb.AcceptsReturn = false;
            this.AmountTb.AcceptsTab = false;
            this.AmountTb.AnimationSpeed = 200;
            this.AmountTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AmountTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AmountTb.AutoSizeHeight = true;
            this.AmountTb.BackColor = System.Drawing.Color.Transparent;
            this.AmountTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AmountTb.BackgroundImage")));
            this.AmountTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.AmountTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AmountTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AmountTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.AmountTb.BorderRadius = 1;
            this.AmountTb.BorderThickness = 1;
            this.AmountTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AmountTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.AmountTb.DefaultText = "";
            this.AmountTb.FillColor = System.Drawing.Color.White;
            this.AmountTb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AmountTb.HideSelection = true;
            this.AmountTb.IconLeft = null;
            this.AmountTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTb.IconPadding = 10;
            this.AmountTb.IconRight = null;
            this.AmountTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTb.Lines = new string[0];
            this.AmountTb.Location = new System.Drawing.Point(81, 346);
            this.AmountTb.MaxLength = 32767;
            this.AmountTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.AmountTb.Modified = false;
            this.AmountTb.Multiline = false;
            this.AmountTb.Name = "AmountTb";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AmountTb.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AmountTb.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AmountTb.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.DarkSlateGray;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AmountTb.OnIdleState = stateProperties12;
            this.AmountTb.Padding = new System.Windows.Forms.Padding(3);
            this.AmountTb.PasswordChar = '\0';
            this.AmountTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.AmountTb.PlaceholderText = "Full Name";
            this.AmountTb.ReadOnly = false;
            this.AmountTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AmountTb.SelectedText = "";
            this.AmountTb.SelectionLength = 0;
            this.AmountTb.SelectionStart = 0;
            this.AmountTb.ShortcutsEnabled = true;
            this.AmountTb.Size = new System.Drawing.Size(219, 27);
            this.AmountTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.AmountTb.TabIndex = 45;
            this.AmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AmountTb.TextMarginBottom = 0;
            this.AmountTb.TextMarginLeft = 3;
            this.AmountTb.TextMarginTop = 1;
            this.AmountTb.TextPlaceholder = "Full Name";
            this.AmountTb.UseSystemPasswordChar = false;
            this.AmountTb.WordWrap = true;
            this.AmountTb.TextChanged += new System.EventHandler(this.BunifuTextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(77, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(77, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Member Name";
            // 
            // Periode
            // 
            this.Periode.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periode.Location = new System.Drawing.Point(81, 205);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(200, 22);
            this.Periode.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(77, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Payment Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(193, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 49;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(81, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 48;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(135, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 37);
            this.button3.TabIndex = 50;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // PaymentDGV
            // 
            this.PaymentDGV.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.PaymentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PaymentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PaymentDGV.ColumnHeadersHeight = 40;
            this.PaymentDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.PaymentDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.PaymentDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PaymentDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PaymentDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.PaymentDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.PaymentDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PaymentDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.PaymentDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.PaymentDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PaymentDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.PaymentDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PaymentDGV.CurrentTheme.Name = null;
            this.PaymentDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PaymentDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.PaymentDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PaymentDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PaymentDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PaymentDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PaymentDGV.EnableHeadersVisualStyles = false;
            this.PaymentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PaymentDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.PaymentDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.PaymentDGV.HeaderForeColor = System.Drawing.Color.White;
            this.PaymentDGV.Location = new System.Drawing.Point(363, 179);
            this.PaymentDGV.Name = "PaymentDGV";
            this.PaymentDGV.ReadOnly = true;
            this.PaymentDGV.RowHeadersVisible = false;
            this.PaymentDGV.RowHeadersWidth = 51;
            this.PaymentDGV.RowTemplate.Height = 40;
            this.PaymentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentDGV.Size = new System.Drawing.Size(654, 359);
            this.PaymentDGV.TabIndex = 51;
            this.PaymentDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.PaymentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentDGV_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(436, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 23);
            this.label10.TabIndex = 52;
            this.label10.Text = "Developed by Tomking";
            // 
            // NameCb
            // 
            this.NameCb.FormattingEnabled = true;
            this.NameCb.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.NameCb.Location = new System.Drawing.Point(81, 274);
            this.NameCb.Name = "NameCb";
            this.NameCb.Size = new System.Drawing.Size(219, 24);
            this.NameCb.TabIndex = 53;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(706, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 56;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(588, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 37);
            this.button5.TabIndex = 55;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // searchName
            // 
            this.searchName.AcceptsReturn = false;
            this.searchName.AcceptsTab = false;
            this.searchName.AnimationSpeed = 200;
            this.searchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchName.AutoSizeHeight = true;
            this.searchName.BackColor = System.Drawing.Color.Transparent;
            this.searchName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchName.BackgroundImage")));
            this.searchName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchName.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchName.BorderRadius = 1;
            this.searchName.BorderThickness = 1;
            this.searchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.searchName.DefaultText = "";
            this.searchName.FillColor = System.Drawing.Color.White;
            this.searchName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchName.HideSelection = true;
            this.searchName.IconLeft = null;
            this.searchName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchName.IconPadding = 10;
            this.searchName.IconRight = null;
            this.searchName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchName.Lines = new string[0];
            this.searchName.Location = new System.Drawing.Point(363, 136);
            this.searchName.MaxLength = 32767;
            this.searchName.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchName.Modified = false;
            this.searchName.Multiline = false;
            this.searchName.Name = "searchName";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.DarkSlateGray;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchName.OnIdleState = stateProperties16;
            this.searchName.Padding = new System.Windows.Forms.Padding(3);
            this.searchName.PasswordChar = '\0';
            this.searchName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchName.PlaceholderText = "Search Payment";
            this.searchName.ReadOnly = false;
            this.searchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchName.SelectedText = "";
            this.searchName.SelectionLength = 0;
            this.searchName.SelectionStart = 0;
            this.searchName.ShortcutsEnabled = true;
            this.searchName.Size = new System.Drawing.Size(219, 37);
            this.searchName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchName.TabIndex = 54;
            this.searchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchName.TextMarginBottom = 0;
            this.searchName.TextMarginLeft = 3;
            this.searchName.TextMarginTop = 1;
            this.searchName.TextPlaceholder = "Search Payment";
            this.searchName.UseSystemPasswordChar = false;
            this.searchName.WordWrap = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 647);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.NameCb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PaymentDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Periode);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox AmountTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Periode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Bunifu.UI.WinForms.BunifuDataGridView PaymentDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox NameCb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Bunifu.UI.WinForms.BunifuTextBox searchName;
    }
}