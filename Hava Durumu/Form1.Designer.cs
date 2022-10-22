
namespace Hava_Durumu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_derece = new System.Windows.Forms.Label();
            this.label_yer = new System.Windows.Forms.Label();
            this.label_durum = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.picture_gunesli = new System.Windows.Forms.PictureBox();
            this.picture_bulutlu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gunesli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_derece
            // 
            this.label_derece.AutoSize = true;
            this.label_derece.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_derece.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_derece.Location = new System.Drawing.Point(115, 140);
            this.label_derece.Name = "label_derece";
            this.label_derece.Size = new System.Drawing.Size(66, 21);
            this.label_derece.TabIndex = 0;
            this.label_derece.Text = "label1";
            // 
            // label_yer
            // 
            this.label_yer.AutoSize = true;
            this.label_yer.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_yer.Location = new System.Drawing.Point(117, 90);
            this.label_yer.Name = "label_yer";
            this.label_yer.Size = new System.Drawing.Size(85, 18);
            this.label_yer.TabIndex = 1;
            this.label_yer.Text = "ANKARA";
            // 
            // label_durum
            // 
            this.label_durum.AutoSize = true;
            this.label_durum.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_durum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_durum.Location = new System.Drawing.Point(116, 193);
            this.label_durum.Name = "label_durum";
            this.label_durum.Size = new System.Drawing.Size(66, 21);
            this.label_durum.TabIndex = 3;
            this.label_durum.Text = "label1";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tarih.Location = new System.Drawing.Point(25, 24);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(61, 25);
            this.tarih.TabIndex = 5;
            this.tarih.Text = "tarih";
            this.tarih.Click += new System.EventHandler(this.label1_Click);
            // 
            // picture_gunesli
            // 
            this.picture_gunesli.Image = ((System.Drawing.Image)(resources.GetObject("picture_gunesli.Image")));
            this.picture_gunesli.Location = new System.Drawing.Point(258, 90);
            this.picture_gunesli.Name = "picture_gunesli";
            this.picture_gunesli.Size = new System.Drawing.Size(187, 175);
            this.picture_gunesli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gunesli.TabIndex = 4;
            this.picture_gunesli.TabStop = false;
            this.picture_gunesli.Visible = false;
            // 
            // picture_bulutlu
            // 
            this.picture_bulutlu.Image = ((System.Drawing.Image)(resources.GetObject("picture_bulutlu.Image")));
            this.picture_bulutlu.Location = new System.Drawing.Point(258, 90);
            this.picture_bulutlu.Name = "picture_bulutlu";
            this.picture_bulutlu.Size = new System.Drawing.Size(181, 171);
            this.picture_bulutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_bulutlu.TabIndex = 2;
            this.picture_bulutlu.TabStop = false;
            this.picture_bulutlu.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_nem.Location = new System.Drawing.Point(116, 244);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(48, 21);
            this.label_nem.TabIndex = 12;
            this.label_nem.Text = "nem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "ŞEHİR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "DERECE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "DURUM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "NEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(573, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label_durum);
            this.Controls.Add(this.picture_bulutlu);
            this.Controls.Add(this.label_yer);
            this.Controls.Add(this.label_derece);
            this.Controls.Add(this.picture_gunesli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_gunesli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_derece;
        private System.Windows.Forms.Label label_yer;
        private System.Windows.Forms.Label label_durum;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.PictureBox picture_gunesli;
        private System.Windows.Forms.PictureBox picture_bulutlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

