namespace Course2_Task1_Lists
{
    partial class ListForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.ListTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(512, 50);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(255, 388);
            this.ResultTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(45, 128);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(141, 65);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Input from file";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.Red;
            this.RunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RunButton.Location = new System.Drawing.Point(45, 235);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(141, 65);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run!";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ListTextBox
            // 
            this.ListTextBox.Location = new System.Drawing.Point(230, 50);
            this.ListTextBox.Multiline = true;
            this.ListTextBox.Name = "ListTextBox";
            this.ListTextBox.Size = new System.Drawing.Size(255, 388);
            this.ListTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(507, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.ResultTextBox);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ListTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}