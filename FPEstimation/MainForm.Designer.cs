namespace FPEstimation
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageER = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageDFD = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ERIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERIsPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERIsFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERToForeign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル (&F)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageER);
            this.tabControl1.Controls.Add(this.tabPageDFD);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 373);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageER
            // 
            this.tabPageER.Controls.Add(this.dataGridView1);
            this.tabPageER.Location = new System.Drawing.Point(4, 22);
            this.tabPageER.Name = "tabPageER";
            this.tabPageER.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageER.Size = new System.Drawing.Size(768, 347);
            this.tabPageER.TabIndex = 0;
            this.tabPageER.Text = "ER図";
            this.tabPageER.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ERIndex,
            this.ERTableName,
            this.ERColumnName,
            this.ERIsPK,
            this.ERIsFK,
            this.ERToForeign});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(756, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageDFD
            // 
            this.tabPageDFD.Location = new System.Drawing.Point(4, 22);
            this.tabPageDFD.Name = "tabPageDFD";
            this.tabPageDFD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDFD.Size = new System.Drawing.Size(768, 347);
            this.tabPageDFD.TabIndex = 1;
            this.tabPageDFD.Text = "DFD";
            this.tabPageDFD.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ERIndex
            // 
            this.ERIndex.HeaderText = "番号";
            this.ERIndex.Name = "ERIndex";
            this.ERIndex.ReadOnly = true;
            // 
            // ERTableName
            // 
            this.ERTableName.HeaderText = "テーブル名";
            this.ERTableName.Name = "ERTableName";
            // 
            // ERColumnName
            // 
            this.ERColumnName.HeaderText = "カラム名";
            this.ERColumnName.Name = "ERColumnName";
            // 
            // ERIsPK
            // 
            this.ERIsPK.HeaderText = "PK";
            this.ERIsPK.Name = "ERIsPK";
            // 
            // ERIsFK
            // 
            this.ERIsFK.HeaderText = "FK";
            this.ERIsFK.Name = "ERIsFK";
            // 
            // ERToForeign
            // 
            this.ERToForeign.HeaderText = "To";
            this.ERToForeign.Name = "ERToForeign";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageER;
        private System.Windows.Forms.TabPage tabPageDFD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERIsPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERIsFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERToForeign;
    }
}

