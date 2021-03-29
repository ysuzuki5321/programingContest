
namespace Remainder
{
    partial class Exam
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
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.AutoScroll = true;
            this.AnswersPanel.Location = new System.Drawing.Point(1408, 22);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(1084, 624);
            this.AnswersPanel.TabIndex = 1;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(2191, 983);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(313, 128);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "確認";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2507, 1114);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.AnswersPanel);
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.Controls.SetChildIndex(this.ProblemText, 0);
            this.Controls.SetChildIndex(this.AnswersPanel, 0);
            this.Controls.SetChildIndex(this.Confirm, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Button Confirm;
    }
}