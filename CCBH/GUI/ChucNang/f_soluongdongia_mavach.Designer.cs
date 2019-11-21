﻿namespace GUI.ChucNang
{
    partial class f_soluongdongia_mavach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_soluongdongia_mavach));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtdongia = new DevExpress.XtraEditors.SpinEdit();
            this.txtsoluong = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtdongia);
            this.layoutControl1.Controls.Add(this.txtsoluong);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(290, 74);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtdongia
            // 
            this.txtdongia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtdongia.Location = new System.Drawing.Point(60, 36);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdongia.Properties.Mask.EditMask = "n2";
            this.txtdongia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtdongia.Properties.ReadOnly = true;
            this.txtdongia.Size = new System.Drawing.Size(218, 20);
            this.txtdongia.StyleController = this.layoutControl1;
            this.txtdongia.TabIndex = 5;
            // 
            // txtsoluong
            // 
            this.txtsoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtsoluong.Location = new System.Drawing.Point(60, 12);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Properties.AllowMouseWheel = false;
            this.txtsoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsoluong.Properties.Mask.EditMask = "n2";
            this.txtsoluong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtsoluong.Size = new System.Drawing.Size(218, 20);
            this.txtsoluong.StyleController = this.layoutControl1;
            this.txtsoluong.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(290, 74);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtsoluong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(270, 24);
            this.layoutControlItem1.Text = "Số Lượng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtdongia;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(270, 30);
            this.layoutControlItem2.Text = "Đơn Giá";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // f_soluongdongia_mavach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 74);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "f_soluongdongia_mavach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_soluongdongia_FormClosing);
            this.Load += new System.EventHandler(this.f_soluongdongia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_soluongdongia_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit txtdongia;
        private DevExpress.XtraEditors.SpinEdit txtsoluong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.Timer timer1;
    }
}