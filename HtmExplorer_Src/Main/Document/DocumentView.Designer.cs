﻿namespace htmExplorer
{
    partial class DocumentView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentView));
            this.tabControl1 = new System.Windows.Forms.TabControlExt();
            this.labelButton1 = new System.Windows.Forms.LabelButton();
            this.labelButton2 = new System.Windows.Forms.LabelButton();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(754, 376);
            this.tabControl1.TabIndex = 42;
            // 
            // labelButton1
            // 
            this.labelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelButton1.BackColor = System.Drawing.Color.Transparent;
            this.labelButton1.BorderColor = System.Drawing.Color.Transparent;
            this.labelButton1.DefautColor = System.Drawing.Color.Transparent;
            this.labelButton1.DefautImage = null;
            this.labelButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelButton1.Location = new System.Drawing.Point(718, 6);
            this.labelButton1.MouseDownColor = System.Drawing.Color.Transparent;
            this.labelButton1.MouseDownImage = null;
            this.labelButton1.MouseEnterColor = System.Drawing.Color.Transparent;
            this.labelButton1.MouseEnterImage = null;
            this.labelButton1.Name = "labelButton1";
            this.labelButton1.Size = new System.Drawing.Size(46, 18);
            this.labelButton1.TabIndex = 43;
            // 
            // labelButton2
            // 
            this.labelButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelButton2.BackColor = System.Drawing.Color.White;
            this.labelButton2.BorderColor = System.Drawing.Color.Transparent;
            this.labelButton2.DefautColor = System.Drawing.Color.White;
            this.labelButton2.DefautImage = ((System.Drawing.Image)(resources.GetObject("labelButton2.DefautImage")));
            this.labelButton2.Image = ((System.Drawing.Image)(resources.GetObject("labelButton2.Image")));
            this.labelButton2.Location = new System.Drawing.Point(733, 7);
            this.labelButton2.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(101)))), ((int)(((byte)(179)))));
            this.labelButton2.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("labelButton2.MouseDownImage")));
            this.labelButton2.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.labelButton2.MouseEnterImage = null;
            this.labelButton2.Name = "labelButton2";
            this.labelButton2.Size = new System.Drawing.Size(16, 16);
            this.labelButton2.TabIndex = 44;
            // 
            // DocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelButton2);
            this.Controls.Add(this.labelButton1);
            this.Controls.Add(this.tabControl1);
            this.Name = "DocumentView";
            this.Size = new System.Drawing.Size(754, 376);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControlExt tabControl1;
        private System.Windows.Forms.LabelButton labelButton1;
        private System.Windows.Forms.LabelButton labelButton2;
    }
}