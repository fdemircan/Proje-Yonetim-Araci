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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 frm3 = new Form3();
        public int userid;
        public string conString = "Data Source=FETIYEDEMIR1D07;Initial Catalog=dbYazılımSınama;Integrated Security=True";

        private void Form2_Load(object sender, EventArgs e)
        {
            if(userid==2 || userid==3)
            {
                grp_ekle.Enabled = false;
                grp_guncelle.Enabled = false;
            }
            //Anasayfada kayıtları listeletiyoruz..
            KayitGetir();

            SqlConnection baglanti = new SqlConnection(conString);

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from tblUsers WHERE userRoleID=2";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            //Comboboxlara DB'den veri alıyoruz...
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_projeYoneticisi.Items.Add(dr["userName"]);
                cmb_Gun_PtojeYoneticisi.Items.Add(dr["userName"]);
            }

            baglanti.Close();

            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select * from tblProject";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;

            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Gun_ProjeAdi.Items.Add(dr2["projectName"]);
            }
            baglanti.Close();

            //GÖREVLERİM
            Gorevlerim();

            date_Gun_Baslangic.MinDate = DateTime.Now;
            date_Baslangic.MinDate = DateTime.Now;


        }
        public void Gorevlerim()
        {
            SqlConnection baglanti = new SqlConnection(conString);

            baglanti.Open();
            string kayit = "SELECT P.projectID,P.projectName AS 'Projenin Adı' ,P.startDate AS 'Baş Tarihi',P.finishDate AS 'Bit Tarihi',P.budget AS 'Bütçe',P.isActive AS 'Aktiflik',U.userName AS 'Oluşturan' from tblProject P INNER JOIN tblUsers U ON P.createID=U.userID where P.projectManagerID='"+userid+"'";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView2.DataSource = dt;
        }
        public void KayitGetir()
        {
            SqlConnection baglanti = new SqlConnection(conString);

            baglanti.Open();
            string kayit = "SELECT P.projectID,P.projectName AS 'Projenin Adı' ,P.startDate AS 'Baş Tarihi',P.finishDate AS 'Bit Tarihi',P.budget AS 'Bütçe',P.isActive AS 'Aktiflik',U.userName AS 'Oluşturan' from tblProject P INNER JOIN tblUsers U ON P.createID=U.userID";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
           
        }
        public int projectID;
        private void btn_Surec_Click(object sender, EventArgs e)
        {
            if(userid==1)
            {
                MessageBox.Show("Yetkiniz bulunmamaktadır!");
            }
            else
            {
                string deger = dataGridView1.CurrentRow.Cells["projectID"].Value.ToString();
                
                frm3.secilenProje = deger;
                projectID = Convert.ToInt32(deger);
                frm3.Show();
                this.Hide();
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            tb_Project.SelectedIndex = 1;
            if (userid == 2 || userid == 3)
            {
                tab_Ekle.Hide();
                MessageBox.Show("Yetkiniz bulunmamaktadır...");
            }
            else
            {
                tab_Ekle.Show();
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            tb_Project.SelectedIndex = 2;
            if(userid==2 || userid==3)
            {
                tab_Guncelle.Hide();
                MessageBox.Show("Yetkiniz bulunmamaktadır...");
            }
            else
            {
                tab_Guncelle.Show();
            }
        }


        private void btn_projeEkle_Click(object sender, EventArgs e)
        {
            if (txt_ProjeAdi.Text == "" || date_Baslangic.Value == null || date_Bitis.Value == null || txt_Butce.Text == "" || cmb_projeYoneticisi.Text == "")
            {
                MessageBox.Show("Boş Geçilemez!");
            }

            else
            {

                Project p = new Project();
                p.name = txt_ProjeAdi.Text.ToString();
                p.startDate = Convert.ToDateTime(date_Baslangic.Value);
                p.finishDate = Convert.ToDateTime(date_Bitis.Value);
                p.budget = Convert.ToSingle(txt_Butce.Text);
                string username = cmb_projeYoneticisi.SelectedItem.ToString();



                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string sorgu = "select userID from tblUsers WHERE userName = '" + username + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                int a = Convert.ToInt32(komut.ExecuteScalar());
                MessageBox.Show(a.ToString());
                baglanti.Close();

                MessageBox.Show(a.ToString());
                baglanti.Close();

                baglanti.Open();
                string kayit2 = "insert into tblProject(projectName,startDate,finishDate,budget,isActive,projectManagerID) values(@projectName,@startDate,@finishDate,@budget,@isActive,@projectManagerID)";
                SqlCommand cmd = new SqlCommand(kayit2, baglanti);

                cmd.Parameters.AddWithValue("@projectName", p.name);
                cmd.Parameters.AddWithValue("@startDate", p.startDate);
                cmd.Parameters.AddWithValue("@finishDate", p.finishDate);
                cmd.Parameters.AddWithValue("@budget", p.budget);
                cmd.Parameters.AddWithValue("@isActive", true);
                cmd.Parameters.AddWithValue("projectManagerID", a);

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Proje başarıyla eklendi");
            }

        }
        private void cmb_projeYoneticisi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_Gun_Proje_Click(object sender, EventArgs e)
        {
            if (txt_Gun_Butce.Text == "" || cmb_Gun_ProjeAdi.Text == "" || cmb_Gun_PtojeYoneticisi.Text == "" || date_Gun_Baslangic.Value == null || date_Gun_Bitis.Value == null)
            {
                MessageBox.Show("Boş Geçilemez!");
            }

            else
            {
                Project p = new Project();
                string projectName = cmb_Gun_ProjeAdi.SelectedItem.ToString();
                p.startDate = Convert.ToDateTime(date_Gun_Baslangic.Value);
                p.finishDate = Convert.ToDateTime(date_Gun_Bitis.Value);
                p.budget = Convert.ToSingle(txt_Gun_Butce.Text);
                string userName = cmb_Gun_PtojeYoneticisi.SelectedItem.ToString();


                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string sorgu = "select userID from tblUsers WHERE userName = '" + userName + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                int a = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();

                baglanti.Open();
                string kayit2 = "update tblProject set projectName=@projectName,startDate=@startDate, finishDate=@finishDate, budget=@budget, projectManagerID=@projectManagerID where projectName='" + projectName + "' ";
                SqlCommand cmd = new SqlCommand(kayit2, baglanti);
                cmd.Parameters.AddWithValue("@projectName", projectName);
                cmd.Parameters.AddWithValue("@startDate", p.startDate);
                cmd.Parameters.AddWithValue("@finishDate", p.finishDate);
                cmd.Parameters.AddWithValue("@budget", p.budget);
                cmd.Parameters.AddWithValue("@projectManagerID", a);

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Proje başarıyla güncellendi");
            }
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string deger = dataGridView1.CurrentRow.Cells["projectID"].Value.ToString();

            if (userid == 2 || userid == 3)
            {
                MessageBox.Show("Yetkiniz bulunmamaktadır!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                string sorgu = "DELETE FROM tblProject WHERE projectID = '" + deger + "'";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Veri Başarıyla Silindi");
            }
        }

        private void tab_Ekle_Click(object sender, EventArgs e)
        {
            if(userid==2 || userid==3)
            {
                this.Hide();
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void txt_ProjeAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ';
        }

        private void date_Baslangic_ValueChanged(object sender, EventArgs e)
        {
            date_Bitis.MinDate = date_Baslangic.Value;
        }

        private void txt_Butce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void date_Gun_Baslangic_ValueChanged(object sender, EventArgs e)
        {
            date_Bitis.MinDate = date_Baslangic.Value;
        }

        private void txt_Gun_Butce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
