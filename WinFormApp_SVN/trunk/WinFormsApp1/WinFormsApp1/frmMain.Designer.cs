using WinFormsApp1.Custom;

namespace WinFormsApp1
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            tlpRoomControl = new TableLayoutPanel();
            pnlButtom = new Panel();
            button1 = new Button();
            flpRightControl = new Panel();
            ucrTodoPanel1 = new ucrTodoPanel();
            panel1 = new Panel();
            txtPatientId = new TextBox();
            btnReflection = new Button();
            lblPatientName = new Label();
            lblPatient = new Label();
            label2 = new Label();
            pnlSelectRoom = new Panel();
            tglOpeTypeDefault = new RadioButton();
            tglOpeTypeSimple = new RadioButton();
            tglOpeTypeFull = new RadioButton();
            tlpTimeLine = new TableLayoutPanel();
            lblTime0800 = new Label();
            lblTime0830 = new Label();
            lblTime0900 = new Label();
            lblTime0930 = new Label();
            lblTime1000 = new Label();
            lblTime1030 = new Label();
            lblTime1100 = new Label();
            lblTime1130 = new Label();
            lblTime1200 = new Label();
            lblTime1230 = new Label();
            lblTime1300 = new Label();
            lblTime1330 = new Label();
            lblTime1400 = new Label();
            lblTime1430 = new Label();
            lblTime1500 = new Label();
            lblTime1530 = new Label();
            lblTime1600 = new Label();
            lblTime1630 = new Label();
            lblTime1730 = new Label();
            lblTime1800 = new Label();
            lblTime1830 = new Label();
            label1 = new Label();
            pnlOpeRoom1 = new Panel();
            lblRoomTitle1 = new RoundedLabel();
            pnlOpeRoom2 = new FlowLayoutPanel();
            lblRoomTitle2 = new RoundedLabel();
            pnlOpeRoom3 = new FlowLayoutPanel();
            lblRoomTitle3 = new RoundedLabel();
            lblTime1700 = new Label();
            toolTip1 = new ToolTip(components);
            tlpRoomControl.SuspendLayout();
            pnlButtom.SuspendLayout();
            flpRightControl.SuspendLayout();
            panel1.SuspendLayout();
            pnlSelectRoom.SuspendLayout();
            tlpTimeLine.SuspendLayout();
            pnlOpeRoom1.SuspendLayout();
            pnlOpeRoom2.SuspendLayout();
            pnlOpeRoom3.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoomControl
            // 
            tlpRoomControl.BackColor = SystemColors.Control;
            tlpRoomControl.ColumnCount = 5;
            tlpRoomControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tlpRoomControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tlpRoomControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tlpRoomControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tlpRoomControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpRoomControl.Controls.Add(pnlButtom, 0, 1);
            tlpRoomControl.Controls.Add(flpRightControl, 4, 0);
            tlpRoomControl.Controls.Add(tlpTimeLine, 0, 0);
            tlpRoomControl.Controls.Add(pnlOpeRoom1, 1, 0);
            tlpRoomControl.Controls.Add(pnlOpeRoom2, 2, 0);
            tlpRoomControl.Controls.Add(pnlOpeRoom3, 3, 0);
            tlpRoomControl.Dock = DockStyle.Fill;
            tlpRoomControl.Location = new Point(0, 0);
            tlpRoomControl.Name = "tlpRoomControl";
            tlpRoomControl.RowCount = 2;
            tlpRoomControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoomControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlpRoomControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRoomControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRoomControl.Size = new Size(1033, 631);
            tlpRoomControl.TabIndex = 0;
            // 
            // pnlButtom
            // 
            pnlButtom.BackColor = Color.FromArgb(192, 192, 255);
            tlpRoomControl.SetColumnSpan(pnlButtom, 5);
            pnlButtom.Controls.Add(button1);
            pnlButtom.Dock = DockStyle.Fill;
            pnlButtom.Location = new Point(3, 484);
            pnlButtom.Name = "pnlButtom";
            pnlButtom.Size = new Size(1027, 144);
            pnlButtom.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(237, 30);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flpRightControl
            // 
            flpRightControl.AutoScroll = true;
            flpRightControl.BackColor = Color.FromArgb(192, 192, 255);
            flpRightControl.Controls.Add(ucrTodoPanel1);
            flpRightControl.Controls.Add(panel1);
            flpRightControl.Controls.Add(pnlSelectRoom);
            flpRightControl.Dock = DockStyle.Fill;
            flpRightControl.Location = new Point(684, 3);
            flpRightControl.Name = "flpRightControl";
            flpRightControl.Size = new Size(346, 475);
            flpRightControl.TabIndex = 1;
            // 
            // ucrTodoPanel1
            // 
            ucrTodoPanel1.BackColor = Color.LightSteelBlue;
            ucrTodoPanel1.BorderStyle = BorderStyle.Fixed3D;
            ucrTodoPanel1.Location = new Point(12, 133);
            ucrTodoPanel1.Name = "ucrTodoPanel1";
            ucrTodoPanel1.Size = new Size(321, 255);
            ucrTodoPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReflection);
            panel1.Controls.Add(txtPatientId);
            panel1.Controls.Add(lblPatientName);
            panel1.Controls.Add(lblPatient);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 64);
            panel1.TabIndex = 1;
            // 
            // txtPatientId
            // 
            txtPatientId.CharacterCasing = CharacterCasing.Upper;
            txtPatientId.ImeMode = ImeMode.Off;
            txtPatientId.Location = new Point(59, 6);
            txtPatientId.MaxLength = 7;
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(100, 23);
            txtPatientId.TabIndex = 11;
            txtPatientId.KeyPress += txtPatientId_KeyPress;
            txtPatientId.KeyUp += txtPatientId_KeyUp;
            txtPatientId.Leave += txtPatientId_Leave;
            txtPatientId.Validating += txtPatientId_Validating;
            // 
            // btnReflection
            // 
            btnReflection.Location = new Point(195, 29);
            btnReflection.Name = "btnReflection";
            btnReflection.Size = new Size(116, 30);
            btnReflection.TabIndex = 8;
            btnReflection.Text = "反映";
            btnReflection.UseVisualStyleBackColor = true;
            btnReflection.Click += btnReflection_Click;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(63, 36);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(55, 15);
            lblPatientName.TabIndex = 3;
            lblPatientName.Text = "患者氏名";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(165, 9);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(55, 15);
            lblPatient.TabIndex = 2;
            lblPatient.Text = "患者情報";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "患者ID：";
            // 
            // pnlSelectRoom
            // 
            pnlSelectRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSelectRoom.Controls.Add(tglOpeTypeDefault);
            pnlSelectRoom.Controls.Add(tglOpeTypeSimple);
            pnlSelectRoom.Controls.Add(tglOpeTypeFull);
            pnlSelectRoom.Location = new Point(3, 3);
            pnlSelectRoom.Name = "pnlSelectRoom";
            pnlSelectRoom.Size = new Size(340, 50);
            pnlSelectRoom.TabIndex = 0;
            // 
            // tglOpeTypeDefault
            // 
            tglOpeTypeDefault.Appearance = Appearance.Button;
            tglOpeTypeDefault.BackColor = Color.FromArgb(255, 255, 192);
            tglOpeTypeDefault.Checked = true;
            tglOpeTypeDefault.Location = new Point(3, 6);
            tglOpeTypeDefault.Name = "tglOpeTypeDefault";
            tglOpeTypeDefault.Padding = new Padding(5);
            tglOpeTypeDefault.Size = new Size(105, 35);
            tglOpeTypeDefault.TabIndex = 0;
            tglOpeTypeDefault.TabStop = true;
            tglOpeTypeDefault.Text = "基本";
            tglOpeTypeDefault.TextAlign = ContentAlignment.MiddleCenter;
            tglOpeTypeDefault.UseVisualStyleBackColor = false;
            // 
            // tglOpeTypeSimple
            // 
            tglOpeTypeSimple.Appearance = Appearance.Button;
            tglOpeTypeSimple.BackColor = Color.Beige;
            tglOpeTypeSimple.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            tglOpeTypeSimple.FlatAppearance.CheckedBackColor = Color.Lime;
            tglOpeTypeSimple.Location = new Point(115, 6);
            tglOpeTypeSimple.Name = "tglOpeTypeSimple";
            tglOpeTypeSimple.Padding = new Padding(5);
            tglOpeTypeSimple.Size = new Size(105, 35);
            tglOpeTypeSimple.TabIndex = 1;
            tglOpeTypeSimple.TabStop = true;
            tglOpeTypeSimple.Text = "簡易";
            tglOpeTypeSimple.TextAlign = ContentAlignment.MiddleCenter;
            tglOpeTypeSimple.UseVisualStyleBackColor = false;
            // 
            // tglOpeTypeFull
            // 
            tglOpeTypeFull.Appearance = Appearance.Button;
            tglOpeTypeFull.BackColor = Color.Khaki;
            tglOpeTypeFull.Location = new Point(227, 6);
            tglOpeTypeFull.Name = "tglOpeTypeFull";
            tglOpeTypeFull.Padding = new Padding(5);
            tglOpeTypeFull.Size = new Size(105, 35);
            tglOpeTypeFull.TabIndex = 2;
            tglOpeTypeFull.TabStop = true;
            tglOpeTypeFull.Text = "フル";
            tglOpeTypeFull.TextAlign = ContentAlignment.MiddleCenter;
            tglOpeTypeFull.UseVisualStyleBackColor = false;
            // 
            // tlpTimeLine
            // 
            tlpTimeLine.BackColor = SystemColors.ControlLight;
            tlpTimeLine.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpTimeLine.ColumnCount = 1;
            tlpTimeLine.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpTimeLine.Controls.Add(lblTime0800, 0, 1);
            tlpTimeLine.Controls.Add(lblTime0830, 0, 2);
            tlpTimeLine.Controls.Add(lblTime0900, 0, 3);
            tlpTimeLine.Controls.Add(lblTime0930, 0, 4);
            tlpTimeLine.Controls.Add(lblTime1000, 0, 5);
            tlpTimeLine.Controls.Add(lblTime1030, 0, 6);
            tlpTimeLine.Controls.Add(lblTime1100, 0, 7);
            tlpTimeLine.Controls.Add(lblTime1130, 0, 8);
            tlpTimeLine.Controls.Add(lblTime1200, 0, 9);
            tlpTimeLine.Controls.Add(lblTime1230, 0, 10);
            tlpTimeLine.Controls.Add(lblTime1300, 0, 11);
            tlpTimeLine.Controls.Add(lblTime1330, 0, 12);
            tlpTimeLine.Controls.Add(lblTime1400, 0, 13);
            tlpTimeLine.Controls.Add(lblTime1430, 0, 14);
            tlpTimeLine.Controls.Add(lblTime1500, 0, 15);
            tlpTimeLine.Controls.Add(lblTime1530, 0, 16);
            tlpTimeLine.Controls.Add(lblTime1600, 0, 17);
            tlpTimeLine.Controls.Add(lblTime1630, 0, 18);
            tlpTimeLine.Controls.Add(lblTime1730, 0, 19);
            tlpTimeLine.Controls.Add(lblTime1800, 0, 20);
            tlpTimeLine.Controls.Add(lblTime1830, 0, 21);
            tlpTimeLine.Controls.Add(label1, 0, 0);
            tlpTimeLine.Dock = DockStyle.Fill;
            tlpTimeLine.Location = new Point(3, 35);
            tlpTimeLine.Margin = new Padding(3, 35, 3, 3);
            tlpTimeLine.Name = "tlpTimeLine";
            tlpTimeLine.RowCount = 22;
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTimeLine.Size = new Size(39, 443);
            tlpTimeLine.TabIndex = 5;
            // 
            // lblTime0800
            // 
            lblTime0800.Location = new Point(4, 21);
            lblTime0800.Name = "lblTime0800";
            lblTime0800.Size = new Size(34, 15);
            lblTime0800.TabIndex = 0;
            lblTime0800.Tag = "Times";
            lblTime0800.Text = "8:00";
            lblTime0800.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime0830
            // 
            lblTime0830.Location = new Point(4, 41);
            lblTime0830.Name = "lblTime0830";
            lblTime0830.Size = new Size(34, 15);
            lblTime0830.TabIndex = 0;
            lblTime0830.Tag = "Times";
            lblTime0830.Text = "8:30";
            lblTime0830.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime0900
            // 
            lblTime0900.Location = new Point(4, 61);
            lblTime0900.Name = "lblTime0900";
            lblTime0900.Size = new Size(34, 15);
            lblTime0900.TabIndex = 0;
            lblTime0900.Tag = "Times";
            lblTime0900.Text = "9:00";
            lblTime0900.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime0930
            // 
            lblTime0930.Location = new Point(4, 81);
            lblTime0930.Name = "lblTime0930";
            lblTime0930.Size = new Size(34, 15);
            lblTime0930.TabIndex = 0;
            lblTime0930.Tag = "Times";
            lblTime0930.Text = "9:30";
            lblTime0930.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1000
            // 
            lblTime1000.Location = new Point(4, 101);
            lblTime1000.Name = "lblTime1000";
            lblTime1000.Size = new Size(34, 15);
            lblTime1000.TabIndex = 0;
            lblTime1000.Tag = "Times";
            lblTime1000.Text = "10:00";
            lblTime1000.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1030
            // 
            lblTime1030.Location = new Point(4, 121);
            lblTime1030.Name = "lblTime1030";
            lblTime1030.Size = new Size(34, 15);
            lblTime1030.TabIndex = 0;
            lblTime1030.Tag = "Times";
            lblTime1030.Text = "10:30";
            lblTime1030.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1100
            // 
            lblTime1100.Location = new Point(4, 141);
            lblTime1100.Name = "lblTime1100";
            lblTime1100.Size = new Size(34, 15);
            lblTime1100.TabIndex = 0;
            lblTime1100.Tag = "Times";
            lblTime1100.Text = "11:00";
            lblTime1100.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1130
            // 
            lblTime1130.Location = new Point(4, 161);
            lblTime1130.Name = "lblTime1130";
            lblTime1130.Size = new Size(34, 15);
            lblTime1130.TabIndex = 0;
            lblTime1130.Tag = "Times";
            lblTime1130.Text = "11:30";
            lblTime1130.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1200
            // 
            lblTime1200.Location = new Point(4, 181);
            lblTime1200.Name = "lblTime1200";
            lblTime1200.Size = new Size(34, 15);
            lblTime1200.TabIndex = 0;
            lblTime1200.Tag = "Times";
            lblTime1200.Text = "12:00";
            lblTime1200.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1230
            // 
            lblTime1230.Location = new Point(4, 201);
            lblTime1230.Name = "lblTime1230";
            lblTime1230.Size = new Size(34, 15);
            lblTime1230.TabIndex = 0;
            lblTime1230.Tag = "Times";
            lblTime1230.Text = "12:30";
            lblTime1230.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1300
            // 
            lblTime1300.Location = new Point(4, 221);
            lblTime1300.Name = "lblTime1300";
            lblTime1300.Size = new Size(34, 15);
            lblTime1300.TabIndex = 0;
            lblTime1300.Tag = "Times";
            lblTime1300.Text = "13:00";
            lblTime1300.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1330
            // 
            lblTime1330.Location = new Point(4, 241);
            lblTime1330.Name = "lblTime1330";
            lblTime1330.Size = new Size(34, 15);
            lblTime1330.TabIndex = 0;
            lblTime1330.Tag = "Times";
            lblTime1330.Text = "13:30";
            lblTime1330.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1400
            // 
            lblTime1400.Location = new Point(4, 261);
            lblTime1400.Name = "lblTime1400";
            lblTime1400.Size = new Size(34, 15);
            lblTime1400.TabIndex = 0;
            lblTime1400.Tag = "Times";
            lblTime1400.Text = "14:00";
            lblTime1400.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1430
            // 
            lblTime1430.Location = new Point(4, 281);
            lblTime1430.Name = "lblTime1430";
            lblTime1430.Size = new Size(34, 15);
            lblTime1430.TabIndex = 0;
            lblTime1430.Tag = "Times";
            lblTime1430.Text = "14:30";
            lblTime1430.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1500
            // 
            lblTime1500.Location = new Point(4, 301);
            lblTime1500.Name = "lblTime1500";
            lblTime1500.Size = new Size(34, 15);
            lblTime1500.TabIndex = 0;
            lblTime1500.Tag = "Times";
            lblTime1500.Text = "15:00";
            lblTime1500.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1530
            // 
            lblTime1530.Location = new Point(4, 321);
            lblTime1530.Name = "lblTime1530";
            lblTime1530.Size = new Size(34, 15);
            lblTime1530.TabIndex = 0;
            lblTime1530.Tag = "Times";
            lblTime1530.Text = "15:30";
            lblTime1530.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1600
            // 
            lblTime1600.Location = new Point(4, 341);
            lblTime1600.Name = "lblTime1600";
            lblTime1600.Size = new Size(34, 15);
            lblTime1600.TabIndex = 0;
            lblTime1600.Tag = "Times";
            lblTime1600.Text = "16:00";
            lblTime1600.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1630
            // 
            lblTime1630.Location = new Point(4, 361);
            lblTime1630.Name = "lblTime1630";
            lblTime1630.Size = new Size(34, 15);
            lblTime1630.TabIndex = 1;
            lblTime1630.Tag = "Times";
            lblTime1630.Text = "16:30";
            lblTime1630.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1730
            // 
            lblTime1730.Location = new Point(4, 381);
            lblTime1730.Name = "lblTime1730";
            lblTime1730.Size = new Size(34, 15);
            lblTime1730.TabIndex = 1;
            lblTime1730.Tag = "Times";
            lblTime1730.Text = "17:30";
            lblTime1730.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1800
            // 
            lblTime1800.Location = new Point(4, 401);
            lblTime1800.Name = "lblTime1800";
            lblTime1800.Size = new Size(34, 15);
            lblTime1800.TabIndex = 1;
            lblTime1800.Tag = "Times";
            lblTime1800.Text = "18:00";
            lblTime1800.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTime1830
            // 
            lblTime1830.Location = new Point(4, 421);
            lblTime1830.Name = "lblTime1830";
            lblTime1830.Size = new Size(34, 15);
            lblTime1830.TabIndex = 1;
            lblTime1830.Tag = "Times";
            lblTime1830.Text = "18:30";
            lblTime1830.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "時間";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOpeRoom1
            // 
            pnlOpeRoom1.BackColor = Color.FromArgb(192, 255, 255);
            pnlOpeRoom1.BorderStyle = BorderStyle.Fixed3D;
            pnlOpeRoom1.Controls.Add(lblRoomTitle1);
            pnlOpeRoom1.Dock = DockStyle.Fill;
            pnlOpeRoom1.Location = new Point(46, 1);
            pnlOpeRoom1.Margin = new Padding(1);
            pnlOpeRoom1.Name = "pnlOpeRoom1";
            pnlOpeRoom1.Size = new Size(210, 479);
            pnlOpeRoom1.TabIndex = 2;
            // 
            // lblRoomTitle1
            // 
            lblRoomTitle1.BackColor = Color.LightSkyBlue;
            lblRoomTitle1.Dock = DockStyle.Top;
            lblRoomTitle1.Font = new Font("Yu Gothic UI", 16F);
            lblRoomTitle1.Location = new Point(0, 0);
            lblRoomTitle1.Margin = new Padding(3);
            lblRoomTitle1.MinimumSize = new Size(0, 50);
            lblRoomTitle1.Name = "lblRoomTitle1";
            lblRoomTitle1.Size = new Size(206, 50);
            lblRoomTitle1.TabIndex = 0;
            lblRoomTitle1.Text = "オペ室１";
            lblRoomTitle1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOpeRoom2
            // 
            pnlOpeRoom2.BackColor = Color.FromArgb(192, 255, 192);
            pnlOpeRoom2.BorderStyle = BorderStyle.Fixed3D;
            pnlOpeRoom2.Controls.Add(lblRoomTitle2);
            pnlOpeRoom2.Dock = DockStyle.Fill;
            pnlOpeRoom2.Location = new Point(258, 1);
            pnlOpeRoom2.Margin = new Padding(1);
            pnlOpeRoom2.Name = "pnlOpeRoom2";
            pnlOpeRoom2.Size = new Size(210, 479);
            pnlOpeRoom2.TabIndex = 3;
            // 
            // lblRoomTitle2
            // 
            lblRoomTitle2.BackColor = Color.LimeGreen;
            lblRoomTitle2.Dock = DockStyle.Top;
            lblRoomTitle2.Font = new Font("Yu Gothic UI", 16F);
            lblRoomTitle2.Location = new Point(3, 3);
            lblRoomTitle2.Margin = new Padding(3);
            lblRoomTitle2.MinimumSize = new Size(0, 50);
            lblRoomTitle2.Name = "lblRoomTitle2";
            lblRoomTitle2.Size = new Size(200, 50);
            lblRoomTitle2.TabIndex = 1;
            lblRoomTitle2.Text = "オペ室２";
            lblRoomTitle2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOpeRoom3
            // 
            pnlOpeRoom3.BackColor = Color.FromArgb(255, 224, 192);
            pnlOpeRoom3.BorderStyle = BorderStyle.Fixed3D;
            pnlOpeRoom3.Controls.Add(lblRoomTitle3);
            pnlOpeRoom3.Dock = DockStyle.Fill;
            pnlOpeRoom3.Location = new Point(470, 1);
            pnlOpeRoom3.Margin = new Padding(1);
            pnlOpeRoom3.Name = "pnlOpeRoom3";
            pnlOpeRoom3.Size = new Size(210, 479);
            pnlOpeRoom3.TabIndex = 4;
            // 
            // lblRoomTitle3
            // 
            lblRoomTitle3.BackColor = Color.Goldenrod;
            lblRoomTitle3.Dock = DockStyle.Top;
            lblRoomTitle3.Font = new Font("Yu Gothic UI", 16F);
            lblRoomTitle3.Location = new Point(3, 3);
            lblRoomTitle3.Margin = new Padding(3);
            lblRoomTitle3.MinimumSize = new Size(0, 50);
            lblRoomTitle3.Name = "lblRoomTitle3";
            lblRoomTitle3.Size = new Size(200, 50);
            lblRoomTitle3.TabIndex = 1;
            lblRoomTitle3.Text = "オペ室３";
            lblRoomTitle3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime1700
            // 
            lblTime1700.Location = new Point(4, 400);
            lblTime1700.Name = "lblTime1700";
            lblTime1700.Size = new Size(34, 15);
            lblTime1700.TabIndex = 1;
            lblTime1700.Text = "17:00";
            lblTime1700.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 631);
            Controls.Add(tlpRoomControl);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "メイン";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            Shown += frmMain_Shown;
            Resize += frmMain_Resize;
            tlpRoomControl.ResumeLayout(false);
            pnlButtom.ResumeLayout(false);
            flpRightControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSelectRoom.ResumeLayout(false);
            tlpTimeLine.ResumeLayout(false);
            tlpTimeLine.PerformLayout();
            pnlOpeRoom1.ResumeLayout(false);
            pnlOpeRoom2.ResumeLayout(false);
            pnlOpeRoom3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpRoomControl;

        private Panel pnlButtom;
        private Panel flpRightControl;
        private RoundedLabel lblRoomTitle1;
        private RoundedLabel lblRoomTitle2;
        private RoundedLabel lblRoomTitle3;
        private TableLayoutPanel tlpTimeLine;
        private Label lblTime0800;
        private Label lblTime0830;
        private Label lblTime0900;
        private Label lblTime0930;
        private Label lblTime1000;
        private Label lblTime1030;
        private Label lblTime1100;
        private Label lblTime1130;
        private Label lblTime1200;
        private Label lblTime1230;
        private Label lblTime1300;
        private Label lblTime1330;
        private Label lblTime1400;
        private Label lblTime1430;
        private Label lblTime1500;
        private Label lblTime1530;
        private Label lblTime1600;
        private Label lblTime1630;
        private Label lblTime1700;
        private Label lblTime1730;
        private Label lblTime1800;
        private Label lblTime1830;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblPatient;
        private Label lblPatientName;
        private Button btnReflection;
        private Panel pnlSelectRoom;
        private RadioButton tglOpeTypeDefault;
        private RadioButton tglOpeTypeSimple;
        private RadioButton tglOpeTypeFull;
        private Button button1;
        private ucrTodoPanel ucrTodoPanel1;
        private Panel pnlOpeRoom1;
        private FlowLayoutPanel pnlOpeRoom2;
        private FlowLayoutPanel pnlOpeRoom3;
        private TextBox txtPatientId;
        private ToolTip toolTip1;
    }
}
