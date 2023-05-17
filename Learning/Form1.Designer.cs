namespace Learning
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
            closeButton = new Button();
            courseReq = new Button();
            getCoursJSON = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(105, 397);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // courseReq
            // 
            courseReq.Location = new Point(86, 359);
            courseReq.Name = "courseReq";
            courseReq.Size = new Size(113, 23);
            courseReq.TabIndex = 1;
            courseReq.Text = "Запрос курса";
            courseReq.UseVisualStyleBackColor = true;
            courseReq.Click += courseReq_Click;
            // 
            // getCoursJSON
            // 
            getCoursJSON.Location = new Point(86, 330);
            getCoursJSON.Name = "getCoursJSON";
            getCoursJSON.Size = new Size(113, 23);
            getCoursJSON.TabIndex = 2;
            getCoursJSON.Text = "button1";
            getCoursJSON.UseVisualStyleBackColor = true;
            getCoursJSON.Click += getCoursJSON_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 439);
            Controls.Add(textBox1);
            Controls.Add(getCoursJSON);
            Controls.Add(courseReq);
            Controls.Add(closeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Button courseReq;
        private Button getCoursJSON;
        private TextBox textBox1;
    }
}