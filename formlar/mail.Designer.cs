
namespace okanalpturk_IK
{
    partial class mail
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_gelen = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_gidenn = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage_mesajyaz = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_gelen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_gidenn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_gelen);
            this.tabControl1.Controls.Add(this.tabPage_gidenn);
            this.tabControl1.Controls.Add(this.tabPage_mesajyaz);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_gelen
            // 
            this.tabPage_gelen.Controls.Add(this.dataGridView1);
            this.tabPage_gelen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_gelen.Name = "tabPage_gelen";
            this.tabPage_gelen.Size = new System.Drawing.Size(839, 605);
            this.tabPage_gelen.TabIndex = 0;
            this.tabPage_gelen.Text = "Gelen Mesajlar";
            this.tabPage_gelen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 605);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage_gidenn
            // 
            this.tabPage_gidenn.Controls.Add(this.dataGridView2);
            this.tabPage_gidenn.Location = new System.Drawing.Point(4, 22);
            this.tabPage_gidenn.Name = "tabPage_gidenn";
            this.tabPage_gidenn.Size = new System.Drawing.Size(839, 605);
            this.tabPage_gidenn.TabIndex = 1;
            this.tabPage_gidenn.Text = "Gönderilen Mesajlar";
            this.tabPage_gidenn.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(839, 605);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage_mesajyaz
            // 
            this.tabPage_mesajyaz.Location = new System.Drawing.Point(4, 22);
            this.tabPage_mesajyaz.Name = "tabPage_mesajyaz";
            this.tabPage_mesajyaz.Size = new System.Drawing.Size(839, 605);
            this.tabPage_mesajyaz.TabIndex = 2;
            this.tabPage_mesajyaz.Text = "Yeni Bir İleti Oluştur";
            this.tabPage_mesajyaz.UseVisualStyleBackColor = true;
            this.tabPage_mesajyaz.Click += new System.EventHandler(this.tabPage_mesajyaz_Click);
            // 
            // mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 631);
            this.Controls.Add(this.tabControl1);
            this.Name = "mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mail";
            this.Load += new System.EventHandler(this.mail_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_gelen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_gidenn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_gelen;
        private System.Windows.Forms.TabPage tabPage_gidenn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage_mesajyaz;
    }
}