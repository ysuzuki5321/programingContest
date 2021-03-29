
namespace Remainder
{
    partial class ProblemBase
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
            this.ProblemText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ProblemText
            // 
            this.ProblemText.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProblemText.Location = new System.Drawing.Point(12, 22);
            this.ProblemText.Name = "ProblemText";
            this.ProblemText.Size = new System.Drawing.Size(1374, 986);
            this.ProblemText.TabIndex = 0;
            this.ProblemText.Text = "";
            // 
            // ProblemBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2247, 1020);
            this.Controls.Add(this.ProblemText);
            this.Name = "ProblemBase";
            this.Text = "ProblemBase";
            this.Load += new System.EventHandler(this.ProblemBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.RichTextBox ProblemText;
    }
}