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
    public partial class Hasta_guncelleme : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        public OracleCommand cmd;
        Ana_Menu ana_frm = new Ana_Menu();
        public int gnlblg_id;
        public string TC_verisi = "";

        public Hasta_guncelleme()
        {
            InitializeComponent();
        }
        public void hasta_sorgu_güncelleme()
        {
            string sql = ("select * from GENEL_BILGI, HASTA where GENEL_BILGI.ID = HASTA.GENELBILGI_ID AND GENEL_BILGI.TC='" + TC_TB.Text + "'"); //HASTA TABLOSUNDAKİ GENELBILGI_ID İLE GENELBILGI TABLOSUNDAKİ ID'Sİ ESİT OLANLAR VE TC_TB.TEXT
            cmd = new OracleCommand(sql, con.baglanti());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Ad_TB.Text = dr.GetValue(1).ToString();
                Soyad_TB.Text = dr.GetValue(2).ToString();
                Dogum_DTP.Text = dr.GetOracleDateTime(4).ToString();
                Cinsiyet_CB.Text = dr.GetValue(5).ToString();
                Kan_CB.Text = dr.GetValue(6).ToString();


            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok.");

            }

            sql = ("select id from GENEL_BILGI where GENEL_BILGI.TC='" + TC_TB.Text + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                gnlblg_id = Convert.ToInt32(dr["id"].ToString());
            }
            //TC SAYESİNDE GENELBİLGİ.İD VERİSİNE ULAŞIYORUZ VE İLETİŞİM, ADRES TABLOLARINDA İD'YE GÖRE ARAMA YAPIP
            //DATAGRİDVİEWA BASTIRIYORUZ.

            sql = ("SELECT id, tür, bilgi from kisi_iletisim where kisi_iletisim.genelbilgi_id ='" + gnlblg_id + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //İLETİSİMDE BİLGİ VE TÜR COLUMN ÇEKMEK İÇİN BU KOD

            sql = ("SELECT id, il, ilce, adres from kisiadres where kisiadres.genelbilgi_id ='" + gnlblg_id + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            cmd.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            //ADRESDE İL, İLCE, ADRES SÜTUNLARIN ÇEKMEK İÇİN BU KOD.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hasta_sorgu_güncelleme();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.baglanti();
            TC_TB.Text = TC_verisi;
            hasta_sorgu_güncelleme();
        }

       

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string iletisim_id, tür, bilgi, adres_id, il, ilce, adres;
                string sql = ("update genel_bilgi set ad='" + Ad_TB.Text + "', soyad='" + Soyad_TB.Text + "', dogum=(SELECT TO_DATE('" + Dogum_DTP.Text + "', 'dd/mm/yyyy') FROM dual), cinsiyet='" + Cinsiyet_CB.Text + "', kan_grubu='" + Kan_CB.Text + "' where genel_bilgi.tc='" + TC_TB.Text + "'");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();

                iletisim_id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                bilgi = dataGridView1.CurrentRow.Cells["bilgi"].Value.ToString();
                tür = dataGridView1.CurrentRow.Cells["tur"].Value.ToString();

                adres_id = dataGridView2.CurrentRow.Cells["id2"].Value.ToString();
                il = dataGridView2.CurrentRow.Cells["il"].Value.ToString();
                ilce = dataGridView2.CurrentRow.Cells["ilce"].Value.ToString();
                adres = dataGridView2.CurrentRow.Cells["adres"].Value.ToString();

                sql = ("update  KISI_ILETISIM  set bilgi='" + bilgi + "', tür='" + tür + "' where KISI_ILETISIM.ID='" + iletisim_id + "'");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();
                sql = ("update  KISIADRES  set il='" + il + "', ilce='" + ilce + "', adres='" + adres + "' where KISIADRES.ID='" + adres_id + "'");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();

                MessageBox.Show("İşlem başarıyla tamamlanmıştır.");
            }
            catch
            {
                MessageBox.Show("Hatalı işlem yaptınız.");
            }
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sql = ("select * from genel_bilgi where genel_bilgi.tc='" + TC_TB.Text + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string isim = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    sql = ("delete from genel_bilgi where genel_bilgi.tc='" + TC_TB.Text + "'");
                    cmd = new OracleCommand(sql, con.baglanti());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt silindi.");
                    HastaKontrol hastafrm = new HastaKontrol();
                    hastafrm.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı.");
            }
        }
    }
}
