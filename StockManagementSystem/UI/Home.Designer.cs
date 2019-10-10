namespace StockManagement_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.reportsButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.stockOutButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.parchaseButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.sideBarPanel);
            this.panel1.Controls.Add(this.reportsButton);
            this.panel1.Controls.Add(this.stockButton);
            this.panel1.Controls.Add(this.stockOutButton);
            this.panel1.Controls.Add(this.saleButton);
            this.panel1.Controls.Add(this.orderButton);
            this.panel1.Controls.Add(this.parchaseButton);
            this.panel1.Controls.Add(this.productButton);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 561);
            this.panel1.TabIndex = 0;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.White;
            this.sideBarPanel.Location = new System.Drawing.Point(2, 150);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(6, 30);
            this.sideBarPanel.TabIndex = 4;
            // 
            // reportsButton
            // 
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.Image = ((System.Drawing.Image)(resources.GetObject("reportsButton.Image")));
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(12, 441);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(153, 35);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "      Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.FlatAppearance.BorderSize = 0;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.ForeColor = System.Drawing.Color.White;
            this.stockButton.Image = ((System.Drawing.Image)(resources.GetObject("stockButton.Image")));
            this.stockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockButton.Location = new System.Drawing.Point(12, 405);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(153, 35);
            this.stockButton.TabIndex = 4;
            this.stockButton.Text = "      Stock";
            this.stockButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // stockOutButton
            // 
            this.stockOutButton.FlatAppearance.BorderSize = 0;
            this.stockOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockOutButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutButton.ForeColor = System.Drawing.Color.White;
            this.stockOutButton.Image = ((System.Drawing.Image)(resources.GetObject("stockOutButton.Image")));
            this.stockOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutButton.Location = new System.Drawing.Point(12, 369);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Size = new System.Drawing.Size(153, 35);
            this.stockOutButton.TabIndex = 4;
            this.stockOutButton.Text = "      Stock Out";
            this.stockOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutButton.UseVisualStyleBackColor = true;
            this.stockOutButton.Click += new System.EventHandler(this.stockOutButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.FlatAppearance.BorderSize = 0;
            this.saleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleButton.ForeColor = System.Drawing.Color.White;
            this.saleButton.Image = ((System.Drawing.Image)(resources.GetObject("saleButton.Image")));
            this.saleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.Location = new System.Drawing.Point(12, 333);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(153, 35);
            this.saleButton.TabIndex = 4;
            this.saleButton.Text = "      Sale";
            this.saleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
            this.orderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.Location = new System.Drawing.Point(12, 297);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(153, 35);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "      Order";
            this.orderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // parchaseButton
            // 
            this.parchaseButton.FlatAppearance.BorderSize = 0;
            this.parchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parchaseButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parchaseButton.ForeColor = System.Drawing.Color.White;
            this.parchaseButton.Image = ((System.Drawing.Image)(resources.GetObject("parchaseButton.Image")));
            this.parchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parchaseButton.Location = new System.Drawing.Point(12, 261);
            this.parchaseButton.Name = "parchaseButton";
            this.parchaseButton.Size = new System.Drawing.Size(153, 35);
            this.parchaseButton.TabIndex = 4;
            this.parchaseButton.Text = "      Purchase";
            this.parchaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parchaseButton.UseVisualStyleBackColor = true;
            this.parchaseButton.Click += new System.EventHandler(this.parchaseButton_Click);
            // 
            // productButton
            // 
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton.ForeColor = System.Drawing.Color.White;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(12, 225);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(153, 35);
            this.productButton.TabIndex = 4;
            this.productButton.Text = "      Product";
            this.productButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Image = ((System.Drawing.Image)(resources.GetObject("categoryButton.Image")));
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(12, 189);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(153, 35);
            this.categoryButton.TabIndex = 4;
            this.categoryButton.Text = "      Category";
            this.categoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(12, 149);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(153, 35);
            this.dashboardButton.TabIndex = 4;
            this.dashboardButton.Text = "      Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(168, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(866, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1008, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(21, 21);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button parchaseButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button stockOutButton;
        private System.Windows.Forms.Panel sideBarPanel;
    }
}

