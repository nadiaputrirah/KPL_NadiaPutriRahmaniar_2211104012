namespace tp_modul3_2211104012
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtInput = new TextBox();
            button1 = new Button();
            label_output = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(177, 107);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 20, 10);
            label1.Size = new Size(179, 40);
            label1.TabIndex = 0;
            label1.Text = "Masukkan nama kamu ";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(177, 150);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(199, 27);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(382, 145);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_output
            // 
            label_output.AutoSize = true;
            label_output.BackColor = Color.FromArgb(255, 192, 128);
            label_output.Location = new Point(177, 202);
            label_output.Name = "label_output";
            label_output.Padding = new Padding(10, 6, 10, 6);
            label_output.Size = new Size(75, 32);
            label_output.TabIndex = 3;
            label_output.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_output);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Button button1;
        private Label label_output;
    }
}
