using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form3 : Form
    {
        Form4 frm4 = new Form4();
        public string secilenProje;
        public string conString = "Data Source=FETIYEDEMIR1D07;Initial Catalog=dbYazılımSınama;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            tb_Project2.SelectedIndex = 1;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            tb_Project2.SelectedIndex = 3;
        }


        private void btn_AltSurecler_Alt_Click(object sender, EventArgs e)
        {
            
            frm4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            //FORM3 açıldığında anasayfada processleri listelettik !!!
            KayitGetir(secilenProje); // deneme
            //Ekle ve Güncelle Kısmındaki geliştiricinin seçileceği comboboxlara geliştiricileri ekledik..
            SqlConnection baglanti = new SqlConnection(conString);

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select userName FROM tblUsers";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Surec_Gelistirici.Items.Add(dr["userName"]);
                cmb_Gun_Gelistirici.Items.Add(dr["userName"]);
            }

            baglanti.Close();
            //END

            //Güncelleme Kısmındaki Süreç Combobox'a process isimlerini ekledik...
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select * from tblProcess";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;

            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Gun_Surecler.Items.Add(dr2["processName"]);
            }
            baglanti.Close();

            date_Baslama.MinDate = DateTime.Now;
            date_Gun_Bas.MinDate = DateTime.Now;
        }
        public void KayitGetir(string projectID)
        {
            SqlConnection baglanti = new SqlConnection(conString);

            baglanti.Open();
            string kayit = "SELECT processName,startDate,finishDate,description,priority,detail,note FROM tblProcess where projectID='" + projectID + "' and processTypeID=1 ";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_SurecAdi.Text == "" || date_Baslama.Value == null || date_Bitis.Value == null || txt_Priority.Text == "" || cmb_Surec_Gelistirici.Text == "" || txt_Detay.Text == "" || txt_Aciklama.Text == "" || txt_Notlar.Text == "")
            {
                MessageBox.Show("Boş Geçilemez!");
            }
            else
            {
                //Process nesnesine formdan değerleri aldık
                Process prc = new Process();
                prc.name = txt_SurecAdi.Text.ToString();
                prc.startDate = Convert.ToDateTime(date_Baslama.Value);
                prc.finishDate = Convert.ToDateTime(date_Bitis.Value);
                prc.Desc = txt_Aciklama.Text.ToString();
                prc.priority = Convert.ToInt32(txt_Priority.Text);
                prc.Note = txt_Notlar.Text.ToString();
                prc.detail = txt_Detay.Text.ToString();
                string gelistirici = cmb_Surec_Gelistirici.SelectedItem.ToString();
                //END

                //geliştirici username'inden userIDsini çektik!!!
                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string sorgu = "select userID from tblUsers WHERE userName = '" + gelistirici + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                int a = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();
                //END 
                //DB'e process ekleme yaptık...
                baglanti.Open();
                string kayit2 = "insert into tblProcess(processName,startDate,finishDate,detail,priority,note,description,userID) values(@processName,@startDate,@finishDate,@detail,@priority,@note,@desc,@userID)";
                SqlCommand cmd = new SqlCommand(kayit2, baglanti);

                cmd.Parameters.AddWithValue("@processName", prc.name);
                cmd.Parameters.AddWithValue("@startDate", prc.startDate);
                cmd.Parameters.AddWithValue("@finishDate", prc.finishDate);
                cmd.Parameters.AddWithValue("@detail", prc.detail);
                cmd.Parameters.AddWithValue("@priority", prc.priority);
                cmd.Parameters.AddWithValue("@desc", prc.Desc);
                cmd.Parameters.AddWithValue("@note", prc.Note);
                cmd.Parameters.AddWithValue("@userID", a);

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Süreç başarıyla eklendi");
                //END

            }
        }

        private void tab_SurecAnasayfa_Click(object sender, EventArgs e)
        {

        }



        private void btn_Surec_Guncelle_Click(object sender, EventArgs e)
        {
            if (cmb_Gun_Gelistirici.Text == "" || cmb_Gun_Surecler.Text == "" || date_Gun_Bas.Value == null || date_Gun_Bit.Value == null || txt_Gun_Oncelik.Text == "" || txt_Gun_Tamamlanma.Text == "" || txt_Gun_Detaylar.Text == "" || txt_Gun_Notlar.Text == "" || txt_Aciklama.Text == "")
            {
                MessageBox.Show("Boş geçme !");
            }
            else
            {
                if (lblOncelik.Text == "Uygun")
                {
                    //Process nesnesine formdan değerleri alıp atıyoruz...
                    Process prc = new Process();
                    prc.name = cmb_Gun_Surecler.SelectedItem.ToString();
                    prc.Desc = txt_Gun_Aciklama.ToString();
                    prc.startDate = Convert.ToDateTime(date_Gun_Bas.Value);
                    prc.finishDate = Convert.ToDateTime(date_Gun_Bit.Value);
                    prc.priority = Convert.ToInt32(txt_Gun_Oncelik.Text);
                    prc.detail = txt_Gun_Detaylar.Text;
                    prc.Note = txt_Gun_Notlar.Text;
                    prc.complateRate = Convert.ToInt32(txt_Gun_Tamamlanma.Text);
                    string gelistirici = cmb_Gun_Gelistirici.SelectedItem.ToString();
                    //END

                    //geliştirici username'den userID'yi çekiyoruz...
                    SqlConnection baglanti = new SqlConnection(conString);
                    baglanti.Open();
                    string sorgu = "select userID from tblUsers WHERE userName = '" + gelistirici + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    int a = Convert.ToInt32(komut.ExecuteScalar());//UserID'yi çektik
                                                                   //END
                    baglanti.Close();
                    //Güncelleme işlemini yapıyoruz..
                    baglanti.Open();
                    string kayit2 = "update tblProcess set processName=@processName,processTypeID=@processTypeID,completeRate=@completeRate,startDate=@startDate,finishDate=@finishDate,detail=@detail,priority=@priorty,description=@desc,note=@note,userID=@userID where processName='" + prc.name + "' ";
                    SqlCommand cmd = new SqlCommand(kayit2, baglanti);
                    cmd.Parameters.AddWithValue("@processName", prc.name);
                    cmd.Parameters.AddWithValue("@startDate", prc.startDate);
                    cmd.Parameters.AddWithValue("@finishDate", prc.finishDate);
                    cmd.Parameters.AddWithValue("@processTypeID", 1);
                    cmd.Parameters.AddWithValue("@userID", a);
                    // cmd.Parameters.AddWithValue("@duration", prc.duration);
                    cmd.Parameters.AddWithValue("@completeRate", prc.complateRate);
                    cmd.Parameters.AddWithValue("@detail", prc.detail);
                    cmd.Parameters.AddWithValue("@priorty", prc.priority);
                    cmd.Parameters.AddWithValue("@desc", prc.Desc);
                    cmd.Parameters.AddWithValue("@note", prc.Note);

                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Proje başarıyla güncellendi");
                    //END


                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //DATAGRID'den seçili processID'yi aldık.
            string deger = dataGridView1.CurrentRow.Cells["processID"].Value.ToString();
            //END
            //SILME İşlemi
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string sorgu = "DELETE FROM tblProcess WHERE processID = '" + deger + "'";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Veri Başarıyla Silindi");
            //END
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void txt_SurecAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void date_Baslama_ValueChanged(object sender, EventArgs e)
        {
            date_Baslama.MinDate = date_Bitis.Value;
        }

        private void txt_Priority_TextChanged(object sender, EventArgs e)
        {
            if (txt_Priority.Text.Length >= 1 && txt_Priority.Text.Length <= 10)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txt_Priority_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_Detay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_Aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_Notlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void date_Gun_Bas_ValueChanged(object sender, EventArgs e)
        {
            date_Gun_Bas.MinDate = date_Gun_Bit.Value;
        }

        private void txt_Gun_Oncelik_TextChanged(object sender, EventArgs e)
        {
            if (txt_Gun_Oncelik.Text.Length >= 1 && txt_Gun_Oncelik.Text.Length <= 10)
            {
                lblOncelik.Text = "Uygun";
            }
            else
            {
                lblOncelik.Text = "1-10 Arası Giriniz.";
            }
        }

        private void txt_Gun_Oncelik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_Gun_Tamamlanma_TextChanged(object sender, EventArgs e)
        {
            if (txt_Gun_Tamamlanma.Text.Length >= 0 && txt_Gun_Tamamlanma.Text.Length <= 100)
            {

                btn_Surec_Guncelle.Enabled = true;
            }
            else
            {

                btn_Surec_Guncelle.Enabled = false;

            }
        }

        private void txt_Gun_Tamamlanma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_Gun_Detaylar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_Gun_Aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_Gun_Notlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_SurecAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
