namespace QRCodeScanner
{
    partial class Form1
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
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNotification = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnCloseBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSchoolYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCourse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Photo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescriptiveTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimeOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimeIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSchedule = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubjectCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timein = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEnrollmentStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 60000;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumber.Location = new System.Drawing.Point(64, 420);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(201, 38);
            this.txtIDNumber.TabIndex = 2;
            this.txtIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(706, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 35);
            this.label8.TabIndex = 24;
            this.label8.Text = "S. Y.";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(621, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 35);
            this.label9.TabIndex = 23;
            this.label9.Text = "SEMESTER";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(655, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 35);
            this.label10.TabIndex = 22;
            this.label10.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 35);
            this.label6.TabIndex = 20;
            this.label6.Text = "COURSE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "LASTNAME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotification.Location = new System.Drawing.Point(3, 0);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(1008, 31);
            this.labelNotification.TabIndex = 25;
            this.labelNotification.Text = "     ";
            this.labelNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.Location = new System.Drawing.Point(1391, 0);
            this.btnCloseBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.Size = new System.Drawing.Size(45, 29);
            this.btnCloseBox.TabIndex = 27;
            this.btnCloseBox.Click += new System.EventHandler(this.btnCloseBox_Click);
            // 
            // btnMaximizeBox
            // 
            this.btnMaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximizeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMaximizeBox.IconColor = System.Drawing.Color.White;
            this.btnMaximizeBox.Location = new System.Drawing.Point(1346, 0);
            this.btnMaximizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizeBox.Name = "btnMaximizeBox";
            this.btnMaximizeBox.Size = new System.Drawing.Size(45, 29);
            this.btnMaximizeBox.TabIndex = 28;
            this.btnMaximizeBox.Click += new System.EventHandler(this.btnMaximizeBox_Click);
            // 
            // btnMinimizeBox
            // 
            this.btnMinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMinimizeBox.IconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.Location = new System.Drawing.Point(1301, 0);
            this.btnMinimizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.Size = new System.Drawing.Size(45, 29);
            this.btnMinimizeBox.TabIndex = 29;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnMinimizeBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCloseBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnMaximizeBox);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1436, 29);
            this.guna2CustomGradientPanel1.TabIndex = 30;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2CustomGradientPanel2.Controls.Add(this.panel2);
            this.guna2CustomGradientPanel2.Controls.Add(this.Photo);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Aqua;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.MediumPurple;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.CornflowerBlue;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1436, 841);
            this.guna2CustomGradientPanel2.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelNotification, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 466);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 31);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ColumnCount = 5;
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82364F));
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.93548F));
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.03415F));
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.20263F));
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.panel2.Controls.Add(this.txtSemester, 3, 3);
            this.panel2.Controls.Add(this.txtSchoolYear, 3, 2);
            this.panel2.Controls.Add(this.txtGender, 3, 1);
            this.panel2.Controls.Add(this.txtYear, 1, 4);
            this.panel2.Controls.Add(this.txtLastName, 1, 2);
            this.panel2.Controls.Add(this.txtCourse, 1, 3);
            this.panel2.Controls.Add(this.label4, 0, 1);
            this.panel2.Controls.Add(this.label7, 0, 4);
            this.panel2.Controls.Add(this.label6, 0, 3);
            this.panel2.Controls.Add(this.label5, 0, 2);
            this.panel2.Controls.Add(this.txtFirstName, 1, 1);
            this.panel2.Controls.Add(this.label9, 2, 3);
            this.panel2.Controls.Add(this.label8, 2, 2);
            this.panel2.Controls.Add(this.label10, 2, 1);
            this.panel2.Location = new System.Drawing.Point(309, 189);
            this.panel2.Name = "panel2";
            this.panel2.RowCount = 6;
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2.Size = new System.Drawing.Size(1066, 271);
            this.panel2.TabIndex = 3;
            // 
            // txtSemester
            // 
            this.txtSemester.BorderColor = System.Drawing.Color.Black;
            this.txtSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSemester.DefaultText = "";
            this.txtSemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtSemester.ForeColor = System.Drawing.Color.Black;
            this.txtSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Location = new System.Drawing.Point(784, 141);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.PasswordChar = '\0';
            this.txtSemester.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSemester.PlaceholderText = "";
            this.txtSemester.SelectedText = "";
            this.txtSemester.Size = new System.Drawing.Size(237, 43);
            this.txtSemester.TabIndex = 6;
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BorderColor = System.Drawing.Color.Black;
            this.txtSchoolYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSchoolYear.DefaultText = "";
            this.txtSchoolYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSchoolYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSchoolYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSchoolYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchoolYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSchoolYear.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtSchoolYear.ForeColor = System.Drawing.Color.Black;
            this.txtSchoolYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSchoolYear.Location = new System.Drawing.Point(784, 84);
            this.txtSchoolYear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.PasswordChar = '\0';
            this.txtSchoolYear.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSchoolYear.PlaceholderText = "";
            this.txtSchoolYear.SelectedText = "";
            this.txtSchoolYear.Size = new System.Drawing.Size(237, 43);
            this.txtSchoolYear.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.BorderColor = System.Drawing.Color.Black;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.DefaultText = "";
            this.txtGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.Location = new System.Drawing.Point(784, 27);
            this.txtGender.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtGender.PlaceholderText = "";
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(237, 43);
            this.txtGender.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.BorderColor = System.Drawing.Color.Black;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Location = new System.Drawing.Point(189, 198);
            this.txtYear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtYear.PlaceholderText = "";
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(419, 43);
            this.txtYear.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.Black;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(189, 84);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(419, 43);
            this.txtLastName.TabIndex = 5;
            // 
            // txtCourse
            // 
            this.txtCourse.BorderColor = System.Drawing.Color.Black;
            this.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourse.DefaultText = "";
            this.txtCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourse.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtCourse.ForeColor = System.Drawing.Color.Black;
            this.txtCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourse.Location = new System.Drawing.Point(189, 141);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCourse.PlaceholderText = "";
            this.txtCourse.SelectedText = "";
            this.txtCourse.Size = new System.Drawing.Size(419, 43);
            this.txtCourse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "FIRSTNAME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 35);
            this.label7.TabIndex = 21;
            this.label7.Text = "YEAR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(189, 27);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(419, 43);
            this.txtFirstName.TabIndex = 4;
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.Transparent;
            this.Photo.BorderRadius = 1;
            this.Photo.ImageRotate = 0F;
            this.Photo.Location = new System.Drawing.Point(65, 189);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(200, 200);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ColumnCount = 6;
            this.panel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.panel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.13164F));
            this.panel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.06582F));
            this.panel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.49145F));
            this.panel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30769F));
            this.panel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panel5.Controls.Add(this.txtDescriptiveTitle, 2, 3);
            this.panel5.Controls.Add(this.txtTimeOut, 4, 2);
            this.panel5.Controls.Add(this.txtTimeIn, 4, 1);
            this.panel5.Controls.Add(this.txtSchedule, 2, 2);
            this.panel5.Controls.Add(this.txtSubjectCode, 2, 1);
            this.panel5.Controls.Add(this.label12, 1, 2);
            this.panel5.Controls.Add(this.label3, 1, 1);
            this.panel5.Controls.Add(this.label1, 1, 3);
            this.panel5.Controls.Add(this.timein, 3, 1);
            this.panel5.Controls.Add(this.timeout, 3, 2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.RowCount = 5;
            this.panel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel5.Size = new System.Drawing.Size(988, 219);
            this.panel5.TabIndex = 4;
            // 
            // txtDescriptiveTitle
            // 
            this.txtDescriptiveTitle.BorderColor = System.Drawing.Color.Black;
            this.txtDescriptiveTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriptiveTitle.DefaultText = "";
            this.txtDescriptiveTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescriptiveTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescriptiveTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescriptiveTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescriptiveTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescriptiveTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescriptiveTitle.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtDescriptiveTitle.ForeColor = System.Drawing.Color.Black;
            this.txtDescriptiveTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescriptiveTitle.Location = new System.Drawing.Point(279, 149);
            this.txtDescriptiveTitle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDescriptiveTitle.Name = "txtDescriptiveTitle";
            this.txtDescriptiveTitle.PasswordChar = '\0';
            this.txtDescriptiveTitle.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDescriptiveTitle.PlaceholderText = "";
            this.txtDescriptiveTitle.SelectedText = "";
            this.txtDescriptiveTitle.Size = new System.Drawing.Size(356, 42);
            this.txtDescriptiveTitle.TabIndex = 26;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.BorderColor = System.Drawing.Color.Black;
            this.txtTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeOut.DefaultText = "";
            this.txtTimeOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeOut.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtTimeOut.ForeColor = System.Drawing.Color.Black;
            this.txtTimeOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeOut.Location = new System.Drawing.Point(793, 93);
            this.txtTimeOut.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.PasswordChar = '\0';
            this.txtTimeOut.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimeOut.PlaceholderText = "";
            this.txtTimeOut.SelectedText = "";
            this.txtTimeOut.Size = new System.Drawing.Size(151, 42);
            this.txtTimeOut.TabIndex = 27;
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.BorderColor = System.Drawing.Color.Black;
            this.txtTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeIn.DefaultText = "";
            this.txtTimeIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimeIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimeIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeIn.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtTimeIn.ForeColor = System.Drawing.Color.Black;
            this.txtTimeIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeIn.Location = new System.Drawing.Point(793, 37);
            this.txtTimeIn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.PasswordChar = '\0';
            this.txtTimeIn.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimeIn.PlaceholderText = "";
            this.txtTimeIn.SelectedText = "";
            this.txtTimeIn.Size = new System.Drawing.Size(151, 42);
            this.txtTimeIn.TabIndex = 26;
            // 
            // txtSchedule
            // 
            this.txtSchedule.BorderColor = System.Drawing.Color.Black;
            this.txtSchedule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSchedule.DefaultText = "";
            this.txtSchedule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSchedule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSchedule.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtSchedule.ForeColor = System.Drawing.Color.Black;
            this.txtSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSchedule.Location = new System.Drawing.Point(279, 93);
            this.txtSchedule.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.PasswordChar = '\0';
            this.txtSchedule.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSchedule.PlaceholderText = "";
            this.txtSchedule.SelectedText = "";
            this.txtSchedule.Size = new System.Drawing.Size(356, 42);
            this.txtSchedule.TabIndex = 25;
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BorderColor = System.Drawing.Color.Black;
            this.txtSubjectCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubjectCode.DefaultText = "";
            this.txtSubjectCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubjectCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubjectCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubjectCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubjectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubjectCode.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtSubjectCode.ForeColor = System.Drawing.Color.Black;
            this.txtSubjectCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubjectCode.Location = new System.Drawing.Point(279, 37);
            this.txtSubjectCode.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.PasswordChar = '\0';
            this.txtSubjectCode.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSubjectCode.PlaceholderText = "";
            this.txtSubjectCode.SelectedText = "";
            this.txtSubjectCode.Size = new System.Drawing.Size(356, 42);
            this.txtSubjectCode.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(118, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 35);
            this.label12.TabIndex = 24;
            this.label12.Text = "SCHEDULE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "SUBJECT CODE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "DESCRIPTIVE TITLE";
            // 
            // timein
            // 
            this.timein.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timein.AutoSize = true;
            this.timein.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.timein.Location = new System.Drawing.Point(672, 40);
            this.timein.Name = "timein";
            this.timein.Size = new System.Drawing.Size(112, 35);
            this.timein.TabIndex = 6;
            this.timein.Text = "TIME IN";
            // 
            // timeout
            // 
            this.timeout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeout.AutoSize = true;
            this.timeout.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.timeout.Location = new System.Drawing.Point(647, 96);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(137, 35);
            this.timeout.TabIndex = 7;
            this.timeout.Text = "TIME OUT";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.txtEnrollmentStatus, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 219);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 76);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtEnrollmentStatus
            // 
            this.txtEnrollmentStatus.BorderColor = System.Drawing.Color.Black;
            this.txtEnrollmentStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollmentStatus.DefaultText = "";
            this.txtEnrollmentStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnrollmentStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnrollmentStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnrollmentStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnrollmentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnrollmentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnrollmentStatus.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.txtEnrollmentStatus.ForeColor = System.Drawing.Color.Black;
            this.txtEnrollmentStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnrollmentStatus.Location = new System.Drawing.Point(17, 7);
            this.txtEnrollmentStatus.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtEnrollmentStatus.Name = "txtEnrollmentStatus";
            this.txtEnrollmentStatus.PasswordChar = '\0';
            this.txtEnrollmentStatus.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtEnrollmentStatus.PlaceholderText = "";
            this.txtEnrollmentStatus.SelectedText = "";
            this.txtEnrollmentStatus.Size = new System.Drawing.Size(935, 43);
            this.txtEnrollmentStatus.TabIndex = 6;
            this.txtEnrollmentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(988, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(349, 295);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 235);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(38, 497);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 295);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 841);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1436, 841);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI2.WinForms.Guna2ControlBox btnCloseBox;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizeBox;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox Photo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtCourse;
        private Guna.UI2.WinForms.Guna2TextBox txtSemester;
        private Guna.UI2.WinForms.Guna2TextBox txtSchoolYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtEnrollmentStatus;
        private System.Windows.Forms.TableLayoutPanel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDescriptiveTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTimeOut;
        private Guna.UI2.WinForms.Guna2TextBox txtTimeIn;
        private Guna.UI2.WinForms.Guna2TextBox txtSchedule;
        private Guna.UI2.WinForms.Guna2TextBox txtSubjectCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timein;
        private System.Windows.Forms.Label timeout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

