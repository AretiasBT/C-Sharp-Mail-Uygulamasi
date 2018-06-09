using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace CSharpMailGönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SmtpClient smtp = new SmtpClient(); // smtp nesnesi oluşturuyoruz
        string[] ekler; // E-posta eklerini tutacağımız dizimiz
        private void Form1_Load(object sender, EventArgs e)
        { 
            /*
             * Gmail ile kullanamadım, güvenlik nedeniyle izin vermiyor.
             * Bu sebeple outlook smtp ayarlarını girdim ve outlook mail adresi kullandım.
             */
            
            smtp.Credentials = new System.Net.NetworkCredential("isim@outlook.com","parola"); // mail adresimizin kullanıcı adı ve parolası
            smtp.Host = "smtp-mail.outlook.com"; // Mail sunucusu
            smtp.Port = 587; // Outlook için 587
            smtp.EnableSsl = true; // Sunucu SSL kullanıyorsa True olacak
        }

        private void btnEkler_Click(object sender, EventArgs e)
        {
            richTxtEkle.Clear(); // richTextBox içeriğini boşaltıyoruz
            OpenFileDialog ek = new OpenFileDialog(); // ek adında Open File Dialog nesnesi oluşturuyoruz
            ek.Multiselect = true; // ek nesnesinin multiselect özelliğini aktif ediyoruz ki birden fazla dosya seçebilelim 
            ek.ShowDialog(); // Dosya diyalog penceresini açyoruz
            ekler = ek.FileNames; // Dosya yolunu adlarıyla birlikte ekler dizisine aktarıyoruz
            foreach(string ekle in ek.SafeFileNames) // Sadece dosya adlarını richtextbox'ta gösteriyoruz
            {
                richTxtEkle.Text = richTxtEkle.Text + ekle + "\n";
            }
            
        }

        private void btnGonder_Click(object sender, EventArgs e) // Gönder Butonuna Bastığımızda
        {
            if(txtAlici.Text == "") // Eğer alıcı yoksa
            {
                MessageBox.Show("Lütfen bir alıcı ekleyin"); // Alıcı eklemelerini iste
            }
            else
            {
                MailMessage eposta = new MailMessage(); // eposta adında bir mail nesnesi oluştur
                eposta.From = new MailAddress("isim@outlook.com","KodDefteri.Net"); // Giden mailde görünecek e-posta adresi ve isim email adresi smtp ile aynı olmayınca hata veriyor.
                eposta.To.Add(txtAlici.Text); // Mail gönderilecek kişi(ler). Eğer birden fazla kişiye gidecekse, kişiler arasına virgül koy
                if(txtBilgi.Text != "") //eğer bilgi maili gidecek kişi varsa
                    eposta.CC.Add(txtBilgi.Text); // CC özelliğine ekle
                if (txtGizli.Text != "") // Eğer gizli alıcı varsa
                    eposta.Bcc.Add(txtGizli.Text); // bcc özelliğine ekle
                if(txtKonu.Text != "") // eğer konu varsa
                    eposta.Subject = txtKonu.Text; // konu özelliğine ekle
                eposta.Body = txtIcerik.Text; // mesaj içeriğini body özelliğine ekle
                if(richTxtEkle.Text != "") // eğer ek eklenmişse
                {
                    foreach(string ekle in ekler)
                    {
                        eposta.Attachments.Add(new Attachment(@ekle)); // ekleri Attachments özelliğine ekle
                    }
                    
                }
                    
                
                try
                {
                    smtp.Send(eposta); // emaili gönder
                }
                catch(Exception ex) // Gönderimde hata oluşursa
                {
                    MessageBox.Show("Mail gönderilirkene bir hata ile karşılaşıldı: \n" + ex.Message); // Hatayı kullanıcıya bildir
                }
            }
        }
    }
}

/*
 * Kodları yazarken çok başım ağrıdı la
 */
