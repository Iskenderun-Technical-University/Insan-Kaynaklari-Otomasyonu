
namespace okanalpturk_IK
{
    partial class GirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.radio_user = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okanalpturkDataSet = new okanalpturk_IK.okanalpturkDataSet();
            this.okanalpturkDataSet1 = new okanalpturk_IK.okanalpturkDataSet();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okanalpturkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okanalpturkDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "IK Otomasyon Sistemine Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(70, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lütfen kullanıcı adı ve şifrenizi girdikten sonra\r\ngiriş yapmak istediğiniz pozis" +
    "yonu seçiniz.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 148);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(70, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(70, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre";
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.BackColor = System.Drawing.Color.Transparent;
            this.radio_admin.ForeColor = System.Drawing.Color.Khaki;
            this.radio_admin.Location = new System.Drawing.Point(272, 151);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(54, 17);
            this.radio_admin.TabIndex = 10;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Admin";
            this.radio_admin.UseVisualStyleBackColor = false;
            // 
            // radio_user
            // 
            this.radio_user.AutoSize = true;
            this.radio_user.BackColor = System.Drawing.Color.Transparent;
            this.radio_user.ForeColor = System.Drawing.Color.Khaki;
            this.radio_user.Location = new System.Drawing.Point(272, 179);
            this.radio_user.Name = "radio_user";
            this.radio_user.Size = new System.Drawing.Size(47, 17);
            this.radio_user.TabIndex = 11;
            this.radio_user.TabStop = true;
            this.radio_user.Text = "User";
            this.radio_user.UseVisualStyleBackColor = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.okanalpturkDataSet;
            this.bindingSource1.Position = 0;
            // 
            // okanalpturkDataSet
            // 
            this.okanalpturkDataSet.DataSetName = "okanalpturkDataSet";
            this.okanalpturkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // okanalpturkDataSet1
            // 
            this.okanalpturkDataSet1.DataSetName = "okanalpturkDataSet";
            this.okanalpturkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::okanalpturk_IK.Properties.Resources.dlf_pt_login_button_image_png_2028830;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(199, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 28);
            this.button3.TabIndex = 14;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::okanalpturk_IK.Properties.Resources.arkaplan5t;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 282);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radio_user);
            this.Controls.Add(this.radio_admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okanalpturkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okanalpturkDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.RadioButton radio_user;
        private System.Windows.Forms.BindingSource bindingSource1;
        private okanalpturkDataSet okanalpturkDataSet;
        private okanalpturkDataSet okanalpturkDataSet1;
        private System.Windows.Forms.Button button3;
    }
}

