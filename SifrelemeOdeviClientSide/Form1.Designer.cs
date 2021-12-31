
namespace SifrelemeOdeviClientSide
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
            this.btnCleaner = new System.Windows.Forms.Button();
            this.txtGetMsg = new System.Windows.Forms.TextBox();
            this.txtIpPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeriDonustur = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifrelenmisHali = new System.Windows.Forms.TextBox();
            this.txtOrijinalHali = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGirilenDeger = new System.Windows.Forms.TextBox();
            this.rbSpn = new System.Windows.Forms.RadioButton();
            this.rbSha256 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCleaner
            // 
            this.btnCleaner.BackColor = System.Drawing.Color.Lime;
            this.btnCleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaner.Location = new System.Drawing.Point(855, 52);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(178, 43);
            this.btnCleaner.TabIndex = 43;
            this.btnCleaner.Text = "Temizle";
            this.btnCleaner.UseVisualStyleBackColor = false;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // txtGetMsg
            // 
            this.txtGetMsg.Location = new System.Drawing.Point(12, 368);
            this.txtGetMsg.Multiline = true;
            this.txtGetMsg.Name = "txtGetMsg";
            this.txtGetMsg.Size = new System.Drawing.Size(721, 230);
            this.txtGetMsg.TabIndex = 42;
            // 
            // txtIpPort
            // 
            this.txtIpPort.Location = new System.Drawing.Point(811, 114);
            this.txtIpPort.Name = "txtIpPort";
            this.txtIpPort.Size = new System.Drawing.Size(280, 22);
            this.txtIpPort.TabIndex = 39;
            this.txtIpPort.Text = "127.0.0.1:8888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(731, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ip Port:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Location = new System.Drawing.Point(785, 368);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(284, 227);
            this.btnSend.TabIndex = 37;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Location = new System.Drawing.Point(729, 154);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(178, 43);
            this.btnConnect.TabIndex = 36;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Location = new System.Drawing.Point(350, 159);
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.Size = new System.Drawing.Size(142, 22);
            this.txtSecurityKey.TabIndex = 34;
            this.txtSecurityKey.Text = "security";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(160, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Security Key :";
            // 
            // btnGeriDonustur
            // 
            this.btnGeriDonustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeriDonustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDonustur.Location = new System.Drawing.Point(386, 290);
            this.btnGeriDonustur.Name = "btnGeriDonustur";
            this.btnGeriDonustur.Size = new System.Drawing.Size(256, 58);
            this.btnGeriDonustur.TabIndex = 32;
            this.btnGeriDonustur.Text = "Şifreyi Geri Dönüştür";
            this.btnGeriDonustur.UseVisualStyleBackColor = false;
            this.btnGeriDonustur.Click += new System.EventHandler(this.btnGeriDonustur_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.Location = new System.Drawing.Point(12, 290);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(256, 58);
            this.btnSifrele.TabIndex = 31;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(383, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Şifrelenmiş Hali :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Şifrenin Çözülmüş/Orijinal Hali :";
            // 
            // txtSifrelenmisHali
            // 
            this.txtSifrelenmisHali.Location = new System.Drawing.Point(386, 242);
            this.txtSifrelenmisHali.Multiline = true;
            this.txtSifrelenmisHali.Name = "txtSifrelenmisHali";
            this.txtSifrelenmisHali.Size = new System.Drawing.Size(347, 42);
            this.txtSifrelenmisHali.TabIndex = 28;
            // 
            // txtOrijinalHali
            // 
            this.txtOrijinalHali.Location = new System.Drawing.Point(12, 242);
            this.txtOrijinalHali.Multiline = true;
            this.txtOrijinalHali.Name = "txtOrijinalHali";
            this.txtOrijinalHali.Size = new System.Drawing.Size(347, 42);
            this.txtOrijinalHali.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Girmek İstediğiniz Şifre :";
            // 
            // txtGirilenDeger
            // 
            this.txtGirilenDeger.Location = new System.Drawing.Point(350, 110);
            this.txtGirilenDeger.Name = "txtGirilenDeger";
            this.txtGirilenDeger.Size = new System.Drawing.Size(280, 22);
            this.txtGirilenDeger.TabIndex = 25;
            this.txtGirilenDeger.Enter += new System.EventHandler(this.txtGirilenDeger_Enter);
            // 
            // rbSpn
            // 
            this.rbSpn.AutoSize = true;
            this.rbSpn.Checked = true;
            this.rbSpn.Location = new System.Drawing.Point(469, 72);
            this.rbSpn.Name = "rbSpn";
            this.rbSpn.Size = new System.Drawing.Size(57, 21);
            this.rbSpn.TabIndex = 24;
            this.rbSpn.TabStop = true;
            this.rbSpn.Text = "SPN";
            this.rbSpn.UseVisualStyleBackColor = true;
            // 
            // rbSha256
            // 
            this.rbSha256.AutoSize = true;
            this.rbSha256.Location = new System.Drawing.Point(347, 72);
            this.rbSha256.Name = "rbSha256";
            this.rbSha256.Size = new System.Drawing.Size(86, 21);
            this.rbSha256.TabIndex = 23;
            this.rbSha256.Text = "SHA-256";
            this.rbSha256.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Şifreleme Tipi :";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnect.Location = new System.Drawing.Point(913, 154);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(178, 43);
            this.btnDisconnect.TabIndex = 44;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(251, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Mesaj ayarları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(868, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Sunucu Ayarları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1100, 607);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnCleaner);
            this.Controls.Add(this.txtGetMsg);
            this.Controls.Add(this.txtIpPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSecurityKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGeriDonustur);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifrelenmisHali);
            this.Controls.Add(this.txtOrijinalHali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGirilenDeger);
            this.Controls.Add(this.rbSpn);
            this.Controls.Add(this.rbSha256);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCleaner;
        private System.Windows.Forms.TextBox txtGetMsg;
        private System.Windows.Forms.TextBox txtIpPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSecurityKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeriDonustur;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifrelenmisHali;
        private System.Windows.Forms.TextBox txtOrijinalHali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGirilenDeger;
        private System.Windows.Forms.RadioButton rbSpn;
        private System.Windows.Forms.RadioButton rbSha256;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

