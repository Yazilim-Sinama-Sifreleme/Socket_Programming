
namespace SifrelemeOdevi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbSha256 = new System.Windows.Forms.RadioButton();
            this.rbSpn = new System.Windows.Forms.RadioButton();
            this.txtGirilenDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrijinalHali = new System.Windows.Forms.TextBox();
            this.txtSifrelenmisHali = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnGeriDonustur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIpPort = new System.Windows.Forms.TextBox();
            this.lstClietns = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGetMsg = new System.Windows.Forms.TextBox();
            this.btnCleaner = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(153, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifreleme Tipi :";
            // 
            // rbSha256
            // 
            this.rbSha256.AutoSize = true;
            this.rbSha256.Location = new System.Drawing.Point(323, 58);
            this.rbSha256.Name = "rbSha256";
            this.rbSha256.Size = new System.Drawing.Size(86, 21);
            this.rbSha256.TabIndex = 1;
            this.rbSha256.Text = "SHA-256";
            this.rbSha256.UseVisualStyleBackColor = true;
            // 
            // rbSpn
            // 
            this.rbSpn.AutoSize = true;
            this.rbSpn.Checked = true;
            this.rbSpn.Location = new System.Drawing.Point(445, 58);
            this.rbSpn.Name = "rbSpn";
            this.rbSpn.Size = new System.Drawing.Size(57, 21);
            this.rbSpn.TabIndex = 2;
            this.rbSpn.TabStop = true;
            this.rbSpn.Text = "SPN";
            this.rbSpn.UseVisualStyleBackColor = true;
            // 
            // txtGirilenDeger
            // 
            this.txtGirilenDeger.Location = new System.Drawing.Point(350, 97);
            this.txtGirilenDeger.Name = "txtGirilenDeger";
            this.txtGirilenDeger.Size = new System.Drawing.Size(280, 22);
            this.txtGirilenDeger.TabIndex = 3;
            this.txtGirilenDeger.Enter += new System.EventHandler(this.txtGirilenDeger_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Girmek İstediğiniz Şifre :";
            // 
            // txtOrijinalHali
            // 
            this.txtOrijinalHali.Location = new System.Drawing.Point(12, 229);
            this.txtOrijinalHali.Multiline = true;
            this.txtOrijinalHali.Name = "txtOrijinalHali";
            this.txtOrijinalHali.Size = new System.Drawing.Size(347, 42);
            this.txtOrijinalHali.TabIndex = 5;
            // 
            // txtSifrelenmisHali
            // 
            this.txtSifrelenmisHali.Location = new System.Drawing.Point(386, 229);
            this.txtSifrelenmisHali.Multiline = true;
            this.txtSifrelenmisHali.Name = "txtSifrelenmisHali";
            this.txtSifrelenmisHali.Size = new System.Drawing.Size(347, 42);
            this.txtSifrelenmisHali.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifrenin Çözülmüş/Orijinal Hali :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(383, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifrelenmiş Hali :";
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.Location = new System.Drawing.Point(12, 277);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(256, 58);
            this.btnSifrele.TabIndex = 9;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnGeriDonustur
            // 
            this.btnGeriDonustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeriDonustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDonustur.Location = new System.Drawing.Point(386, 277);
            this.btnGeriDonustur.Name = "btnGeriDonustur";
            this.btnGeriDonustur.Size = new System.Drawing.Size(256, 58);
            this.btnGeriDonustur.TabIndex = 10;
            this.btnGeriDonustur.Text = "Şifreyi Geri Dönüştür";
            this.btnGeriDonustur.UseVisualStyleBackColor = false;
            this.btnGeriDonustur.Click += new System.EventHandler(this.btnGeriDonustur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(160, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Security Key :";
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Location = new System.Drawing.Point(350, 146);
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.Size = new System.Drawing.Size(142, 22);
            this.txtSecurityKey.TabIndex = 12;
            this.txtSecurityKey.Text = "security";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(1041, 146);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(178, 43);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(808, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 43);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Location = new System.Drawing.Point(388, 591);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(256, 43);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(800, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ip Port:";
            // 
            // txtIpPort
            // 
            this.txtIpPort.Location = new System.Drawing.Point(880, 97);
            this.txtIpPort.Name = "txtIpPort";
            this.txtIpPort.Size = new System.Drawing.Size(280, 22);
            this.txtIpPort.TabIndex = 17;
            this.txtIpPort.Text = "127.0.0.1:8888";
            // 
            // lstClietns
            // 
            this.lstClietns.FormattingEnabled = true;
            this.lstClietns.ItemHeight = 16;
            this.lstClietns.Location = new System.Drawing.Point(766, 229);
            this.lstClietns.Name = "lstClietns";
            this.lstClietns.Size = new System.Drawing.Size(471, 356);
            this.lstClietns.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(761, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sunucu Ip";
            // 
            // txtGetMsg
            // 
            this.txtGetMsg.Location = new System.Drawing.Point(12, 355);
            this.txtGetMsg.Multiline = true;
            this.txtGetMsg.Name = "txtGetMsg";
            this.txtGetMsg.Size = new System.Drawing.Size(721, 230);
            this.txtGetMsg.TabIndex = 20;
            // 
            // btnCleaner
            // 
            this.btnCleaner.BackColor = System.Drawing.Color.Lime;
            this.btnCleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaner.Location = new System.Drawing.Point(949, 43);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(178, 43);
            this.btnCleaner.TabIndex = 21;
            this.btnCleaner.Text = "Temizle";
            this.btnCleaner.UseVisualStyleBackColor = false;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(247, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mesaj Ayarları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(961, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sunucu Ayarları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1246, 642);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCleaner);
            this.Controls.Add(this.txtGetMsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstClietns);
            this.Controls.Add(this.txtIpPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
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
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSha256;
        private System.Windows.Forms.RadioButton rbSpn;
        private System.Windows.Forms.TextBox txtGirilenDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrijinalHali;
        private System.Windows.Forms.TextBox txtSifrelenmisHali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnGeriDonustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSecurityKey;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIpPort;
        private System.Windows.Forms.ListBox lstClietns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGetMsg;
        private System.Windows.Forms.Button btnCleaner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

