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
    public partial class Hasta_login : Form
    {
        Oracle_Connection con = new Oracle_Connection(); // Oracle bağlantısı yaparken kod tekrarı olmasın diye class üzerinden veri çekiyorum.
        public OracleCommand cmd;
        OracleDataReader dr;
        public int hasta_id_login;
        

        public Hasta_login()
        {
            InitializeComponent();
        }
        
      

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select hasta.id, TC, Parola, AD, SOYAD from GENEL_BILGI, HASTA where HASTA.GENELBILGI_ID = GENEL_BILGI.ID  AND GENEL_BILGI.parola = '" + Sifre_TB.Text + "' AND GENEL_BILGI.TC = '" + TC_TB.Text + "'";
            cmd = new OracleCommand(sql, con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                hasta_id_login = Convert.ToInt32(dr["id"].ToString());          
                Hasta_menu hasta_menu = new Hasta_menu(); //hastanın id'sini login ekranında alıyorum ve hastamenu'ye atıyorum.
                hasta_menu.hasta_id_menu = hasta_id_login;
                hasta_menu.TC_verisi = TC_TB.Text;
                MessageBox.Show("Hoş Geldin "+ dr["AD"].ToString() +" "+ dr["SOYAD"].ToString()+"");
                hasta_menu.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok!");
            }




        }

        private void Form1_Load(object sender, EventArgs e) //Ana menü yüklenmeden veritabanı bağlantısı burada yapılır.
        {
            con.baglanti(); //Oluşturduğum Oracle_Connection classında baglanti fonksiyonu oluşturup bu formda kullanıyorum.
            

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_frm = new Ana_Menu();
            ana_frm.Show();
            this.Close();
        }
    }
}
