
namespace Remainder
{
    partial class CreateProblem
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
            this.AnswerList = new System.Windows.Forms.ListBox();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.AddAnswer = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProblemText
            // 
            this.ProblemText.Location = new System.Drawing.Point(12, 12);
            // 
            // AnswerList
            // 
            this.AnswerList.Font = new System.Drawing.Font("MS UI Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerList.FormattingEnabled = true;
            this.AnswerList.ItemHeight = 29;
            this.AnswerList.Location = new System.Drawing.Point(1418, 12);
            this.AnswerList.Name = "AnswerList";
            this.AnswerList.Size = new System.Drawing.Size(1025, 584);
            this.AnswerList.TabIndex = 1;
            // 
            // AnswerText
            // 
            this.AnswerText.Font = new System.Drawing.Font("MS UI Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerText.Location = new System.Drawing.Point(1418, 634);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(560, 36);
            this.AnswerText.TabIndex = 2;
            // 
            // AddAnswer
            // 
            this.AddAnswer.Location = new System.Drawing.Point(2171, 622);
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(272, 149);
            this.AddAnswer.TabIndex = 3;
            this.AddAnswer.Text = "追加";
            this.AddAnswer.UseVisualStyleBackColor = true;
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(2171, 899);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(287, 125);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "登録";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2461, 1027);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AddAnswer);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.AnswerList);
            this.Name = "CreateProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProblem";
            this.Load += new System.EventHandler(this.CreateProblem_Load);
            this.Controls.SetChildIndex(this.AnswerList, 0);
            this.Controls.SetChildIndex(this.AnswerText, 0);
            this.Controls.SetChildIndex(this.AddAnswer, 0);
            this.Controls.SetChildIndex(this.CreateButton, 0);
            this.Controls.SetChildIndex(this.ProblemText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox AnswerList;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Button AddAnswer;
        private System.Windows.Forms.Button CreateButton;
    }
}