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
    public partial class Muayene : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader dr;
        public int randevu_id, hasta_id, doktor_id, recete_id;

        private void Test_btn_Click(object sender, EventArgs e)
        {
            Testler_Listbox.Visible = true;
            labGonder_btn.Visible = true;
            labSonuc_DGW.Visible = false;
        }

        private void labGonder_btn_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Testler_Listbox.CheckedItems.Count; i++)
            {
                cmd = new OracleCommand("insert into randevutahlil(randevu_id, tahliltur_id, tahlildurum) values('"+Randevuid_TB.Text+ "', (select id from tahliltur where tahliltur.tanim='" + Testler_Listbox.CheckedItems[i] + "') , 'Test Bekleniyor.')", con.baglanti());
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Seçili testler başarıyla laboratuvara gönderildi.");
        }

        private void sonucGetir_btn_Click(object sender, EventArgs e)
        {
            labSonuc_DGW.Visible = true;
            Testler_Listbox.Visible = false;
            labGonder_btn.Visible = false;

            labSonuc_DGW.Columns.Clear();
            ds.Tables.Clear();  //DatagridView Temizlenmesi için bu komut kullanılıyor.
            labSonuc_DGW.Refresh();


            cmd = new OracleCommand("select tanim, sonuc from randevutahlil, tahliltur where randevutahlil.randevu_id='"+Randevuid_TB.Text+"' and randevutahlil.tahlildurum='Test Tamamlandı.' and randevutahlil.tahliltur_id = tahliltur.id ", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;  //Hastanın sonuçlanan testlerinde hangi testin hangi sonucu olduğunu dgw'a aktarıyoruz.
            da.Fill(ds);
            labSonuc_DGW.DataSource = ds.Tables[0];

        }

        private void Testler_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gönder_btn_Click(object sender, EventArgs e)
        {

            cmd = new OracleCommand("insert into recete(tani, recete_aciklama, randevu_id) values('"+Tanı_RTB.Text+"', '"+Recete_RTB.Text+"', '" + Randevuid_TB.Text + "')", con.baglanti());
            cmd.ExecuteNonQuery(); //recete tablosuna tanı, reçete açıklama ve randevu_id'si atandı.

            cmd = new OracleCommand("select id, randevu_id from recete where recete.randevu_id= '"+Randevuid_TB.Text+"' ", con.baglanti());
            dr = cmd.ExecuteReader();//Randevu_id'si textboxta yazanla aynı olanın recete_id'sini almak için.
            if (dr.Read())
            {
                recete_id = Convert.ToInt32(dr[0].ToString());
                for (int i = 0; i < İlaclar_ListBox.CheckedItems.Count; i++)
                {
                    cmd = new OracleCommand("insert into receteilac(recete_id, ilac_id) values('" +recete_id+ "', (select id from ilac where ilac.tanim='" + İlaclar_ListBox.CheckedItems[i] + "'))", con.baglanti());
                    cmd.ExecuteNonQuery();//receteilac tablosuna seçili ilaçların id'sini atamak için yapıldı.
                }
            }
            cmd = new OracleCommand("update randevu set randevudurum_id='2' where id='"+Randevuid_TB.Text+"'", con.baglanti());
            cmd.ExecuteNonQuery();
            //RANDEVUDURUMİD TAMAMLANDI OLARAK AYARLA.
            MessageBox.Show("Muayene başarıyla sonuçlandı.");
            
        }

        public Muayene()
        {
            InitializeComponent();
        }

        private void Muayene_Load(object sender, EventArgs e)
        {
            con.baglanti();
            Randevuid_TB.Text = randevu_id.ToString();      
            cmd = new OracleCommand("select * from genel_bilgi, hasta where genel_bilgi.id= hasta.genelbilgi_id and hasta.id='"+hasta_id+"'", con.baglanti());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ad_TB.Text = dr[1].ToString();
                Soyad_TB.Text = dr[2].ToString();
                TC_TB.Text = dr[3].ToString();
                Dogum_TB.Text = dr[4].ToString(); //MUAYENE FORMU LOAD OLURKEN HASTANIN BİLGİLERİ TEXTBOXLARA YAZDIRILIR.
                Cinsiyet_TB.Text = dr[5].ToString();
                Kan_TB.Text = dr[6].ToString();
            }

            Doktorid_TB.Text = doktor_id.ToString();    //DOKTORİD'Sİ TEXTBOX'A YAZDIRILIR.

            cmd = new OracleCommand("select * from kisibrans where personel_id='"+doktor_id+"'", con.baglanti());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            { 
                Klinikid_TB.Text = dr[2].ToString();   //KLİNİKİD'Sİ TEXTBOX'A YAZDIRILIR.
            }
            Testler_Listbox.Visible = false;
            labGonder_btn.Visible = false;  //form açılınca sadece test iste butonu olması için
            labSonuc_DGW.Visible = false;
            sonucGetir_btn.Visible = false;
            
            cmd = new OracleCommand("select * from randevutahlil where randevutahlil.randevu_id='"+Randevuid_TB.Text+"'", con.baglanti());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(dr[3].ToString()== "Test Tamamlandı.")
                {
                    sonucGetir_btn.Visible = true;          //eğer tamamlanmış bir test varsa sonucgetir butonu açılıyor.
                }
            }

        }
    }
}
