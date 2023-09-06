namespace AtmSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblWithdrawl = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnWithdrawl = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalPayments = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnRecepit = new System.Windows.Forms.Button();
            this.btnLoanSystem = new System.Windows.Forms.Button();
            this.ritext = new System.Windows.Forms.RichTextBox();
            this.lblMonthPayments = new System.Windows.Forms.TextBox();
            this.textIntRate = new System.Windows.Forms.TextBox();
            this.textNoOfYears = new System.Windows.Forms.TextBox();
            this.textAmountofLoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblPin);
            this.groupBox1.Controls.Add(this.lblDeposit);
            this.groupBox1.Controls.Add(this.lblLoan);
            this.groupBox1.Controls.Add(this.lblWithdrawl);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(254, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPin
            // 
            this.lblPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(6, 89);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(207, 69);
            this.lblPin.TabIndex = 0;
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(142, 163);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(71, 20);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(156, 58);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(49, 20);
            this.lblLoan.TabIndex = 0;
            this.lblLoan.Text = "Loan";
            this.lblLoan.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblWithdrawl
            // 
            this.lblWithdrawl.AutoSize = true;
            this.lblWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawl.Location = new System.Drawing.Point(6, 163);
            this.lblWithdrawl.Name = "lblWithdrawl";
            this.lblWithdrawl.Size = new System.Drawing.Size(87, 20);
            this.lblWithdrawl.TabIndex = 0;
            this.lblWithdrawl.Text = "Withdrawl";
            this.lblWithdrawl.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(6, 58);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(74, 20);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeposit);
            this.groupBox2.Controls.Add(this.btnLoan);
            this.groupBox2.Location = new System.Drawing.Point(479, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.Location = new System.Drawing.Point(0, 112);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(173, 86);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.Location = new System.Drawing.Point(0, 16);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(173, 93);
            this.btnLoan.TabIndex = 0;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBalance);
            this.groupBox3.Controls.Add(this.btnWithdrawl);
            this.groupBox3.Location = new System.Drawing.Point(57, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 198);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnBalance
            // 
            this.btnBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnBalance.Image")));
            this.btnBalance.Location = new System.Drawing.Point(16, 19);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(169, 82);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnWithdrawl
            // 
            this.btnWithdrawl.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdrawl.Image")));
            this.btnWithdrawl.Location = new System.Drawing.Point(16, 112);
            this.btnWithdrawl.Name = "btnWithdrawl";
            this.btnWithdrawl.Size = new System.Drawing.Size(169, 86);
            this.btnWithdrawl.TabIndex = 0;
            this.btnWithdrawl.UseVisualStyleBackColor = true;
            this.btnWithdrawl.Click += new System.EventHandler(this.btnWithdrawl_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.btn3);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(42, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 300);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(410, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 65);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(406, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 74);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(33, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 66);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button21
            // 
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.Location = new System.Drawing.Point(33, 220);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(117, 61);
            this.button21.TabIndex = 1;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(33, 153);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(117, 61);
            this.button17.TabIndex = 1;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(406, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 72);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn1
            // 
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(33, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(117, 72);
            this.btn1.TabIndex = 1;
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button9_Click);
            // 
            // button19
            // 
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.Location = new System.Drawing.Point(278, 220);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(116, 61);
            this.button19.TabIndex = 1;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(156, 220);
            this.button14.Name = "button14";
            this.button14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button14.Size = new System.Drawing.Size(116, 61);
            this.button14.TabIndex = 1;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn3
            // 
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(278, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(116, 68);
            this.btn3.TabIndex = 1;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button7_Click);
            // 
            // button20
            // 
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.Location = new System.Drawing.Point(406, 153);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(217, 61);
            this.button20.TabIndex = 1;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(156, 153);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(116, 61);
            this.button16.TabIndex = 1;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(278, 153);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(116, 61);
            this.button15.TabIndex = 1;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button12
            // 
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(156, 81);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(116, 66);
            this.button12.TabIndex = 1;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(278, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 64);
            this.button11.TabIndex = 1;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn2
            // 
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(156, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 70);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, -92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Controls.Add(this.lblTotalPayments);
            this.groupBox5.Controls.Add(this.btnReset);
            this.groupBox5.Controls.Add(this.BtnRecepit);
            this.groupBox5.Controls.Add(this.btnLoanSystem);
            this.groupBox5.Controls.Add(this.ritext);
            this.groupBox5.Controls.Add(this.lblMonthPayments);
            this.groupBox5.Controls.Add(this.textIntRate);
            this.groupBox5.Controls.Add(this.textNoOfYears);
            this.groupBox5.Controls.Add(this.textAmountofLoan);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(691, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(634, 498);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(491, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.Location = new System.Drawing.Point(10, 330);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(100, 22);
            this.lblTotalPayments.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(268, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // BtnRecepit
            // 
            this.BtnRecepit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecepit.Location = new System.Drawing.Point(142, 448);
            this.BtnRecepit.Name = "BtnRecepit";
            this.BtnRecepit.Size = new System.Drawing.Size(90, 44);
            this.BtnRecepit.TabIndex = 5;
            this.BtnRecepit.Text = "Recepit";
            this.BtnRecepit.UseVisualStyleBackColor = true;
            this.BtnRecepit.Click += new System.EventHandler(this.BtnRecepit_Click);
            // 
            // btnLoanSystem
            // 
            this.btnLoanSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanSystem.Location = new System.Drawing.Point(20, 448);
            this.btnLoanSystem.Name = "btnLoanSystem";
            this.btnLoanSystem.Size = new System.Drawing.Size(89, 44);
            this.btnLoanSystem.TabIndex = 4;
            this.btnLoanSystem.Text = "Loan";
            this.btnLoanSystem.UseVisualStyleBackColor = true;
            this.btnLoanSystem.Click += new System.EventHandler(this.btnLoanSystem_Click);
            // 
            // ritext
            // 
            this.ritext.Location = new System.Drawing.Point(249, 70);
            this.ritext.Name = "ritext";
            this.ritext.Size = new System.Drawing.Size(379, 372);
            this.ritext.TabIndex = 3;
            this.ritext.Text = "";
            this.ritext.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblMonthPayments
            // 
            this.lblMonthPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthPayments.Location = new System.Drawing.Point(10, 273);
            this.lblMonthPayments.Name = "lblMonthPayments";
            this.lblMonthPayments.Size = new System.Drawing.Size(100, 22);
            this.lblMonthPayments.TabIndex = 2;
            // 
            // textIntRate
            // 
            this.textIntRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIntRate.Location = new System.Drawing.Point(9, 204);
            this.textIntRate.Name = "textIntRate";
            this.textIntRate.Size = new System.Drawing.Size(100, 22);
            this.textIntRate.TabIndex = 1;
            // 
            // textNoOfYears
            // 
            this.textNoOfYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNoOfYears.Location = new System.Drawing.Point(10, 135);
            this.textNoOfYears.Name = "textNoOfYears";
            this.textNoOfYears.Size = new System.Drawing.Size(100, 22);
            this.textNoOfYears.TabIndex = 1;
            this.textNoOfYears.TextChanged += new System.EventHandler(this.textNoOfYears_TextChanged);
            // 
            // textAmountofLoan
            // 
            this.textAmountofLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmountofLoan.Location = new System.Drawing.Point(10, 85);
            this.textAmountofLoan.Name = "textAmountofLoan";
            this.textAmountofLoan.Size = new System.Drawing.Size(100, 22);
            this.textAmountofLoan.TabIndex = 1;
            this.textAmountofLoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Payments";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monthly Payments";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Interest Rate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Number of Year";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount of Loan";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnWithdrawl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblWithdrawl;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIntRate;
        private System.Windows.Forms.TextBox textNoOfYears;
        private System.Windows.Forms.TextBox textAmountofLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ritext;
        private System.Windows.Forms.TextBox lblMonthPayments;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnRecepit;
        private System.Windows.Forms.Button btnLoanSystem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox lblTotalPayments;
    }
}

