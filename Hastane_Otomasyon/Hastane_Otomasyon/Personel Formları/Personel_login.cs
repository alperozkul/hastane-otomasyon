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
    public partial class Personel_login : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataReader dr;
        public int personeltur_id;
        

        public Personel_login()
        {
            InitializeComponent();
        }

        private void Personel_login_Load(object sender, EventArgs e)
        {
            con.baglanti();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = ("SELECT TC, PAROLA, PERSONELTUR_ID, personel.id from GENEL_BILGI, PERSONEL WHERE PERSONEL.genelbilgi_id = GENEL_BILGI.id AND GENEL_BILGI.tc='" + TC_TB.Text + "' AND GENEL_BILGI.parola='" + Sifre_TB.Text + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                personeltur_id = Convert.ToInt32(dr["PERSONELTUR_ID"].ToString());
                if (personeltur_id == 1)
                {
                    Yönetici yönetici_frm = new Yönetici();
                    yönetici_frm.Show();
                }
                else if (personeltur_id == 2)
                {
                    Doktor doktor_frm = new Doktor(); 
                    int prsnl_id;
                    prsnl_id = Convert.ToInt32(dr["id"].ToString());
                    doktor_frm.prsnl_id = prsnl_id;
                    doktor_frm.Show();

                }
                else if(personeltur_id == 3)
                {
                    Hemşire hemsire_frm = new Hemşire();
                    hemsire_frm.Show();
                }
                else if(personeltur_id == 4)
                {
                    Görevli görevli_frm = new Görevli();
                    görevli_frm.Show();                    
                }
                else if(personeltur_id == 5)
                {
                    Sekreter sekreter_frm = new Sekreter();
                    int prsnl_id;
                    prsnl_id = Convert.ToInt32(dr["id"].ToString());
                    sekreter_frm.personel_id = prsnl_id;
                    sekreter_frm.Show();
                }
                else
                {
                    MessageBox.Show("ne oldu anlamadım");
                }          
                this.Hide();

                

                


                
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok. Lütfen TC ve parolanızı kontrol ediniz.");
            }
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_frm = new Ana_Menu();
            ana_frm.Show();
            this.Close();
        }
    }
}
