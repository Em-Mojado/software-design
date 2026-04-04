namespace lab2
{
	partial class btnCalculateSum
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
            btnCalculateFactorial = new Button();
            txtNumber = new TextBox();
            lblResult = new Label();
            button1 = new Button();
            lblSumResult = new Label();
            txtArrayInput = new TextBox();
            txtFibonacciInput = new TextBox();
            txtBaseInput = new TextBox();
            lblFibonacciResult = new Label();
            lblPowerResult = new Label();
            btnCalculateFibonacci = new Button();
            brnCalculatePower = new Button();
            txtExponentInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(490, 29);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(206, 34);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(105, 29);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(328, 34);
            txtNumber.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(105, 66);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(167, 47);
            lblResult.TabIndex = 2;
            lblResult.Text = "Factorial: ";
            // 
            // button1
            // 
            button1.Location = new Point(490, 116);
            button1.Name = "button1";
            button1.Size = new Size(206, 34);
            button1.TabIndex = 3;
            button1.Text = "Calculate Sum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(105, 153);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(97, 47);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Sum:";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(105, 116);
            txtArrayInput.Multiline = true;
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(328, 34);
            txtArrayInput.TabIndex = 5;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(105, 203);
            txtFibonacciInput.Multiline = true;
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(328, 34);
            txtFibonacciInput.TabIndex = 6;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(105, 347);
            txtBaseInput.Multiline = true;
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(157, 34);
            txtBaseInput.TabIndex = 7;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFibonacciResult.Location = new Point(105, 240);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(173, 47);
            lblFibonacciResult.TabIndex = 8;
            lblFibonacciResult.Text = "Fibonacci:";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(105, 384);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(121, 47);
            lblPowerResult.TabIndex = 9;
            lblPowerResult.Text = "Result:";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(490, 203);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(206, 35);
            btnCalculateFibonacci.TabIndex = 10;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // brnCalculatePower
            // 
            brnCalculatePower.Location = new Point(490, 347);
            brnCalculatePower.Name = "brnCalculatePower";
            brnCalculatePower.Size = new Size(206, 34);
            brnCalculatePower.TabIndex = 11;
            brnCalculatePower.Text = "Calculate Power";
            brnCalculatePower.UseVisualStyleBackColor = true;
            brnCalculatePower.Click += brnCalculatePower_Click;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(273, 348);
            txtExponentInput.Multiline = true;
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(160, 33);
            txtExponentInput.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 329);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 13;
            label1.Text = "Base Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 329);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Exponent";
            // 
            // btnCalculateSum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExponentInput);
            Controls.Add(brnCalculatePower);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(lblPowerResult);
            Controls.Add(lblFibonacciResult);
            Controls.Add(txtBaseInput);
            Controls.Add(txtFibonacciInput);
            Controls.Add(txtArrayInput);
            Controls.Add(lblSumResult);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(txtNumber);
            Controls.Add(btnCalculateFactorial);
            Name = "btnCalculateSum";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private TextBox txtNumber;
        private Label lblResult;
        private Button button1;
        private Label lblSumResult;
        private TextBox txtArrayInput;
        private TextBox txtFibonacciInput;
        private TextBox txtBaseInput;
        private Label lblFibonacciResult;
        private Label lblPowerResult;
        private Button btnCalculateFibonacci;
        private Button brnCalculatePower;
        private TextBox txtExponentInput;
        private Label label1;
        private Label label2;
    }
}
