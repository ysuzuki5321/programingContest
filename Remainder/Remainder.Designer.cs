﻿namespace Remainder
{
    partial class Remainder
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TodayGrid = new System.Windows.Forms.DataGridView();
            this.RegistButton = new System.Windows.Forms.Button();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TodayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TodayGrid
            // 
            this.TodayGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TodayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.TodayGrid.Location = new System.Drawing.Point(13, 163);
            this.TodayGrid.Margin = new System.Windows.Forms.Padding(4);
            this.TodayGrid.Name = "TodayGrid";
            this.TodayGrid.RowHeadersWidth = 62;
            this.TodayGrid.RowTemplate.Height = 27;
            this.TodayGrid.Size = new System.Drawing.Size(2614, 1303);
            this.TodayGrid.TabIndex = 0;
            this.TodayGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodayGrid_CellContentClick);
            // 
            // RegistButton
            // 
            this.RegistButton.Location = new System.Drawing.Point(13, 46);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(142, 98);
            this.RegistButton.TabIndex = 1;
            this.RegistButton.Text = "新規登録";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(175, 46);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(500, 31);
            this.NoteText.TabIndex = 2;
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(175, 113);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(500, 31);
            this.UrlText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "備考";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Url";
            // 
            // Remainder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2974, 1479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrlText);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.TodayGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Remainder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remainder";
            this.Load += new System.EventHandler(this.Remainder_Load);
            this.SizeChanged += new System.EventHandler(this.Remainder_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.TodayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TodayGrid;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

