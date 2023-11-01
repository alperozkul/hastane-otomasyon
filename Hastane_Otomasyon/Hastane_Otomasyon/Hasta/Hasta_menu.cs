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
    public partial class Hasta_menu : Form
    {
        Oracle_Connection con = new Oracle_Connection();
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        OracleDataReader dr;
        OracleDataReader dr2;
        OracleDataReader dr3;
        DataSet ds = new DataSet();
        public int hasta_id_menu, klinik_id, gnlblg_id, prsnl_id;
        public string isim, doktor_isim;
        public string TC_verisi = "";
        string randevuid;
        


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
                Parola_TB.Text = dr.GetValue(7).ToString();


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
            dataGridView2.DataSource = ds.Tables[0];
            //İLETİSİMDE BİLGİ VE TÜR COLUMN ÇEKMEK İÇİN BU KOD

            sql = ("SELECT id, il, ilce, adres from kisiadres where kisiadres.genelbilgi_id ='" + gnlblg_id + "'");
            cmd = new OracleCommand(sql, con.baglanti());
            cmd.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            //ADRESDE İL, İLCE, ADRES SÜTUNLARIN ÇEKMEK İÇİN BU KOD.
        }

        private void Klinik_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktor_CB.Text = "";
            Doktor_CB.Items.Clear(); //her klinik seçildiğinde Doktor_CB'da veri birikmesin diye temizleniyor.

            cmd = new OracleCommand("select * from brans where brans.tanim='" + Klinik_CB.Text + "'", con.baglanti());
            dr = cmd.ExecuteReader();//Klinik_CB'de  hangi klinik olduğunu okuyor.
            if (dr.Read())
            {
                klinik_id = Convert.ToInt32(dr["id"].ToString()); //okuduğu klinik text'inin id'sini klinik_id atıyor.
            }

            cmd = new OracleCommand("select * from genel_bilgi where id in(select genelbilgi_id from personel where id in(select personel_id from kisibrans where brans_id='" + klinik_id + "'))", con.baglanti());
            dr = cmd.ExecuteReader();//Brans_id'si klinik_id'ye eşit olan personelid'yi kisibrans tablosundan çekiyor. Çektiği bu veri ile personel'i buluyor ve o personelin genelbilgi_id'sini çekiyor. çektiği bu veriyi de genelbilgi tablosunda bularak ad,soyad vb. bilgilerini çekiyyor.
            while (dr.Read())
            {
                isim = dr["Ad"].ToString(); //isim stringine genelbilgi tablosundaki Ad verisini ekliyor.
                isim += " " + dr["Soyad"].ToString();// Soyad verisini ekliyor.
                Doktor_CB.Items.Add(isim);               //Doktor_CB'a isim stringini aktarıyor.
            }
        }

        private void Rndvolstr_btn_Click(object sender, EventArgs e)
        {
            bilgi_sorgula();
            DialogResult durum = MessageBox.Show(doktor_isim + " Doktoruna saat " + maskedTextBox1.Text + "'a randevu oluşturulsun mu?", "Randevu Onayı", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                cmd = new OracleCommand("insert into randevu(hasta_id, personel_id, randevu_tarih, randevu_saat, randevudurum_id)" +
                                "values('" + hasta_id_menu + "','" + prsnl_id + "',(SELECT TO_DATE('" + Tarih_DTP.Text + "', 'dd/mm/yyyy') FROM dual), '" + maskedTextBox1.Text + "', '1')", con.baglanti());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu Oluşturuldu.");
                
                
            }
        }

        public void randevu_tarihsaat_sorgula()
        {
            //DOKTOR_CB DEĞİŞTİKTEN SONRA BUTONLAR YEŞİL RENK OLUYOR.
            button1.Enabled = true; button1.BackColor = Color.LawnGreen;
            button2.Enabled = true; button2.BackColor = Color.LawnGreen;
            button3.Enabled = true; button3.BackColor = Color.LawnGreen;
            button4.Enabled = true; button4.BackColor = Color.LawnGreen;
            button5.Enabled = true; button5.BackColor = Color.LawnGreen;
            button6.Enabled = true; button6.BackColor = Color.LawnGreen;
            button7.Enabled = true; button7.BackColor = Color.LawnGreen;
            button8.Enabled = true; button8.BackColor = Color.LawnGreen;
            button9.Enabled = true; button9.BackColor = Color.LawnGreen;
            button10.Enabled = true; button10.BackColor = Color.LawnGreen;
            button11.Enabled = true; button11.BackColor = Color.LawnGreen;
            button12.Enabled = true; button12.BackColor = Color.LawnGreen;
            button13.Enabled = true; button13.BackColor = Color.LawnGreen;
            button14.Enabled = true; button14.BackColor = Color.LawnGreen;
            button15.Enabled = true; button15.BackColor = Color.LawnGreen;
            button16.Enabled = true; button16.BackColor = Color.LawnGreen;
            button17.Enabled = true; button17.BackColor = Color.LawnGreen;
            button18.Enabled = true; button18.BackColor = Color.LawnGreen;
            button19.Enabled = true; button19.BackColor = Color.LawnGreen;
            button20.Enabled = true; button20.BackColor = Color.LawnGreen;

            bilgi_sorgula();
            cmd = new OracleCommand("select randevu_saat, randevu_tarih from randevu where personel_id='" + prsnl_id + "'", con.baglanti());
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {//DOKTORUN RANDEVU SAATİ DOLU MU DİYE KONTROL EDİYOR.

                if (dr["randevu_saat"].Equals(button1.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button1.Enabled = false; button1.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button2.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button2.Enabled = false; button2.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button3.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button3.Enabled = false; button3.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button4.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button4.Enabled = false; button4.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button5.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button5.Enabled = false; button5.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button6.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button6.Enabled = false; button6.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button7.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button7.Enabled = false; button7.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button8.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button8.Enabled = false; button8.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button9.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button9.Enabled = false; button9.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button10.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button10.Enabled = false; button10.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button11.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button11.Enabled = false; button11.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button12.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button12.Enabled = false; button12.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button13.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button13.Enabled = false; button13.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button14.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button14.Enabled = false; button14.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button15.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button15.Enabled = false; button15.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button16.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button16.Enabled = false; button16.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button17.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button17.Enabled = false; button17.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button18.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button18.Enabled = false; button18.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button19.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button19.Enabled = false; button19.BackColor = Color.Red; }
                if (dr["randevu_saat"].Equals(button20.Text) && dr["randevu_tarih"].Equals(Tarih_DTP.Value.Date)) { button20.Enabled = false; button20.BackColor = Color.Red; }
            }
        }
        
        public Hasta_menu()
        {
            InitializeComponent();
        }
        public void bilgi_sorgula()
        {

            cmd = new OracleCommand("select * from genel_bilgi where id in(select genelbilgi_id from personel where id in(select personel_id from kisibrans where brans_id='" + klinik_id + "'))", con.baglanti());
            dr = cmd.ExecuteReader();//Brans_id'si klinik_id'ye eşit olan personelid'yi kisibrans tablosundan çekiyor. Çektiği bu veri ile personel'i buluyor ve o personelin genelbilgi_id'sini çekiyor. çektiği bu veriyi de genelbilgi tablosunda bularak ad,soyad vb. bilgilerini çekiyyor.
            while (dr.Read())
            {
                isim = dr["ad"].ToString();
                isim += " " + dr["soyad"].ToString(); //bu branştaki doktorların ad ve soyadını çekiyor
                if (isim == Doktor_CB.Text) // çekilen ad soyad DoktorCB'de yazılı olana eşitse eğer bunun id'sini alıyor.
                {
                    gnlblg_id = Convert.ToInt32(dr["id"].ToString());
                    doktor_isim = isim;
                }
            }

            cmd = new OracleCommand("select * from personel where personel.genelbilgi_id= '" + gnlblg_id + "'", con.baglanti());
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                prsnl_id = Convert.ToInt32(dr["id"].ToString()); //üstte genelbilgi.id'si personel.genelbilgi_id'ye eşit olan personelin id'si alınıyor.
            }
        }

        private void Hasta_menu_Load(object sender, EventArgs e)
        {

            con.baglanti();
            cmd = new OracleCommand("SELECT * FROM BRANS WHERE brans.personeltur_id=2", con.baglanti());
            dr = cmd.ExecuteReader();   //randevu oluştur sekmesi için brans bilgilerini getiriyor.
            while (dr.Read())
            {
                Klinik_CB.Items.Add(dr["tanim"]);
            }


            TC_TB.Text = TC_verisi;
            hasta_sorgu_güncelleme();
            recete_Pnl.Visible = false;


        }

        private void Doktor_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevu_tarihsaat_sorgula();
        }

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string iletisim_id, tür, bilgi, adres_id, il, ilce, adres;
                string sql = ("update genel_bilgi set ad='" + Ad_TB.Text + "', soyad='" + Soyad_TB.Text + "', dogum=(SELECT TO_DATE('" + Dogum_DTP.Text + "', 'dd/mm/yyyy') FROM dual), cinsiyet='" + Cinsiyet_CB.Text + "', kan_grubu='" + Kan_CB.Text + "', parola='"+Parola_TB.Text+"' where genel_bilgi.tc='" + TC_TB.Text + "'");
                cmd = new OracleCommand(sql, con.baglanti());
                cmd.ExecuteNonQuery();

                iletisim_id = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
                bilgi = dataGridView2.CurrentRow.Cells["bilgi"].Value.ToString();
                tür = dataGridView2.CurrentRow.Cells["tur"].Value.ToString();

                adres_id = dataGridView3.CurrentRow.Cells["id2"].Value.ToString();
                il = dataGridView3.CurrentRow.Cells["il"].Value.ToString();
                ilce = dataGridView3.CurrentRow.Cells["ilce"].Value.ToString();
                adres = dataGridView3.CurrentRow.Cells["adres"].Value.ToString();

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

        private void Tarih_DTP_ValueChanged(object sender, EventArgs e)
        {
            randevu_tarihsaat_sorgula();
        }


//-------------------HASTAMENU RANDEVULARIM TAB--------------------------
        private void Randevular_DGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            randevuid = Randevular_DGW.CurrentRow.Cells["Id"].Value.ToString();
            randevuID_TB.Text = randevuid;
        }

        private void aktifRandevu_btn_Click(object sender, EventArgs e)
        {
            Randevular_DGW.Columns.Clear();
            ds.Tables.Clear();  //DatagridView Temizlenmesi için bu komut kullanılıyor.
            Randevular_DGW.Refresh();

            cmd = new OracleCommand("select * from randevu where randevu.hasta_id = '" + hasta_id_menu + "' and randevu.randevudurum_id= '1'", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            Randevular_DGW.DataSource = ds.Tables[0];
            recete_Pnl.Visible = false;
        }

        private void gecmisRandevu_btn_Click(object sender, EventArgs e)
        {
            Randevular_DGW.Columns.Clear();
            ds.Tables.Clear();          //DatagridView Temizlenmesi için bu komut kullanılıyor.
            Randevular_DGW.Refresh();

            cmd = new OracleCommand("select * from randevu where randevu.hasta_id = '" + hasta_id_menu + "' and randevu.randevudurum_id= '2'", con.baglanti());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            Randevular_DGW.DataSource = ds.Tables[0];
            recete_Pnl.Visible = false;
        }

        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Bu randevu silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {

                cmd = new OracleCommand("delete from randevu where randevu.id='" + Convert.ToInt32(randevuid) + "'", con.baglanti());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla silinmiştir.");

                Randevular_DGW.Columns.Clear();
                ds.Tables.Clear();          //RANDEVU SİLİNİNCE DATAGRİDVİEW VERİLERİNİ VE TABLOYU TEMİZLEYİP REFRESH EDİP TEKRAR VERİ EKLENMEYE HAZIR HALE GETİRİYOR.
                Randevular_DGW.Refresh();

                cmd = new OracleCommand("select * from randevu where randevu.hasta_id='" + hasta_id_menu + "' AND  randevu.randevudurum_id='1' ", con.baglanti());
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                Randevular_DGW.DataSource = ds.Tables[0];


            }
        }
        //-------------------HASTAMENU RANDEVULARIM TAB--------------------------


        //------------- REÇETE GETİR BAŞ------------
        private void receteGetir_btn_Click(object sender, EventArgs e)
        {
            Ilac_ListBox.Items.Clear();
            randevuID_TB.Text = Randevular_DGW.CurrentRow.Cells[0].Value.ToString();//Seçili satırdaki randevu id TB atandı.
            
            cmd = new OracleCommand("select * from recete where recete.randevu_id='" + randevuID_TB.Text + "'", con.baglanti());
            dr = cmd.ExecuteReader();//reçete tablosunda seçilmiş randevuid'ye sahip olan veri okundu.
            if (dr.Read())
            {
                //TARİH, SAAT, TANI, RECETE BAŞ
                tarih_datetmp.Text = Randevular_DGW.CurrentRow.Cells[3].Value.ToString();
                saat_TB.Text = Randevular_DGW.CurrentRow.Cells[4].Value.ToString();//Eğer okunduysa bu veriler TB'lere atandı.
                Tanı_RTB.Text = dr[1].ToString();// recete tablosunun 1. indexi tanı verisi tutuyor.
                Recete_RTB.Text = dr[2].ToString();// recete tablosunun 2. inexi recete açıklama verisi tutuyor.
                //TARİH, SAAT, TANI, RECETE SON

                //DOKTOR AD, KLİNİK AD BAŞ
                cmd = new OracleCommand("select * from personel where personel.id='" + Randevular_DGW.CurrentRow.Cells[2].Value.ToString() + "' ", con.baglanti());
                dr2 = cmd.ExecuteReader();
                if (dr2.Read())
                {
                    //KLİNİK AD BAŞ
                    cmd = new OracleCommand("select * from kisibrans where kisibrans.personel_id='" + dr2[0].ToString() + "'", con.baglanti());
                    dr3 = cmd.ExecuteReader();
                    dr3.Read();
                    cmd = new OracleCommand("select * from brans where brans.id='" + dr3[2].ToString() + "'", con.baglanti());
                    dr3 = cmd.ExecuteReader();
                    dr3.Read();
                    klinikAd_TB.Text = dr3[1].ToString();
                    //KLİNİK AD SON


                    //DOKTOR AD BAŞ
                    cmd = new OracleCommand("select * from genel_bilgi where genel_bilgi.id='" + dr2[1].ToString() + "'", con.baglanti());
                    dr3 = cmd.ExecuteReader();
                    dr3.Read();
                    doktorAd_TB.Text = dr3[1].ToString() + " " + dr3[2].ToString();
                    //DOKTOR AD SON
                }
                //DOKTOR AD, KLİNİK AD SON



                //İLAC BAS
                cmd = new OracleCommand("select * from receteilac where receteilac.recete_id='" + dr[0].ToString() + "'", con.baglanti());
                dr = cmd.ExecuteReader();//İlaçları da yazdırabilmek için reçeteilac tablosundaki receteid bizim receteid'mize eşit mi kontol ediyoruz.
                while (dr.Read())//bir reçetede birden fazla ilaç olabileceği için receteid birçok satırda aynı olabilir.
                {
                    cmd = new OracleCommand("select * from ilac where ilac.id='" + dr[2].ToString() + "'", con.baglanti());
                    dr2 = cmd.ExecuteReader();//while her okunduğunda ilac tablosunda id'ye göre (dr[2].tostring== recete ilac tablosundaki 2. index olan ilac_id bilgisini tutar.) karşılaştırma yapar.
                    if (dr2.Read()) //2. bir datareader kullanıyorum çünkü aynı datareader'ı kullansam while'a bir daha girmiyor sadece bir ilaç yazabiliyorum.
                    {
                        Ilac_ListBox.Items.Add(dr2[1].ToString());//ilac tablosunan okunan verinin 1. indexi yani tanim bilgisini alıp listbox'a ekliyoruz.
                    }
                }
                //İLAC SON
                recete_Pnl.Visible = true; //eğer her şey tamamlandıysa paneli açıyorum.
            }
            else
            {
                MessageBox.Show("Randevunun reçetesi yok. Lütfen tamamlanmış randevuları seçiniz.");
            }
        }

        //------------- REÇETE GETİR SON------------




        //BUTONLARA TIKLAYINCA MASKEDTEXTBOX'A YAZDIRIYOR.
        private void button1_Click(object sender, EventArgs e) { maskedTextBox1.Text = button1.Text; }
        private void button2_Click(object sender, EventArgs e) { maskedTextBox1.Text = button2.Text; }
        private void button3_Click(object sender, EventArgs e) { maskedTextBox1.Text = button3.Text; }
        private void button4_Click(object sender, EventArgs e) { maskedTextBox1.Text = button4.Text; }
        private void button5_Click(object sender, EventArgs e) { maskedTextBox1.Text = button5.Text; }
        private void button6_Click(object sender, EventArgs e) { maskedTextBox1.Text = button6.Text; }
        private void button7_Click(object sender, EventArgs e) { maskedTextBox1.Text = button7.Text; }
        private void button8_Click(object sender, EventArgs e) { maskedTextBox1.Text = button8.Text; }
        private void button9_Click(object sender, EventArgs e) { maskedTextBox1.Text = button9.Text; }
        private void button10_Click(object sender, EventArgs e) { maskedTextBox1.Text = button10.Text; }
        private void button11_Click(object sender, EventArgs e) { maskedTextBox1.Text = button11.Text; }
        private void button12_Click(object sender, EventArgs e) { maskedTextBox1.Text = button12.Text; }
        private void button13_Click(object sender, EventArgs e) { maskedTextBox1.Text = button13.Text; }
        private void button14_Click(object sender, EventArgs e) { maskedTextBox1.Text = button14.Text; }
        private void button15_Click(object sender, EventArgs e) { maskedTextBox1.Text = button15.Text; }
        private void button16_Click(object sender, EventArgs e) { maskedTextBox1.Text = button16.Text; }
        private void button17_Click(object sender, EventArgs e) { maskedTextBox1.Text = button17.Text; }
        private void button18_Click(object sender, EventArgs e) { maskedTextBox1.Text = button18.Text; }
        private void button19_Click(object sender, EventArgs e) { maskedTextBox1.Text = button19.Text; }
        private void button20_Click(object sender, EventArgs e) { maskedTextBox1.Text = button20.Text; }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_menu = new Ana_Menu();
            ana_menu.Show();
            this.Close();
        }
    }
}
