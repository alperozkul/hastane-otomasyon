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
    public partial class Görevli : Form
    {
        //------------GEREKLİ TANIMLAMALAR BAŞ------------
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader dr;

        //------------GEREKLİ TANIMLAMALAR SON------------



        public Görevli()
        {
            InitializeComponent();
        }


        private void Görevli_Load(object sender, EventArgs e)
        {
            con.baglanti();
        }



        //------------BEKLEYEN TESTLERİ DATAGRİDVİEW'A ÇEKMEK İÇİN BAŞ------------
        public void bekleyenTest_btn_Click(object sender, EventArgs e)
        {     
            Testler_DGW.Columns.Clear();
            ds.Tables.Clear();  //DatagridView Temizlenmesi için bu komut kullanılıyor.
            Testler_DGW.Refresh();

            cmd = new OracleCommand("select id, randevu_id, tahliltur_id, tahlildurum from randevutahlil where randevutahlil.tahlildurum='Test Bekleniyor.'", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            Testler_DGW.DataSource = ds.Tables[0];
        }
        //------------BEKLEYEN TESTLERİ DATAGRİDVİEW'A ÇEKMEK İÇİN SON------------





        //------------GEÇMİŞ TESTLERİ DATAGRİDVİEW'A ÇEKMEK İÇİN BAŞ------------
        private void gecmisTest_btn_Click(object sender, EventArgs e)
        {
            Testler_DGW.Columns.Clear();
            ds.Tables.Clear();  //DatagridView Temizlenmesi için bu komut kullanılıyor.
            Testler_DGW.Refresh();

            cmd = new OracleCommand("select id, randevu_id, tahliltur_id, tahlildurum from randevutahlil where randevutahlil.tahlildurum='Test Tamamlandı.'", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            Testler_DGW.DataSource = ds.Tables[0];
        }
        //------------GEÇMİŞ TESTLERİ DATAGRİDVİEW'A ÇEKMEK İÇİN BAŞ------------


        //------------BİLGİLERİ GETİRMEK İÇİN BAŞ------------
        private void blgGetir_btn_Click(object sender, EventArgs e)
        {
            randevuTahlil_TB.Text = Testler_DGW.CurrentRow.Cells[0].Value.ToString();
            randevu_TB.Text = Testler_DGW.CurrentRow.Cells[1].Value.ToString();
            cmd = new OracleCommand("select tanim from tahliltur where id= '"+Testler_DGW.CurrentRow.Cells[2].Value+"'", con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Test_TB.Text = dr.GetValue(0).ToString();
            }
        }
        //------------BİLGİLERİ GETİRMEK İÇİN SON------------


        //------------TEST SONUÇLARINI DOKTORA GÖNDERMEK İÇİN BAŞ------------
        private void doktorGönder_btn_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand("update randevutahlil set sonuc ='" + sonuc_TB.Text + "', tahlildurum = 'Test Tamamlandı.' where id='"+randevuTahlil_TB.Text+"' ", con.baglanti());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sonuçlar başarıyla gönderildi.");
            bekleyenTest_btn_Click(sender, e);
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_frm = new Ana_Menu();
            ana_frm.Show();
            this.Close();
        }
        //------------TEST SONUÇLARINI DOKTORA GÖNDERMEK İÇİN SON------------
    }
}
