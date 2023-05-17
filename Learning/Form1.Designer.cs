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
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(436, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // courseReq
            // 
            courseReq.Location = new Point(131, 12);
            courseReq.Name = "courseReq";
            courseReq.Size = new Size(113, 23);
            courseReq.TabIndex = 1;
            courseReq.Text = "Курс через XML";
            courseReq.UseVisualStyleBackColor = true;
            courseReq.Click += courseReq_Click;
            // 
            // getCoursJSON
            // 
            getCoursJSON.Location = new Point(12, 12);
            getCoursJSON.Name = "getCoursJSON";
            getCoursJSON.Size = new Size(113, 23);
            getCoursJSON.TabIndex = 2;
            getCoursJSON.Text = "Курс через JSON";
            getCoursJSON.UseVisualStyleBackColor = true;
            getCoursJSON.Click += getCoursJSON_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 79);
            Controls.Add(getCoursJSON);
            Controls.Add(courseReq);
            Controls.Add(closeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button closeButton;
        private Button courseReq;
        private Button getCoursJSON;
    }
}