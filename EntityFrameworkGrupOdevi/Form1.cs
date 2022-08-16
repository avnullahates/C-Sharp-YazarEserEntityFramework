using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkGrupOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        YazarEserDBEntities db = new YazarEserDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            TableLoad();
        }


        private void cmbYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yazarId = cmbYazarlar.SelectedIndex + 1;

            var listeEserler = db.Eserlers.Where(x => x.Yazarlar.Id == yazarId).ToList();
            lstEserler.DataSource = listeEserler;

        }

        private void btnEkleYazarlar_Click(object sender, EventArgs e)
        {
            if (txtTamAd.Text.Trim() == "")
            {
                MessageBox.Show("Bu alan birakilamaz. Lutfen Doldurun!");
            }
            else
            {
                Yazarlar yeniYazar = new Yazarlar();
                yeniYazar.TamAd = txtTamAd.Text;
                db.Yazarlars.Add(yeniYazar);
                db.SaveChanges();

                TableLoad();
                TextTemizle();
            }

        }



        private void btnEkleEserler_Click(object sender, EventArgs e)
        {

            if (txtEserBaslik.Text.Trim() == "" || txtEserIcerik.Text.Trim() == "")
            {
                MessageBox.Show("Eser Basligi ve Eser Icerigi bos birakilamaz. Lutfen Doldurun!");
            }
            else
            {
                var yazarlar = cmbYazar.SelectedIndex + 1;
                Eserler yeniEser = new Eserler();

                yeniEser.Baslik = txtEserBaslik.Text;
                yeniEser.Icerik = txtEserIcerik.Text;
                yeniEser.YazarId = yazarlar;
                db.Eserlers.Add(yeniEser);

                lstEserPanelEserler.DataSource = db.Eserlers.Select(x => x.Id == yazarlar).ToList();

                db.SaveChanges();

                TableLoad();
                TextTemizle();
            }
        }

        private void cmbYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yazarId = cmbYazar.SelectedIndex + 1;

            var listeEserler = db.Eserlers.Where(x => x.Yazarlar.Id == yazarId).ToList();
            lstEserPanelEserler.DataSource = listeEserler;
        }

        private void lstEserler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Icerik = lstEserler.SelectedItem.ToString();
            txtEser.Text = db.Eserlers.Where(x => x.Baslik == Icerik).Select(x => x.Icerik).FirstOrDefault();
        }

        private void btnIptalYazarlar_Click(object sender, EventArgs e)
        {
            TextTemizle();
        }


        private void btnIptalEserler_Click(object sender, EventArgs e)
        {
            TextTemizle();
        }


        private void TextTemizle()
        {
            txtTamAd.Text = "";
            txtEserBaslik.Text = "";
            txtEserIcerik.Text = "";
        }

        private void TableLoad()
        {
            lstYazarlar.DataSource = db.Yazarlars.Select(x => x.TamAd).ToList();
            var listeYazarlar = db.Yazarlars.Select(x => x.TamAd).ToList();
            cmbYazarlar.DataSource = listeYazarlar;
            cmbYazar.DataSource = listeYazarlar;

        }

        
    }
}
