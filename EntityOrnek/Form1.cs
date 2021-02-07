using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void buttonDersListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * From tbldersler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }

        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {
            //SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            //SqlCommand komut = new SqlCommand("Select * From TBLOGRENCİ", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            
            dataGridView1.DataSource = db.TBLOGRENCİ.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            
            

        }

        private void buttonNotListele_Click(object sender, EventArgs e)
        {

            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBLOGRENCİ.AD,
                            item.TBLDERSLER.DERSAD,
                            item.DERS,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource = db.TBLNOTLAR.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
          
           
            
            if (textBoxOgrAd.Text!="")
            {
                TBLOGRENCİ tBLOGRENCİ = new TBLOGRENCİ();
                tBLOGRENCİ.AD = textBoxOgrAd.Text;
                tBLOGRENCİ.SOYAD = textBoxOgrSoyad.Text;
                db.TBLOGRENCİ.Add(tBLOGRENCİ);
                db.SaveChanges();
                MessageBox.Show("ogrenci listeye eklendi");
            }
            else if (textBoxDersAd.Text!=null)
            {
                TBLDERSLER tDers = new TBLDERSLER();
                tDers.DERSAD = textBoxDersAd.Text;
                db.TBLDERSLER.Add(tDers);
                db.SaveChanges();
                MessageBox.Show("ders eklendi");
            }
            
        }
        
        private void BtnSil_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBoxOgrID.Text);
            var result=db.TBLOGRENCİ.Find(id);
            db.TBLOGRENCİ.Remove(result);
            db.SaveChanges();
            MessageBox.Show(" silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxOgrID.Text);
            var result = db.TBLOGRENCİ.Find(id);
            result.AD = textBoxOgrAd.Text;
            result.SOYAD = textBoxOgrSoyad.Text;
            result.FOTOGRAF = textBoxOgrFoto.Text;
            db.SaveChanges();
            MessageBox.Show("güncelledi"); 
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
           
            if (textBoxOgrAd.Text !="" )
            {
                string aranan = textBoxOgrAd.Text;
                dataGridView1.DataSource = db.TBLOGRENCİ.Where(p => p.AD.Contains(aranan)).ToList();
                MessageBox.Show(" OGR BULUNDU");
               
                
            }
          
            if (textBoxDersAd.Text !="" )
            {
                string aranan = textBoxDersAd.Text;
                dataGridView1.DataSource = db.TBLDERSLER.Where(t => t.DERSAD.Contains(aranan)).ToList();
                MessageBox.Show("DERS BULUNDU");
            }
         




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonProcedür_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void buttonLinqExecute_Click(object sender, EventArgs e)
        {
            
            
             if (radioButton1.Checked==true)
            {
                List<TBLOGRENCİ> liste1 = db.TBLOGRENCİ.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
             if (radioButton2.Checked == true)
            {
                List<TBLOGRENCİ> liste2 = db.TBLOGRENCİ.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked==true)
            {
                var TOPLAM = db.TBLNOTLAR.Sum(P => P.SINAV1);
                MessageBox.Show("toplam sınav   :  " + TOPLAM.ToString());
                

            }
            if (radioButton4.Checked=true)
            {
                var ORT = db.TBLNOTLAR.Average(P => P.SINAV1);
                MessageBox.Show("ORT sınav   :  " + ORT.ToString());
                decimal? maxNot = db.TBLNOTLAR.Max(p => p.SINAV1);
                // maxnot alan kişinin notlar tablosundaki satırını al
                int? kim = db.TBLNOTLAR.FirstOrDefault(p => p.SINAV1 == maxNot).OGR;
                // id si kim.id olan kişiyi yakala
                String ad = db.TBLOGRENCİ.FirstOrDefault(p => p.ID == kim).AD;
                String soyad = db.TBLOGRENCİ.FirstOrDefault(p => p.ID == kim).SOYAD;
                // sonucu yazdır
                MessageBox.Show("En Yüksek Alan Kişi: " + ad + " " + soyad);








            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void JOIN_Click(object sender, EventArgs e)
        {
            short? maxNot = db.TBLNOTLAR.Max(p => p.SINAV1);
            var sorgu = from d1 in db.TBLNOTLAR
                        where d1.SINAV1==maxNot
                        join d2 in db.TBLOGRENCİ
                        on d1.OGR equals d2.ID
                        select new
                        {
                            ad=d2.AD,
                            SINAV1=d1.SINAV1,
                            SINAV2=d1.SINAV2

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }

}
