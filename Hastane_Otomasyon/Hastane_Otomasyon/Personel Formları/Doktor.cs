using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Hastane_Otomasyon
{
    public partial class Doktor : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader dr;
        public int prsnl_id; 
        public string hastaid, doktorid;
        public int prsnl_gnlbilgi_id;

        public Doktor()
        {
            InitializeComponent();
        }
        private void Doktor_Load(object sender, EventArgs e)
        {
            con.baglanti();
            cmd = new OracleCommand("select randevu.id, ad, soyad, tc, randevu_tarih, randevu_saat, personel_id, hasta_id from randevu join hasta on hasta.id = randevu.hasta_id join genel_bilgi on genel_bilgi.id = hasta.genelbilgi_id where randevudurum_id = '1' and randevu.personel_id = '" + prsnl_id+"'", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            Randevular_DGW.DataSource = ds.Tables[0];
            Randevular_DGW.Columns["hasta_id"].Visible = false;
            Randevular_DGW.Columns["personel_id"].Visible = false;

            //ESKİ RANDEVU DATAGRİDVİEW BAŞI---------------------
            //cmd = new OracleCommand("select * from randevu where randevu.personel_id='" + prsnl_id + "' AND  randevu.randevudurum_id='1' ", con.baglanti());
            //cmd.CommandType = CommandType.Text;
            //da.SelectCommand = cmd; //DOKTOR FORMU LOAD OLUNCA DATAGRİDVİEW RANDEVULARIYLA DOLDURULUYOR.
            //da.Fill(ds);
            //Randevular_DGW.DataSource = ds.Tables[0];
            //ESKİ RANDEVU DATAGRİDVİEW SONU---------------------

            cmd = new OracleCommand("select ad, soyad, tc, dogum, cinsiyet, kan_grubu, parola, genel_bilgi.id  from genel_bilgi, personel where personel.id='"+prsnl_id+ "' and personel.genelbilgi_id = genel_bilgi.id ", con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                prsnl_gnlbilgi_id = Convert.ToInt32(dr[7].ToString());// personelin genelbilgi id'si alınd.
                
                //GENELBİLGİ BAŞ
                Ad_TB.Text = dr[0].ToString();
                Soyad_TB.Text = dr[1].ToString();
                TC_TB.Text = dr[2].ToString();
                Dogum_DTP.Text = dr[3].ToString(); 
                Cinsiyet_TB.Text = dr[4].ToString();
                Kan_TB.Text = dr[5].ToString();
                Parola_TB.Text = dr[6].ToString();
                //GENELBİLGİ SON

                //KÖTÜ MÜHENDİSLİK MAİL VE TELEFON ÇEKİLDİ
                cmd = new OracleCommand("select * from kisi_iletisim where kisi_iletisim.genelbilgi_id ='" + prsnl_gnlbilgi_id + "'", con.baglanti());
                dr = cmd.ExecuteReader();
                dr.Read();
                Mail_TB.Text = dr[3].ToString();
                while (dr.Read())
                {   
                    Tel_TB.Text = dr[3].ToString();
                }
                //KÖTÜ MÜHENDİSLİK MAİL VE TELEFON ÇEKİLDİ

                //PERSONEL ADRES BİLGİLERİ BAŞ
                cmd = new OracleCommand("select * from kisiadres where kisiadres.genelbilgi_id = '"+prsnl_gnlbilgi_id+"'", con.baglanti());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    İl_TB.Text = dr[2].ToString();
                    İlce_TB.Text = dr[3].ToString();
                    Adres_TB.Text = dr[4].ToString();
                }
                //PERSONEL ADRES BİLGİLERİ SON

                //DOKTOR BRANŞI ÇEKMEK İÇİN BAŞ
                cmd = new OracleCommand("select * from brans inner join kisibrans on kisibrans.brans_id = brans.id and kisibrans.personel_id = '"+prsnl_id+"'", con.baglanti());
                dr = cmd.ExecuteReader(); //İLK DEFA İNNER JOİN KULLANILDI.
                if (dr.Read())
                {
                    doktorBrans_TB.Text = dr[1].ToString();
                }
                //DOKTOR BRANŞI ÇEKMEK İÇİN SON

            }

        }

        //private void Randevular_DGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    randevuId_TB.Text = Randevular_DGW.CurrentRow.Cells[0].Value.ToString();
        //    hastaid = Randevular_DGW.CurrentRow.Cells["Hasta_Id"].Value.ToString(); //değişkenlere id değerleri atanıyor.
        //    doktorid = Randevular_DGW.CurrentRow.Cells["Personel_Id"].Value.ToString();
            
        //}

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_menu = new Ana_Menu();
            ana_menu.Show();
            this.Close();
        }

        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Bu randevu silinsin mi?","Silme Onayı",MessageBoxButtons.YesNo);
            if(DialogResult.Yes == durum)
            {
                cmd = new OracleCommand("delete from randevu where randevu.id='" + randevuId_TB.Text + "'", con.baglanti());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla silinmiştir.");

                Randevular_DGW.Columns.Clear();
                ds.Tables.Clear();          //RANDEVU SİLİNİNCE DATAGRİDVİEW VERİLERİNİ VE TABLOYU TEMİZLEYİP REFRESH EDİP TEKRAR VERİ EKLENMEYE HAZIR HALE GETİRİYOR.
                Randevular_DGW.Refresh();

                cmd = new OracleCommand("select * from randevu where randevu.personel_id='" + prsnl_id + "' AND  randevu.randevudurum_id='1' ", con.baglanti());
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd; //DOKTOR FORMU LOAD OLUNCA DATAGRİDVİEW RANDEVULARIYLA DOLDURULUYOR.
                da.Fill(ds);
                Randevular_DGW.DataSource = ds.Tables[0];


            }
        }

        private void Randevular_DGW_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            randevuId_TB.Text = Randevular_DGW.CurrentRow.Cells[0].Value.ToString();
            hastaid = Randevular_DGW.CurrentRow.Cells["hasta_id"].Value.ToString(); //değişkenlere id değerleri atanıyor.
            doktorid = Randevular_DGW.CurrentRow.Cells["personel_id"].Value.ToString();
        }

        private void Muayene_btn_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.randevu_id = Convert.ToInt32(randevuId_TB.Text);
            muayene.hasta_id = Convert.ToInt32(hastaid);        //Randevu Tablosundan hasta personel ve randevu id çekilip muayene formuna aktarılıyor.
            muayene.doktor_id = Convert.ToInt32(doktorid);
            muayene.Show();
            
        }
    }
}
