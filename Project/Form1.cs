using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int userroleID;

        //GİRİŞ////////////////////////////////////////////////////////
        Form2 frm2 = new Form2();
        private void btn_Giris_UyeOl_Click(object sender, EventArgs e)
        {
            GirisKaydol.SelectedIndex = 1;
        }

        private void txt_Giris_Parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);

        }

        private void txt_Giris_Parola_TextChanged(object sender, EventArgs e)
        {
            txt_Giris_Parola.PasswordChar = '*';
            if (txt_Giris_Parola.Text.Length >= 8 && txt_Giris_Parola.Text.Length <= 12)
            {
                btn_GirisYap.Enabled = true;
            }
            else
            {
                btn_GirisYap.Enabled = false;
            }
        }

        private void txt_Giris_kullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }
        public static int userid;
        int id2;
        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            dbYazılımSınamaEntities y = new dbYazılımSınamaEntities();

            if (y.tblUsers.Any(x => x.userName == txt_Giris_kullaniciAdi.Text))
            {
                id2 = y.tblUsers.Where(x => x.userName == txt_Giris_kullaniciAdi.Text).FirstOrDefault().userID;
            }
            frm2.userid = id2;
            Users u = new Users();
            if (txt_Giris_kullaniciAdi.Text == "" || txt_Giris_Parola.Text == "")
            {
                MessageBox.Show("Boş Geçilemez!");
            }
            else
            {
                if (u.GirisYap(txt_Giris_kullaniciAdi.Text, txt_Giris_Parola.Text) == true)
                {
                    frm2.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("hata");
            }
            txt_Giris_kullaniciAdi.Clear();
            txt_Giris_Parola.Clear();
        }
        //GİRİŞ///////////////////////////////////////////////////////

        //KAYDOL/////////////////////////////////////////////////////
        private void bttnOnayla_Click_1(object sender, EventArgs e)
        {

            if (cmb_KullaniciTuru.Text == "Müşteri")
            {
                grp_Musteri.Enabled = true;
                btn_Kaydol.Enabled = true;
                userroleID = 1;


            }
            else if (cmb_KullaniciTuru.Text == "Geliştirici")
            {
                grp_Musteri.Enabled = true;
                btn_Kaydol.Enabled = true;
                userroleID = 2;
            }
            else if (cmb_KullaniciTuru.Text == "Proje Yöneticisi")
            {
                grp_Musteri.Enabled = true;
                btn_Kaydol.Enabled = true;
                userroleID = 3;
            }


        }


        private void txt_Kaydol_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void txt_Kaydol_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txt_Kaydol_Parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void txt_Kaydol_Parola_TextChanged(object sender, EventArgs e)
        {
            txt_Kaydol_Parola.PasswordChar = '*';
            if (txt_Kaydol_Parola.Text.Length >= 8 && txt_Kaydol_Parola.Text.Length <= 12)
            {

                lblSifre.Text = "Kullanılabilir Şifre";
            }
            else
            {

                lblSifre.Text = "Yetersiz Karakter";

            }


        }

        private void txt_Kaydol_Cevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static int id;

        private void btn_Kaydol_Click_1(object sender, EventArgs e)
        {

            if (txt_Kaydol_Ad.Text == "" || txt_Kaydol_kullaniciAdi.Text == "" || txt_Kaydol_Parola.Text == "" || txt_Kaydol_Soyad.Text == "" || txt_Kaydol_Cevap.Text == "")
            {
                MessageBox.Show("Boş geçme !");
            }
            else
            {
                if (lblSifre.Text == "Kullanılabilir Şifre")
                {
                    Users u = new Users();
                    dbYazılımSınamaEntities y = new dbYazılımSınamaEntities();
                    if (userroleID == 1)
                    {
                        if (u.KullaniciEkle(txt_Kaydol_kullaniciAdi.Text, txt_Kaydol_Ad.Text, txt_Kaydol_Soyad.Text, txt_Kaydol_Parola.Text, userroleID, cmb_GuvenlikSorusu.SelectedIndex + 2, txt_Kaydol_Cevap.Text) == true)
                        {
                            MessageBox.Show("Kayıt başarılı.");
                        }
                        else
                        {
                            MessageBox.Show("Veritabanı Hatası.");
                        }
                    }
                    else if (userroleID == 2)
                    {
                        if (u.KullaniciEkle(txt_Kaydol_kullaniciAdi.Text, txt_Kaydol_Ad.Text, txt_Kaydol_Soyad.Text, txt_Kaydol_Parola.Text, userroleID, cmb_GuvenlikSorusu.SelectedIndex + 2, txt_Kaydol_Cevap.Text) == true)
                        {
                            MessageBox.Show("Kayıt başarılı.");

                        }
                        else
                        {
                            MessageBox.Show("Veritabanı Hatası.");

                        }
                    }
                    else if (userroleID == 3)
                    {
                        if (u.KullaniciEkle(txt_Kaydol_kullaniciAdi.Text, txt_Kaydol_Ad.Text, txt_Kaydol_Soyad.Text, txt_Kaydol_Parola.Text, userroleID, cmb_GuvenlikSorusu.SelectedIndex + 2, txt_Kaydol_Cevap.Text) == true)
                        {
                            MessageBox.Show("Kayıt başarılı.");

                        }
                        else
                        {
                            MessageBox.Show("Veritabanı Hatası.");

                        }
                    }
                }
                else
                    MessageBox.Show("Hatalı Şifre");
            }
            txt_Kaydol_Ad.Clear();
            txt_Kaydol_Cevap.Clear();
            txt_Kaydol_kullaniciAdi.Clear();
            txt_Kaydol_Parola.Clear();
            txt_Kaydol_Soyad.Clear();

        }

        private void txt_Kaydol_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            Users u = new Users();
            if (u.KullaniciAdKontrol(txt_Kaydol_kullaniciAdi.Text) == true)
            {
                lblKullaniciAdi.Text = "Kullanıcı Adı Alınmış";
                btn_Kaydol.Enabled = false;

            }
            else
            {
                btn_Kaydol.Enabled = true;
                lblKullaniciAdi.Text = "Kullanıcı Adı Uygun";

            }
        }

        private void txt_Kaydol_kullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }


        //KAYDOL////////////////////////////////////////////////////

        //ŞİFRE DEĞİŞTİR///////////////////////////////////////////

        private void txt_SifreDegistir_Cevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_YeniSifre_TextChanged(object sender, EventArgs e)
        {
            txt_YeniSifre.PasswordChar = '*';
            if (txt_YeniSifre.Text.Length >= 8 && txt_YeniSifre.Text.Length <= 12)
            {
                lblDegistirSifre.Text = "Kullanılabilir Şifre";
            }
            else
            {
                lblDegistirSifre.Text = "Yetersiz Karakter";
            }
        }

        private void txt_YeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txt_YeniSifreTekrar.PasswordChar = '*';
            if (txt_YeniSifreTekrar.Text.Length >= 8 && txt_YeniSifreTekrar.Text.Length <= 12)
            {
                lblDegistirSifre.Text = "Kullanılabilir Şifre";
            }
            else
            {
                lblDegistirSifre.Text = "Yetersiz Karakter";
            }
        }

        private void txt_YeniSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void txt_YeniSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }


        private void txt_SifreDegistir_kullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            if (txt_SifreDegistir_Cevap.Text == "" || txt_SifreDegistir_kullaniciAdi.Text == "" || txt_YeniSifre.Text == "" || txt_YeniSifreTekrar.Text == "" || cmb_GuvenlikSorusu.Text == "")
            {
                MessageBox.Show("Boş geçme !");
            }
            else
            {
                Users u = new Users();
                dbYazılımSınamaEntities y = new dbYazılımSınamaEntities();
                if (txt_YeniSifre.Text == txt_YeniSifreTekrar.Text)
                {
                    MessageBox.Show(u.SifreDegistir(txt_SifreDegistir_kullaniciAdi.Text, cmb_GuvenlikSorusu.SelectedIndex + 1, txt_SifreDegistir_Cevap.Text, txt_YeniSifre.Text));

                }
                else
                    MessageBox.Show("Şifreler Uyuşmuyor!");
                txt_SifreDegistir_Cevap.Clear();
                txt_SifreDegistir_kullaniciAdi.Clear();
                txt_YeniSifre.Clear();
                txt_YeniSifreTekrar.Clear();
            }
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            GirisKaydol.SelectedIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tab_GirisYap_Click(object sender, EventArgs e)
        {

        }




        //ŞİFRE DEĞİŞTİR//////////////////////////////////////////

    }
}
