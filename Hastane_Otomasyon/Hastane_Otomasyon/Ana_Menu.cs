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
    public partial class Ana_Menu : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        public OracleCommand cmd;
        OracleDataReader dr;
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
       
        public Ana_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.baglanti();

            //DUYURULARI ÇEKMEK İÇİN BAŞ   
            cmd = new OracleCommand("select baslik, tarih, duyuru from duyuru", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            Duyurular.DataSource = ds.Tables[0];
            Duyurular.Columns["baslik"].ReadOnly = true;
            Duyurular.Columns["tarih"].ReadOnly = true;
            Duyurular.Columns["duyuru"].Visible = false;
            //DUYURULARI ÇEKMEK İÇİN BAŞ
        }

        private void Kayit_btn_Click(object sender, EventArgs e)
        {
            hastakayit_frm kayit_frm = new hastakayit_frm();
            kayit_frm.Show();

            
        }

        private void H_giris_btn_Click(object sender, EventArgs e)
        {
            Hasta_login hasta_lgn = new Hasta_login();
            hasta_lgn.Show();
            this.Hide();
        }

        private void P_giris_btn_Click(object sender, EventArgs e)
        {
            Personel_login personel_lgn = new Personel_login();
            personel_lgn.Show();
            this.Hide();
        }

        private void Duyurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baslik_TB.Text = Duyurular.CurrentRow.Cells["baslik"].Value.ToString();
            duyuru_RTB.Text = Duyurular.CurrentRow.Cells["duyuru"].Value.ToString();
        }

        private void duyuruKpt_btn_Click(object sender, EventArgs e)
        {
            duyuru_pnl.Visible = false;
        }

        private void duyuru_btn_Click(object sender, EventArgs e)
        {
            duyuru_pnl.Visible = true;
        }
    }
}
