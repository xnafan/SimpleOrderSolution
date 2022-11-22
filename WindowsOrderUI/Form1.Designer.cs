namespace WindowsOrderUI;

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSetOrderPickedUp = new System.Windows.Forms.Button();
            this.btnSetOrderReady = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSetOrderPickedUp);
            this.splitContainer1.Panel1.Controls.Add(this.btnSetOrderReady);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstOrders);
            this.splitContainer1.Size = new System.Drawing.Size(1716, 1035);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSetOrderPickedUp
            // 
            this.btnSetOrderPickedUp.Location = new System.Drawing.Point(48, 384);
            this.btnSetOrderPickedUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetOrderPickedUp.Name = "btnSetOrderPickedUp";
            this.btnSetOrderPickedUp.Size = new System.Drawing.Size(387, 111);
            this.btnSetOrderPickedUp.TabIndex = 0;
            this.btnSetOrderPickedUp.Text = "Set order to \"&Picked up\"";
            this.btnSetOrderPickedUp.UseVisualStyleBackColor = true;
            this.btnSetOrderPickedUp.Click += new System.EventHandler(this.btnSetOrderPickedUp_Click);
            // 
            // btnSetOrderReady
            // 
            this.btnSetOrderReady.Location = new System.Drawing.Point(48, 263);
            this.btnSetOrderReady.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetOrderReady.Name = "btnSetOrderReady";
            this.btnSetOrderReady.Size = new System.Drawing.Size(387, 111);
            this.btnSetOrderReady.TabIndex = 0;
            this.btnSetOrderReady.Text = "&Set order to \"Ready\"";
            this.btnSetOrderReady.UseVisualStyleBackColor = true;
            this.btnSetOrderReady.Click += new System.EventHandler(this.btnSetOrderReady_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(48, 33);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(387, 111);
            this.btnCreateOrder.TabIndex = 0;
            this.btnCreateOrder.Text = "&Create order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 38;
            this.lstOrders.Location = new System.Drawing.Point(0, 0);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(1249, 1035);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.LstOrders_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 1035);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Order UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private SplitContainer splitContainer1;
    private Button btnSetOrderPickedUp;
    private Button btnSetOrderReady;
    private Button btnCreateOrder;
    private ListBox lstOrders;
}
