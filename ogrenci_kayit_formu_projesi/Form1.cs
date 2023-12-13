using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_kayit_formu_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 150);
            listView1.Columns.Add("ADI SOYADI", 200);
            listView1.Columns.Add("YAŞI", 50);
            listView1.Columns.Add("MEZUNİYETİ", 150);
            listView1.Columns.Add("CİNSİYETİ", 125);
            listView1.Columns.Add("DOĞUM YERİ", 125);
            listView1.Columns.Add("TELEFON NO", 130);
            listView1.Width = 950;

            string[] mezuniyet = { "İLKÖĞRETİM", "LİSE", "LİSANS", "YÜKSEK LİSANS" };
            comboBoxmezuniyet.Items.AddRange(mezuniyet);
            comboBoxmezuniyet.DropDownStyle = ComboBoxStyle.DropDownList;
            kayitsayisiyaz();

            
        }

        private void kayitsayisiyaz()
        {
            int kayitsayisi=listView1.Items.Count;
            labelkayitsayisi.Text = Convert.ToString(kayitsayisi);
        }

        private void radioButtonekle_Click(object sender, EventArgs e)
        {
            string tc = "", ad_soyad = "", yas = "", mezuniyet = "", cinsiyet = "", dogum_yeri = "", telefon = "";
            tc=textBoxtc.Text;
            ad_soyad=textBoxadsoyad.Text;
            yas=textBoxyas.Text;

            if (radioButtonkadin.Checked == true)
                cinsiyet = radioButtonkadin.Text;
            else
                cinsiyet=radioButtonerkek.Text;
            dogum_yeri = textBoxdogumyeri.Text;
            telefon=textBoxtelefonno.Text;

            string[] bilgiler = { tc, ad_soyad, yas, mezuniyet, cinsiyet, dogum_yeri, telefon, };
            ListViewItem ekle = new ListViewItem(bilgiler);
            listView1.Items.Add(ekle);


                


        }
    }
}
