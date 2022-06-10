
namespace OO_programming
{
    partial class frmPayCalc
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbHrsWorked = new System.Windows.Forms.TextBox();
            this.btnCalcPay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSavePaySummary = new System.Windows.Forms.Button();
            this.tbPaymentSummary = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours Worked (hrs)";
            // 
            // tbHrsWorked
            // 
            this.tbHrsWorked.Location = new System.Drawing.Point(246, 430);
            this.tbHrsWorked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHrsWorked.Name = "tbHrsWorked";
            this.tbHrsWorked.Size = new System.Drawing.Size(136, 31);
            this.tbHrsWorked.TabIndex = 3;
            this.tbHrsWorked.Text = "0";
            this.tbHrsWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcPay
            // 
            this.btnCalcPay.Location = new System.Drawing.Point(315, 545);
            this.btnCalcPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcPay.Name = "btnCalcPay";
            this.btnCalcPay.Size = new System.Drawing.Size(136, 36);
            this.btnCalcPay.TabIndex = 4;
            this.btnCalcPay.Text = "Calculate";
            this.btnCalcPay.UseVisualStyleBackColor = true;
            this.btnCalcPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEmployees);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHrsWorked);
            this.groupBox1.Location = new System.Drawing.Point(69, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(436, 592);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 25;
            this.lbEmployees.Location = new System.Drawing.Point(44, 75);
            this.lbEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(337, 329);
            this.lbEmployees.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSavePaySummary);
            this.groupBox2.Controls.Add(this.tbPaymentSummary);
            this.groupBox2.Location = new System.Drawing.Point(603, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(422, 592);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Summary";
            // 
            // btnSavePaySummary
            // 
            this.btnSavePaySummary.Location = new System.Drawing.Point(272, 502);
            this.btnSavePaySummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavePaySummary.Name = "btnSavePaySummary";
            this.btnSavePaySummary.Size = new System.Drawing.Size(112, 36);
            this.btnSavePaySummary.TabIndex = 1;
            this.btnSavePaySummary.Text = "Save";
            this.btnSavePaySummary.UseVisualStyleBackColor = true;
            this.btnSavePaySummary.Visible = false;
            this.btnSavePaySummary.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPaymentSummary
            // 
            this.tbPaymentSummary.Location = new System.Drawing.Point(34, 67);
            this.tbPaymentSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPaymentSummary.Multiline = true;
            this.tbPaymentSummary.Name = "tbPaymentSummary";
            this.tbPaymentSummary.ReadOnly = true;
            this.tbPaymentSummary.Size = new System.Drawing.Size(349, 395);
            this.tbPaymentSummary.TabIndex = 0;
            this.tbPaymentSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmPayCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcPay);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPayCalc";
            this.Text = "Weekly Payment Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHrsWorked;
        private System.Windows.Forms.Button btnCalcPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPaymentSummary;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnSavePaySummary;
    }
}

