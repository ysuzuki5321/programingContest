namespace Remainder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TodayGrid = new System.Windows.Forms.DataGridView();
            this.Url = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TodayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TodayGrid
            // 
            this.TodayGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TodayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodayGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.TodayGrid.Location = new System.Drawing.Point(12, 48);
            this.TodayGrid.Name = "TodayGrid";
            this.TodayGrid.RowHeadersWidth = 62;
            this.TodayGrid.RowTemplate.Height = 27;
            this.TodayGrid.Size = new System.Drawing.Size(2006, 1049);
            this.TodayGrid.TabIndex = 0;
            this.TodayGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodayGrid_CellContentClick);
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "Url";
            this.Url.MinimumWidth = 8;
            this.Url.Name = "Url";
            this.Url.Width = 36;
            // 
            // Remainder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2033, 1109);
            this.Controls.Add(this.TodayGrid);
            this.Name = "Remainder";
            this.Text = "Remainder";
            this.Load += new System.EventHandler(this.Remainder_Load);
            this.SizeChanged += new System.EventHandler(this.Remainder_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.TodayGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TodayGrid;
        private System.Windows.Forms.DataGridViewLinkColumn Url;
    }
}

