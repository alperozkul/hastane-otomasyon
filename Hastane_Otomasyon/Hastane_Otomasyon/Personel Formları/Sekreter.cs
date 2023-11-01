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
    public partial class Sekreter : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataReader dr;
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        public int personel_id;
        public Sekreter()
        {
            InitializeComponent();
        }

        private void Sekreter_Load(object sender, EventArgs e)
        {
            con.baglanti();
            duyuruTarih_DTP.Value = DateTime.Now;
            
        }

        private void duyuruOlstr_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Duyuru oluşturulsun mu?", "DUYURU", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cmd = new OracleCommand("insert into  duyuru(duyuru, tarih, personel_id, baslik) values('" + Duyuru_RTB.Text + "', (SELECT TO_DATE('" + duyuruTarih_DTP.Text + "', 'dd/mm/yyyy') FROM dual), '" + personel_id + "', '"+duyuruBaslik_TB.Text+"')", con.baglanti());
                cmd.ExecuteNonQuery(); // DUYURU OLUŞTURMA
                MessageBox.Show("Duyuru oluşturuldu.");
                Sekreter_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Duyuru iptal edildi.");
            }

        }
    }
}
