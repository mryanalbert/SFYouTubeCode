namespace TipCalculator
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            txtPercentage = new TextBox();
            btnCalculateTip = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 65);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Tip Percentage";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(200, 25);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(148, 32);
            txtAmount.TabIndex = 2;
            // 
            // txtPercentage
            // 
            txtPercentage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPercentage.Location = new Point(200, 65);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Size = new Size(148, 32);
            txtPercentage.TabIndex = 3;
            // 
            // btnCalculateTip
            // 
            btnCalculateTip.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculateTip.Location = new Point(109, 121);
            btnCalculateTip.Name = "btnCalculateTip";
            btnCalculateTip.Size = new Size(199, 54);
            btnCalculateTip.TabIndex = 4;
            btnCalculateTip.Text = "Calculate Tip";
            btnCalculateTip.UseVisualStyleBackColor = true;
            btnCalculateTip.Click += btnCalculateTip_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(402, 28);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 204);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateTip);
            Controls.Add(txtPercentage);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAmount;
        private TextBox txtPercentage;
        private Button btnCalculateTip;
        private Label lblResult;
    }
}