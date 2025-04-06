namespace FloorAndCarpetApp
{
    partial class FloorAndCarpet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloorAndCarpet));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cboBoxState = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAddress2 = new System.Windows.Forms.TextBox();
            this.txtBoxAddress1 = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpBoxInstallation = new System.Windows.Forms.GroupBox();
            this.radSelfMotivated = new System.Windows.Forms.RadioButton();
            this.radProfessional = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLaborCharge = new System.Windows.Forms.TextBox();
            this.txtTotalEstimate = new System.Windows.Forms.TextBox();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.txtSqYrd = new System.Windows.Forms.TextBox();
            this.txtSqFt = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dgv01 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBoxInstallation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit,
            this.menuNew});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(128, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(128, 26);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont,
            this.menuColor});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(137, 26);
            this.menuFont.Text = "Font";
            this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(137, 26);
            this.menuColor.Text = "Color";
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(128, 26);
            this.menuHelp.Text = "Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 626);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cboBoxState);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.txtBoxEmail);
            this.tabPage2.Controls.Add(this.txtBoxPhoneNumber);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtBoxZipCode);
            this.tabPage2.Controls.Add(this.txtBoxCity);
            this.tabPage2.Controls.Add(this.txtBoxAddress2);
            this.tabPage2.Controls.Add(this.txtBoxAddress1);
            this.tabPage2.Controls.Add(this.txtBoxLastName);
            this.tabPage2.Controls.Add(this.txtBoxFirstName);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1139, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(465, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 57);
            this.label18.TabIndex = 33;
            this.label18.Text = "When all fields have\r\nbeen entered hit the\r\nsave button";
            // 
            // cboBoxState
            // 
            this.cboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxState.FormattingEnabled = true;
            this.cboBoxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboBoxState.Location = new System.Drawing.Point(174, 268);
            this.cboBoxState.Name = "cboBoxState";
            this.cboBoxState.Size = new System.Drawing.Size(227, 27);
            this.cboBoxState.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(469, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 121);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(174, 412);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(227, 26);
            this.txtBoxEmail.TabIndex = 30;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(174, 364);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(227, 26);
            this.txtBoxPhoneNumber.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 411);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 24);
            this.label17.TabIndex = 28;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 24);
            this.label16.TabIndex = 27;
            this.label16.Text = "Phone Number";
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Location = new System.Drawing.Point(174, 316);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(227, 26);
            this.txtBoxZipCode.TabIndex = 26;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(174, 220);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(227, 26);
            this.txtBoxCity.TabIndex = 24;
            // 
            // txtBoxAddress2
            // 
            this.txtBoxAddress2.Location = new System.Drawing.Point(174, 172);
            this.txtBoxAddress2.Name = "txtBoxAddress2";
            this.txtBoxAddress2.Size = new System.Drawing.Size(227, 26);
            this.txtBoxAddress2.TabIndex = 23;
            // 
            // txtBoxAddress1
            // 
            this.txtBoxAddress1.Location = new System.Drawing.Point(174, 124);
            this.txtBoxAddress1.Name = "txtBoxAddress1";
            this.txtBoxAddress1.Size = new System.Drawing.Size(227, 26);
            this.txtBoxAddress1.TabIndex = 22;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(174, 76);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(227, 26);
            this.txtBoxLastName.TabIndex = 21;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(174, 28);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(227, 26);
            this.txtBoxFirstName.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 19;
            this.label15.Text = "Zip Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "State";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Address 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Address 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInvoice);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.grpBoxInstallation);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtMatCost);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLength);
            this.tabPage1.Controls.Add(this.txtWidth);
            this.tabPage1.Controls.Add(this.txtLaborCharge);
            this.tabPage1.Controls.Add(this.txtTotalEstimate);
            this.tabPage1.Controls.Add(this.txtLaborCost);
            this.tabPage1.Controls.Add(this.txtSqYrd);
            this.tabPage1.Controls.Add(this.txtSqFt);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtType);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.dgv01);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1139, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Silver;
            this.btnInvoice.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(772, 468);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(184, 121);
            this.btnInvoice.TabIndex = 26;
            this.btnInvoice.Text = "&Submit";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(636, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(497, 306);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // grpBoxInstallation
            // 
            this.grpBoxInstallation.Controls.Add(this.radSelfMotivated);
            this.grpBoxInstallation.Controls.Add(this.radProfessional);
            this.grpBoxInstallation.Location = new System.Drawing.Point(522, 318);
            this.grpBoxInstallation.Name = "grpBoxInstallation";
            this.grpBoxInstallation.Size = new System.Drawing.Size(184, 101);
            this.grpBoxInstallation.TabIndex = 24;
            this.grpBoxInstallation.TabStop = false;
            this.grpBoxInstallation.Text = "Installation";
            // 
            // radSelfMotivated
            // 
            this.radSelfMotivated.AutoSize = true;
            this.radSelfMotivated.Location = new System.Drawing.Point(6, 43);
            this.radSelfMotivated.Name = "radSelfMotivated";
            this.radSelfMotivated.Size = new System.Drawing.Size(156, 23);
            this.radSelfMotivated.TabIndex = 26;
            this.radSelfMotivated.TabStop = true;
            this.radSelfMotivated.Text = "Self-Motivated";
            this.radSelfMotivated.UseVisualStyleBackColor = true;
            // 
            // radProfessional
            // 
            this.radProfessional.AutoSize = true;
            this.radProfessional.Location = new System.Drawing.Point(6, 72);
            this.radProfessional.Name = "radProfessional";
            this.radProfessional.Size = new System.Drawing.Size(138, 23);
            this.radProfessional.TabIndex = 25;
            this.radProfessional.TabStop = true;
            this.radProfessional.Text = "Professional";
            this.radProfessional.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(772, 318);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 121);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(338, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Labor Charge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Estimate";
            // 
            // txtMatCost
            // 
            this.txtMatCost.Location = new System.Drawing.Point(522, 463);
            this.txtMatCost.Name = "txtMatCost";
            this.txtMatCost.ReadOnly = true;
            this.txtMatCost.Size = new System.Drawing.Size(161, 26);
            this.txtMatCost.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Labor Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Material Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Square Yard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Square Feet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Width";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(154, 498);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(161, 26);
            this.txtLength.TabIndex = 13;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(154, 466);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(161, 26);
            this.txtWidth.TabIndex = 12;
            // 
            // txtLaborCharge
            // 
            this.txtLaborCharge.Location = new System.Drawing.Point(522, 495);
            this.txtLaborCharge.Name = "txtLaborCharge";
            this.txtLaborCharge.ReadOnly = true;
            this.txtLaborCharge.Size = new System.Drawing.Size(161, 26);
            this.txtLaborCharge.TabIndex = 11;
            // 
            // txtTotalEstimate
            // 
            this.txtTotalEstimate.Location = new System.Drawing.Point(522, 559);
            this.txtTotalEstimate.Name = "txtTotalEstimate";
            this.txtTotalEstimate.ReadOnly = true;
            this.txtTotalEstimate.Size = new System.Drawing.Size(161, 26);
            this.txtTotalEstimate.TabIndex = 10;
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Location = new System.Drawing.Point(522, 527);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.ReadOnly = true;
            this.txtLaborCost.Size = new System.Drawing.Size(161, 26);
            this.txtLaborCost.TabIndex = 9;
            // 
            // txtSqYrd
            // 
            this.txtSqYrd.Location = new System.Drawing.Point(154, 562);
            this.txtSqYrd.Name = "txtSqYrd";
            this.txtSqYrd.ReadOnly = true;
            this.txtSqYrd.Size = new System.Drawing.Size(161, 26);
            this.txtSqYrd.TabIndex = 8;
            // 
            // txtSqFt
            // 
            this.txtSqFt.Location = new System.Drawing.Point(154, 530);
            this.txtSqFt.Name = "txtSqFt";
            this.txtSqFt.ReadOnly = true;
            this.txtSqFt.Size = new System.Drawing.Size(161, 26);
            this.txtSqFt.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(342, 318);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(161, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(173, 318);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(161, 26);
            this.txtType.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 318);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(161, 26);
            this.txtName.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(636, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(0, 0);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dgv01
            // 
            this.dgv01.AllowUserToAddRows = false;
            this.dgv01.AllowUserToDeleteRows = false;
            this.dgv01.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv01.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv01.Location = new System.Drawing.Point(6, 6);
            this.dgv01.MultiSelect = false;
            this.dgv01.Name = "dgv01";
            this.dgv01.ReadOnly = true;
            this.dgv01.RowHeadersWidth = 51;
            this.dgv01.RowTemplate.Height = 24;
            this.dgv01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv01.Size = new System.Drawing.Size(497, 306);
            this.dgv01.TabIndex = 0;
            this.dgv01.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv01_CellContentClick);
            // 
            // FloorAndCarpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 669);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FloorAndCarpet";
            this.Text = "Crooked Flooring";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpBoxInstallation.ResumeLayout(false);
            this.grpBoxInstallation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dgv01;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLaborCharge;
        private System.Windows.Forms.TextBox txtTotalEstimate;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.TextBox txtSqYrd;
        private System.Windows.Forms.TextBox txtSqFt;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpBoxInstallation;
        private System.Windows.Forms.RadioButton radProfessional;
        private System.Windows.Forms.RadioButton radSelfMotivated;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxAddress2;
        private System.Windows.Forms.TextBox txtBoxAddress1;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.ComboBox cboBoxState;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label18;
    }
}

