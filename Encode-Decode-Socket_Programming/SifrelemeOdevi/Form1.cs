using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using SimpleTcp;

namespace SifrelemeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OpenFileDialog OpenFileDialog;
        SimpleTcpServer Server;
        #region Binary Çevirme
        private string BinaryCevir(string toEncode)
        {
            string cevirilenDeger = "";
            for (int i = 0; i < toEncode.Length; i++)
            {
                cevirilenDeger += Convert.ToString(toEncode[i], 2).PadLeft(8, '0'); //girilen değeri binary'e çeviriyor.
            }
            return cevirilenDeger;
        }
        private string StringCevir(string toEncode)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < toEncode.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(toEncode.Substring(i, 8), 2));  //gelen binary'i ascii tablosuna göre karşılığını buluyor.
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
        #endregion

        #region Sha256 Şifreleme
        private string sha256Sifreleme(string gelentext)
        {
            SHA256 shasifreleme = new SHA256CryptoServiceProvider();
            byte[] bytedizisi = shasifreleme.ComputeHash(Encoding.UTF8.GetBytes(gelentext));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytedizisi)
            {
                builder.Append(item.ToString("x2"));    //sha tipinde sifreleme islemi yapıyor.
            }
            return builder.ToString();
        }
        #endregion

        #region SpnEncode
        public void SpnEncode()
        {
            if (txtGirilenDeger.Text.Length % 2 != 0)
            {
                txtGirilenDeger.Text += " ";
            }
            string BinaryXor = "", sifrelenmisVeri = "", sonuc="" ;
            string binaryVeri = BinaryCevir(txtGirilenDeger.Text);
            string veriUzunlugu = binaryVeri;
            string key_bin = BinaryCevir(txtSecurityKey.Text);

            for (int i = 0; i < veriUzunlugu.Length; i += 16)   //Girilen değerin uzunluğu kadar döngüye giriyor.
            {
                binaryVeri = veriUzunlugu.Substring(i, 16);     //Girilen değer 2'şer harf olacak şekilde ayrılıyor.
                                                        
                for (int j = 0; j < 64; j += 16) //Güvenlik Anahtarı 4 kere dönecek şekilde döngüye giriyor.
                {
                    BinaryXor = xorFonksiyonu(binaryVeri, key_bin.Substring(j, 16));    //Güvenlik anahtarının 2'şer harf olacak şekilde ayrılıyor.

                    if (j < 32)     //1. ve 2. aşamalarda karıştırma işlemi yaptırıyor.
                    {
                        sifrelenmisVeri = SpnMixtoBinary(BinaryXor);
                    }
                    else    // 3. ve 4. aşamalarda (k2,k3) karıştırma işlemi yaptırmıyor.
                    {
                        sifrelenmisVeri = BinaryXor;
                    }

                    binaryVeri = sifrelenmisVeri;   //Çıkan veriyi binary veri olarak atıyor.

                }
                sonuc += binaryVeri;    //Sonuca önceki sonuçları ekleyerek işlem yaptırıyor.
            }

            txtSifrelenmisHali.Text= sonuc; //Sifrelenmis halini textbox'a yazdırıyor.
            MessageBox.Show("Şifreleme işlemi başarıyla gerçekleşmiştir...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion

        #region spnDecode
        private void SpnDecode()
        {
            string geciciDegisken = "";
            string girilenBinary = txtGirilenDeger.Text;
            string girilenBinarySecurityKey;
            string BinaryXor = "", sifrelenmisVeri = "";


            girilenBinarySecurityKey = BinaryCevir(txtSecurityKey.Text);    //Decode etmek istenilen veriyi binary'e çeviriyor.

            for (int i = 0; i < girilenBinary.Length; i += 16)      //Girilen değerin uzunluğu kadar döngüye giriyor.
            {
                geciciDegisken = girilenBinary.Substring(i,16);     //Girilen değer 2'şer harf olacak şekilde ayrılıyor.
                for (int j = 48; j >= 0; j -= 16)   
                {
                    BinaryXor = xorFonksiyonu(geciciDegisken, girilenBinarySecurityKey.Substring(j, 16));
                    //Girilen değerle security key 2'şer harf olacak şekilde ayrılıyor ve xor fonksiyonuna sokuluyor. 
                    if (j == 48 || j== 0)
                    {
                        sifrelenmisVeri = BinaryXor;    //k3 ve k0 değerleri için karıştırma işlemi yapmıyor.
                    }
                    else
                    {
                        sifrelenmisVeri = SpnReturnMixtoBinary(BinaryXor);  //k1 ve k2 değerleri için karıştırma işlemi yapıyor.
                    }

                    geciciDegisken = sifrelenmisVeri;   //Çıkan veriyi binary veri olarak atıyor.

                }

                txtSifrelenmisHali.Text += sifrelenmisVeri; //Sifrelenmis halini textbox'a yazdırıyor.
            }
            txtOrijinalHali.Text=StringCevir(txtSifrelenmisHali.Text);  //Sifrelenmis verinin çözülmüş halini textbox'a yazdırıyor
            txtGetMsg.Text += $"Client :{txtOrijinalHali.Text}{Environment.NewLine}"; // client dan gelen şifrelenmiş verinin orjinal halini mesaj görüntüleyici texte atar
            MessageBox.Show("Şifreleme işlemi başarıyla gerçekleşmiştir...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region SPN Mix
        private string SpnMixtoBinary(string gelenXOR)
        {
            string geciciDegisken = "";
            geciciDegisken += gelenXOR[2];
            geciciDegisken += gelenXOR[8];
            geciciDegisken += gelenXOR[12];
            geciciDegisken += gelenXOR[5];
            geciciDegisken += gelenXOR[9];
            geciciDegisken += gelenXOR[0];
            geciciDegisken += gelenXOR[14];
            geciciDegisken += gelenXOR[4];
            geciciDegisken += gelenXOR[11]; //Spn algoritmasına göre karıştırma işlemi yapıyor.
            geciciDegisken += gelenXOR[1];
            geciciDegisken += gelenXOR[15];
            geciciDegisken += gelenXOR[6];
            geciciDegisken += gelenXOR[3];
            geciciDegisken += gelenXOR[10];
            geciciDegisken += gelenXOR[7];
            geciciDegisken += gelenXOR[13];

            return geciciDegisken;
        }
        #endregion

        #region Spn Return Mix
        private string SpnReturnMixtoBinary(string gelenXOR)
        {
            string geciciDegisken = "";
            geciciDegisken += gelenXOR[5];
            geciciDegisken += gelenXOR[9];
            geciciDegisken += gelenXOR[0];
            geciciDegisken += gelenXOR[12];
            geciciDegisken += gelenXOR[7];
            geciciDegisken += gelenXOR[3];
            geciciDegisken += gelenXOR[11];
            geciciDegisken += gelenXOR[14];
            geciciDegisken += gelenXOR[1];  //Spn algoritmasına göre karıştırma işlemini tersine göre yapıyor.
            geciciDegisken += gelenXOR[4];
            geciciDegisken += gelenXOR[13];
            geciciDegisken += gelenXOR[8];
            geciciDegisken += gelenXOR[2];
            geciciDegisken += gelenXOR[15];
            geciciDegisken += gelenXOR[6];
            geciciDegisken += gelenXOR[10];

            return geciciDegisken;
        }
        #endregion

        #region Xor Islemi
        private string xorFonksiyonu(string gelenBinary,string gelenSecurityKey)
        {
            string xorBinary="";
            for (int i = 0; i < gelenBinary.Length; i++)
            {
                //string ifadenin karakterlerini tek tek alıyor ve xor işlemini yapıyor.
                if (gelenBinary[i]==gelenSecurityKey[i])
                {
                    xorBinary += "0";
                }
                else
                {
                    xorBinary += "1";
                }
            }
            return xorBinary;
        }
        #endregion

        #region Buton Islemleri
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string donenDeger;
             if (rbSha256.Checked == true)
             {
                 txtOrijinalHali.Text = txtGirilenDeger.Text;
                 donenDeger = sha256Sifreleme(txtGirilenDeger.Text);    //sha tipinde sifreleme işlemi yapıyor.
                txtSifrelenmisHali.Text = donenDeger;
                MessageBox.Show("Şifreleme işlemi başarıyla gerçekleşmiştir...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
             {
                 txtOrijinalHali.Text = txtGirilenDeger.Text;
                 SpnEncode();
             }
        }
        private void btnGeriDonustur_Click(object sender, EventArgs e)
        {
            if (rbSha256.Checked == true)
            {
                MessageBox.Show("Sha256 Decode Edilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGirilenDeger.Text = "";
            }
            else
            {
                SpnDecode(); // şifrelenmiş kodu orjinal haline döniştürür
                txtGirilenDeger.Clear();
            }
        }
        private void txtGirilenDeger_Enter(object sender, EventArgs e)
        {
            txtOrijinalHali.Text = "";
            txtSifrelenmisHali.Text = "";
        }
        #endregion
        
        #region Socketprogramming
        private void Form1_Load(object sender, EventArgs e) // form yüklendiğinde server nesnesi ve server alıcıları oluşturuluyor.
        {   
            btnSend.Enabled = false;
            Server = new SimpleTcpServer(txtIpPort.Text);
            Server.Events.ClientConnected += Events_ClientConnected; // servera client connect yapılır
            Server.Events.ClientDisconnected += Events_ClientDisconnected; // serverdan client disconnect yapılır
            Server.Events.DataReceived += Events_DataReceived; // client dan veri alıcı yapılır  
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () // girilen değere client dan alınan şifreli mesaj ataması yapılır
            {
                MessageBox.Show("Client dan mesajınız var", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtGetMsg.Text += $"{e.IpPort} : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                txtGirilenDeger.Text = $"{Encoding.UTF8.GetString(e.Data)}";
            });
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () // gelen mesaj textine clientın disconnect yapıldığı bilgisi yazılır
            {
                txtGetMsg.Text += $"{e.IpPort} Bağlantı kesildi.{Environment.NewLine}";
                lstClietns.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () // gelen mesaj textine clientın connect yapıldığı bilgisi yazılır
            {
                txtGetMsg.Text += $"{e.IpPort} Bağlandı. {Environment.NewLine}";
                lstClietns.Items.Add(e.IpPort);
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Server.Start(); // server başlatılır
            txtGetMsg.Text += $"Başlatılıyor...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Server.IsListening) // server başlatılmışsa
            { 
                if (!string.IsNullOrEmpty(txtSifrelenmisHali.Text) && lstClietns.SelectedItem != null) // şifrelenmiş halinin boş olup olmadığı kontrolü yapılır
                {
                    Server.Send(lstClietns.SelectedItem.ToString(), txtSifrelenmisHali.Text); // soket aracılığı ile veri aktarımı ilgili client portuna yapılır
                    txtGetMsg.Text += $"sunucu: {txtGirilenDeger.Text}{Environment.NewLine}";
                    txtSifrelenmisHali.Clear();
                    txtGirilenDeger.Clear();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Server.IsListening) // server başlatılmışsa
            {
                Server.Stop(); // server kapatılır
                txtGetMsg.Text += $"sunucu durduruldu. {Environment.NewLine}";
                btnStart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sunucu kapatılamaz", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCleaner_Click(object sender, EventArgs e) // ilgili kutucukların silinmesi işlemi yapılır
        {
            lstClietns.Items.Clear();
            txtGirilenDeger.Clear();
            txtSifrelenmisHali.Clear();
            txtOrijinalHali.Clear();
            txtGetMsg.Clear();
        }
        #endregion

       
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            
        }
    }
}
