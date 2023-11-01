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
    public partial class Yönetici : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataReader dr;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        public int gnlblg_id;
        public int personel_id;
        public int brans_id;
        public int pers_id;






        public Yönetici()
        {
            InitializeComponent();
        }
        public void kayityap()
        {
            var sql = ("insert into GENEL_BILGI(ad, soyad, tc, dogum, cinsiyet, kan_grubu, parola)" +
                "values('" + Ad_TB.Text + "','" + Soyad_TB.Text + "','" + TC_TB.Text + "', (SELECT TO_DATE('" + Dogum_DTP.Text + "', 'dd/mm/yyyy') FROM dual) ,'" + Cinsiyet_CB.Text + "','" + Kan_CB.Text + "' ,'" + Parola_TB.Text + "')");
            cmd = new OracleCommand(sql, con.baglanti());
            cmd.ExecuteNonQuery();
            //GENEL BİLGİ TABLOSUNA TEXTBOX VERİLERİ AKTARILDI
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_frm = new Ana_Menu();
            ana_frm.Show();
            this.Hide();
        }

        public void personelleri_goruntule()
        {
            cmd = new OracleCommand("select personel.id, genelbilgi_id, tur, ad, soyad, tc, dogum, cinsiyet, kan_grubu  from personel , genel_bilgi , personel_tur where genel_bilgi.id = personel.genelbilgi_id and personel_tur.id = personel.personeltur_id", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            ds1 = new DataSet();
            da.Fill(ds1);
            Personel_DGW.DataSource = ds1.Tables[0];
        }

        private void Yönetici_Load(object sender, EventArgs e)
        {
            con.baglanti();
            string sql = ("SELECT Ad, Soyad, Tc, Dogum, Cinsiyet, Kan_grubu  from GENEL_BILGI, HASTA where hasta.genelbilgi_id = genel_bilgi.id");
            cmd = new OracleCommand(sql, con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[5].HeaderText = "KAN GRUBU";

            //Personelleri görüntüleyebilmek adına personel combobox'ına veritabanındaki veriler aktarıldı.
            cmd = new OracleCommand("select * from personel_tur", con.baglanti());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                personelList_CB.Items.Add(dr[1].ToString());
            }

            //BÜTÜN PERSONELLERİ GÖRÜNTÜLE 
            personelleri_goruntule();
           
        }

        private void TC_arama_TB_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "Tc LIKE '" + TC_arama_TB.Text + "%'";      //DATAGRİDVİEW ÜZERİNDE TC'YE GÖRE ARAMA YAPILIYOR.
            dataGridView1.DataSource = dv;
        }

        private void bilgileri_getir_Click(object sender, EventArgs e)
        {
            hastakayit_frm hastakayit = new hastakayit_frm();
            hastakayit.Show();
        }

        private void hasta_kayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TC_arama_TB.Text))
            {
                MessageBox.Show("TC alanı boş bırakılamaz!");
            }
            else
            {

                Hasta_guncelleme hasta_gncl = new Hasta_guncelleme();
                hasta_gncl.TC_verisi = TC_arama_TB.Text;
                hasta_gncl.Show();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TC_arama_TB.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
        }


        private void Personel_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Personel_CB.Text == "Doktor")
            {
                Doktor_CB.Items.Clear();
                label17.Visible = true;
                Doktor_CB.Visible = true;
                label18.Visible = false;
                Hemsire_CB.Visible = false;
                label19.Visible = false;
                cmd = new OracleCommand("SELECT * FROM BRANS WHERE brans.personeltur_id=2", con.baglanti());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Doktor_CB.Items.Add(dr["tanim"]);
                }
            }
            else if (Personel_CB.Text == "Hemşire")
            {
                Hemsire_CB.Items.Clear();
                label18.Visible = true;
                Hemsire_CB.Visible = true;
                label17.Visible = false;
                Doktor_CB.Visible = false;
                label19.Visible = false;
                cmd = new OracleCommand("SELECT * FROM BRANS WHERE brans.personeltur_id=3", con.baglanti());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Hemsire_CB.Items.Add(dr["tanim"]);
                }
            }
            else if (Personel_CB.Text == "Sekreter")
            {
                label19.Visible = true;
                label18.Visible = false;
                Hemsire_CB.Visible = false;
                label17.Visible = false;
                Doktor_CB.Visible = false;
            }
        }
        public void personelid_al()
        {
            var sql = ("select id from personel where personel.genelbilgi_id ='" + gnlblg_id + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                personel_id = Convert.ToInt32(dr["id"].ToString());
            }
        }

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            kayityap();
            try
            {
                var sql = ("select id from GENEL_BILGI where GENEL_BILGI.TC='" + TC_TB.Text + "'");
                cmd = new OracleCommand(sql, con.baglanti());
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gnlblg_id = Convert.ToInt32(dr["id"].ToString());
                }
                //KAYIT YAPILAN GENEL_BİLGİ TABLOSUNUN İD'Sİ gnlblg_id int degiskenine atandı.

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





                if (Personel_CB.Text == "Doktor")
                {
                    sql = ("insert into personel(genelbilgi_id, personeltur_id)" +
                        "values('" + gnlblg_id + "', '2')");
                    cmd = new OracleCommand(sql, con.baglanti());
                    cmd.ExecuteNonQuery();
                    //PERSONEL TABLOSUNA GENELBİLGİ İD VE PERSONELTUR İD ATANDI.

                    personelid_al();
                    //KAYITLANMIŞ PERSONELİN İD'Sİ ALINDI

                    sql = ("select id, tanim from brans where brans.tanim='" + Doktor_CB.Text + "'");
                    cmd = new OracleCommand(sql, con.baglanti());
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        brans_id = Convert.ToInt32(dr["id"].ToString());
                        //COMBOBOXTAN SEÇİLEN BRANŞIN İD'Sİ ALINDI.
                    }

                    sql = ("insert into kisibrans(personel_id,brans_id)" +
                        "values('" + personel_id + "','" + brans_id + "')");
                    cmd = new OracleCommand(sql, con.baglanti());
                    cmd.ExecuteNonQuery();
                    //KİSİBRANS TABLOSUNA PERSONELİD'Sİ VE BRANŞİD ATANDI.


                }
                else if (Personel_CB.Text == "Hemşire")
                {
                    sql = ("insert into personel(genelbilgi_id, personeltur_id)" +
                        "values('" + gnlblg_id + "', '3')");
                    cmd = new OracleCommand(sql, con.baglanti());
                    cmd.ExecuteNonQuery();
                    //PERSONEL TABLOSUNA GENELBİLGİ İD VE PERSONELTUR İD ATANDI.

                    personelid_al();
                    //KAYITLANMIŞ PERSONELİN İD'Sİ ALINDI

                    sql = ("select id, tanim from brans where brans.tanim='" + Hemsire_CB.Text + "'");
                    cmd = new OracleCommand(sql, con.baglanti());
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        brans_id = Convert.ToInt32(dr["id"].ToString());
                        //COMBOBOXTAN SEÇİLEN BRANŞIN İD'Sİ ALINDI.
                    }

                    sql = ("insert into kisibrans(personel_id,brans_id)" +
                        "values('" + personel_id + "','" + brans_id + "')");
                    cmd = new OracleCommand(sql, con.baglanti());
                    cmd.ExecuteNonQuery();
                    //KİSİBRANS TABLOSUNA PERSONELİD'Sİ VE BRANŞİD ATANDI.

                }
                else if (Personel_CB.Text == "Sekreter")
                {
                    sql = ("insert into personel(genelbilgi_id,personeltur_id)" +
                        "values('" + gnlblg_id + "', '5')");
                    cmd = new OracleCommand(sql, con.baglanti());
                    cmd.ExecuteNonQuery();
                    //Personel Sekreter ise personel.personeltur_id = 5 yapıldı
                }
                else if(Personel_CB.Text == "Laboratuvar Görevlisi")
                {
                    cmd = new OracleCommand("insert into personel(genelbilgi_id, personeltur_id) values( '"+gnlblg_id+"', '4')", con.baglanti());
                    cmd.ExecuteNonQuery();
                }
                Yönetici yönetici_frm = new Yönetici();
                yönetici_frm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!");
            }
        }

        private void personeller_btn_Click(object sender, EventArgs e)
        {
            //----------BÜTÜN PERSONELLERİ GÖRÜNTÜLE BAŞ----------
            personelleri_goruntule();
           
        }

        private void secilipersonel_btn_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand("select id from personel_tur where personel_tur.tur = '" + personelList_CB.Text + "' ", con.baglanti());
            dr = cmd.ExecuteReader();
            dr.Read();
            pers_id = Convert.ToInt32(dr[0].ToString());

            cmd = new OracleCommand("select personel.id, genelbilgi_id, tur, ad, soyad, tc, dogum, cinsiyet, kan_grubu  from personel , genel_bilgi , personel_tur where genel_bilgi.id = personel.genelbilgi_id and personel_tur.tur = '"+personelList_CB.Text+"' and personel.personeltur_ıd = '"+pers_id+"' ", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);
            Personel_DGW.DataSource = ds.Tables[0];
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
    }

