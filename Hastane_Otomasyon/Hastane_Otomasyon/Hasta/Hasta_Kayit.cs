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
    public partial class hastakayit_frm : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        public OracleCommand cmd;
        OracleDataReader dr;
        public int gnlblg_id;
        Ana_Menu ana_frm = new Ana_Menu();
        public hastakayit_frm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.baglanti();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = ("insert into GENEL_BILGI(ad, soyad, tc, dogum, cinsiyet, kan_grubu, parola)" +
                "values('" + Ad_TB.Text + "','" + Soyad_TB.Text + "','" + TC_TB.Text + "', (SELECT TO_DATE('" + Dogum_DTP.Text + "', 'dd/mm/yyyy') FROM dual) ,'" + Cinsiyet_CB.Text + "','" + Kan_CB.Text + "' ,'" + Parola_TB.Text + "')");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();
                //GENEL BİLGİ TABLOSUNA TEXTBOX VERİLERİ AKTARILDI.


                sql = ("select id from GENEL_BILGI where GENEL_BILGI.TC='" + TC_TB.Text + "'");
                cmd = new OracleCommand(sql, con.baglanti());
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gnlblg_id = Convert.ToInt32(dr["id"].ToString());
                }
                //KAYIT YAPILAN GENEL_BİLGİ TABLOSUNUN İD'Sİ gnlblg_id int degiskenine atandı.


                sql = ("insert into hasta(genelbilgi_id)" +
                    "values('" + gnlblg_id + "')");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();
                //HASTA TABLOSUNA GENELBİLGİ_İD EKLENDİ.

                sql = ("insert into kisiadres(genelbilgi_id, il, ilce, adres)" +
                    "values('" + gnlblg_id + "' , '" + İl_TB.Text + "' , '" + İlce_TB.Text + "'  , '" + Adres_TB.Text + "')");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();
                //ADRES TABLOSUNA HEM VERİLER HEM GENELBİLGİ_İD EKLENDİ.



                sql = ("insert into KISI_ILETISIM(genelbilgi_id, tür, bilgi)"
                    + "values('" + gnlblg_id + "' , 'Telefon' , '" + Tel_TB.Text + "')");  //TEL BİLGİLERİ ATANDI.
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();

                sql = ("insert into KISI_ILETISIM(genelbilgi_id, tür, bilgi)"
                    + "values('" + gnlblg_id + "' , 'Mail' , '" + Mail_TB.Text + "')");   // MAİL BİLGİLERİ ATANDI.
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt İşlemi Tamamlanmıştır.");
                
                this.Hide();





            }
            catch
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz girdiğinizden emin olunuz!");
            }
            
            

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            //ana_frm.Show();
            this.Hide();
        }
    }
}
