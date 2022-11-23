namespace WindowsOrderUI;

partial class OrderManagerWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkLblWebsite = new System.Windows.Forms.LinkLabel();
            this.picQRcode = new System.Windows.Forms.PictureBox();
            this.btnSetOrderPickedUp = new System.Windows.Forms.Button();
            this.btnSetOrderReady = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSetOrderPickedUp);
            this.splitContainer1.Panel1.Controls.Add(this.btnSetOrderReady);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstOrders);
            this.splitContainer1.Size = new System.Drawing.Size(1716, 1035);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lnkLblWebsite);
            this.groupBox1.Controls.Add(this.picQRcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 582);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order website";
            // 
            // lnkLblWebsite
            // 
            this.lnkLblWebsite.AutoSize = true;
            this.lnkLblWebsite.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkLblWebsite.Location = new System.Drawing.Point(31, 398);
            this.lnkLblWebsite.Name = "lnkLblWebsite";
            this.lnkLblWebsite.Size = new System.Drawing.Size(332, 32);
            this.lnkLblWebsite.TabIndex = 5;
            this.lnkLblWebsite.TabStop = true;
            this.lnkLblWebsite.Text = "https://orders.codesamples.dk";
            this.lnkLblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picQRcode
            // 
            this.picQRcode.Image = global::WindowsOrderUI.Properties.Resources.https_orders_codesamples_dk;
            this.picQRcode.Location = new System.Drawing.Point(21, 70);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(353, 325);
            this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRcode.TabIndex = 4;
            this.picQRcode.TabStop = false;
            // 
            // btnSetOrderPickedUp
            // 
            this.btnSetOrderPickedUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetOrderPickedUp.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetOrderPickedUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetOrderPickedUp.Location = new System.Drawing.Point(13, 255);
            this.btnSetOrderPickedUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetOrderPickedUp.Name = "btnSetOrderPickedUp";
            this.btnSetOrderPickedUp.Size = new System.Drawing.Size(387, 111);
            this.btnSetOrderPickedUp.TabIndex = 0;
            this.btnSetOrderPickedUp.Text = "Mark  order \"&Picked up\"";
            this.btnSetOrderPickedUp.UseVisualStyleBackColor = false;
            // 
            // btnSetOrderReady
            // 
            this.btnSetOrderReady.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetOrderReady.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetOrderReady.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetOrderReady.Location = new System.Drawing.Point(13, 134);
            this.btnSetOrderReady.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetOrderReady.Name = "btnSetOrderReady";
            this.btnSetOrderReady.Size = new System.Drawing.Size(387, 111);
            this.btnSetOrderReady.TabIndex = 0;
            this.btnSetOrderReady.Text = "Mark order \"&Ready\"";
            this.btnSetOrderReady.UseVisualStyleBackColor = false;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateOrder.Location = new System.Drawing.Point(13, 13);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(387, 111);
            this.btnCreateOrder.TabIndex = 0;
            this.btnCreateOrder.Text = "&Create order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // lstOrders
            // 
            this.lstOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 25;
            this.lstOrders.Location = new System.Drawing.Point(0, 0);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(1295, 1035);
            this.lstOrders.TabIndex = 0;
            // 
            // OrderManagerWindow
            // 
            this.AcceptButton = this.btnCreateOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 1035);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderManagerWindow";
            this.Text = "Order manager window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private SplitContainer splitContainer1;
    private Button btnSetOrderPickedUp;
    private Button btnSetOrderReady;
    private Button btnCreateOrder;
    private ListBox lstOrders;
    private GroupBox groupBox1;
    private Label label1;
    private LinkLabel lnkLblWebsite;
    private PictureBox picQRcode;
}
