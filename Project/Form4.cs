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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=FETIYEDEMIR1D07;Initial Catalog=dbYazılımSınama;Integrated Security=True";

        private void Form4_Load(object sender, EventArgs e)
        {
            KayitlariGetir();

            SqlConnection baglanti = new SqlConnection(conString);

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from tblProcess";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_AltSurec_Gun_Surecler.Items.Add(dr["processName"]);
            }

            baglanti.Close();

            date_AltSurec_Baslama.MinDate = DateTime.Now;
            date_AltS_Gun_Bas.MinDate = DateTime.Now;
        }

        public void KayitlariGetir()
        {
            SqlConnection baglanti = new SqlConnection(conString);

            baglanti.Open();
            string sorgu = "SELECT * FROM tblProcess where processTypeID=2";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btn_AltSurec_Ekle_Click(object sender, EventArgs e)
        {
            tab_AltSurecler.SelectedIndex = 1;
        }

        private void btn_SurecAltSurec_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_AltSurec_SurecAdi.Text == "" || date_AltSurec_Baslama.Value == null || date_AltSurec_Bitis.Value == null || txt_AltSurec_Priority.Text == "" || txt_AltSurec_Detay.Text == "" || txt_AltSurec_Aciklama.Text == "" || txt_AltSurec_Notlar.Text == "")
            {
                MessageBox.Show("Boş geçme !");
            }
            else
            {
                Process pro = new Process();
                pro.name = txt_AltSurec_SurecAdi.Text;
                pro.startDate = Convert.ToDateTime(date_AltSurec_Baslama.Value);
                pro.finishDate = Convert.ToDateTime(date_AltSurec_Bitis.Value);
                pro.detail = txt_AltSurec_Detay.Text;
                pro.Note = txt_AltSurec_Notlar.Text;
                pro.Desc = txt_AltSurec_Aciklama.Text;

                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string sorgu = "insert into tblProcess(processName,startDate,finishDate,detail,note,description) values(@processName,@startDate,@finishDate,@detail,@note,@Desc)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@processName", pro.name);
                komut.Parameters.AddWithValue("@startDate", pro.startDate);
                komut.Parameters.AddWithValue("@finishDate", pro.finishDate);
                komut.Parameters.AddWithValue("@detail", pro.detail);
                komut.Parameters.AddWithValue("@note", pro.Note);
                komut.Parameters.AddWithValue("@Desc", pro.Desc);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla eklendi");
            }
        }

        private void btn_AltSurec_Guncelle_Click(object sender, EventArgs e)
        {
            tab_AltSurecler.SelectedIndex = 2;
        }

        private void btn_SurecAltS_Guncelle_Click(object sender, EventArgs e)
        {

            if (cmb_AltSurec_Gun_Surecler.Text == "" || date_AltS_Gun_Bas.Value == null || date_AltS_Gun_Bit.Value == null || txt_AltS_Gun_Oncelik.Text == "" || txt_AltS_Gun_Tamamlanma.Text == "" || txt_AltSurec_Aciklama.Text == "" || txt_AltSurec_Detay.Text == "" || txt_AltSurec_Notlar.Text == "")
            {
                MessageBox.Show("Boş geçme !");
            }
            else
            {
                if (lblAltSOncelik.Text == "Uygun")
                {
                    Process pro = new Process();
                    pro.name = txt_AltSurec_SurecAdi.Text;
                    pro.startDate = Convert.ToDateTime(date_AltSurec_Baslama.Value);
                    pro.finishDate = Convert.ToDateTime(date_AltSurec_Bitis.Value);
                    pro.detail = txt_AltSurec_Detay.Text;
                    pro.Note = txt_AltSurec_Notlar.Text;
                    pro.Desc = txt_AltSurec_Aciklama.Text;

                    string processName = cmb_AltSurec_Gun_Surecler.SelectedItem.ToString();


                    SqlConnection baglanti = new SqlConnection(conString);

                    baglanti.Open();

                    string sorgu2 = "update tblProcess set processName=@processName,startDate=@startDate,finishDate=@finishDate,detail=@detail,note=@note,description=@desc WHERE processName='" + processName + "'";
                    SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);

                    komut2.Parameters.AddWithValue("@processName", processName);
                    komut2.Parameters.AddWithValue("@startDate", pro.startDate);
                    komut2.Parameters.AddWithValue("@finishDate", pro.finishDate);
                    komut2.Parameters.AddWithValue("@detail", pro.detail);
                    komut2.Parameters.AddWithValue("@note", pro.Note);
                    komut2.Parameters.AddWithValue("@desc", pro.Desc);

                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt başarıyla güncellendi");

                }
            }
        }
        private void btn_AltSurec_Sil_Click(object sender, EventArgs e)
        {
            string deger = dataGridView1.CurrentRow.Cells["processID"].Value.ToString();
            MessageBox.Show(deger);


            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string sorgu = "DELETE FROM tblProcess WHERE processID = '" + deger + "'";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Veri Başarıyla Silindi");
        }

        private void btnGeriDon2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void btn_GeriDon2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void txt_AltSurec_SurecAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void date_AltSurec_Baslama_ValueChanged(object sender, EventArgs e)
        {
            date_AltSurec_Bitis.MinDate = date_AltSurec_Baslama.Value;
        }

        private void txt_AltSurec_Priority_TextChanged(object sender, EventArgs e)
        {
            if (txt_AltSurec_Priority.Text.Length >= 1 && txt_AltSurec_Priority.Text.Length <= 10)
            {
                btn_SurecAltSurec_Ekle.Enabled = true;
            }
            else
            {
                btn_SurecAltSurec_Ekle.Enabled = false;
            }
        }

        private void txt_AltSurec_Priority_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_AltSurec_Detay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_AltSurec_Aciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_AltSurec_Aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_AltSurec_Notlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void date_AltS_Gun_Bas_ValueChanged(object sender, EventArgs e)
        {
            date_AltS_Gun_Bit.MinDate = date_AltS_Gun_Bas.Value;
        }

        private void txt_AltS_Gun_Oncelik_TextChanged(object sender, EventArgs e)
        {
            if (txt_AltS_Gun_Oncelik.Text.Length >= 1 && txt_AltS_Gun_Oncelik.Text.Length <= 10)
            {
                lblAltSOncelik.Text = "Uygun";
            }
            else
            {
                lblAltSOncelik.Text = "1-10 Arası Giriniz.";
            }
        }

        private void txt_AltS_Gun_Oncelik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_AltS_Gun_Tamamlanma_TextChanged(object sender, EventArgs e)
        {
            if (txt_AltS_Gun_Tamamlanma.Text.Length >= 0 && txt_AltS_Gun_Tamamlanma.Text.Length <= 100)
            {

                btn_SurecAltS_Guncelle.Enabled = true;
            }
            else
            {

                btn_SurecAltS_Guncelle.Enabled = false;

            }
        }

        private void txt_AltS_Gun_Tamamlanma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_AltS_Gun_Detaylar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_AltS_Gun_Aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void txt_AltS_Gun_Notlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }
    }
}
