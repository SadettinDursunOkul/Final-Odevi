using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadettin_Dursun_Görsel_Programlama_2_Vize
{
    public partial class Yolcu : Form
    {
        private string _koltukNo;

        public Yolcu(string koltukNo)
        {
            InitializeComponent();
            _koltukNo = koltukNo;
        }
        UcakEntities db = new UcakEntities();
        private void Yolcu_Load(object sender, EventArgs e)
        {
            label8.Text = _koltukNo;
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            TBL_YOLCU yolcu = new TBL_YOLCU();
            yolcu.İsim = txtAd.Text;
            yolcu.Yas = txtYaş.Text;
            yolcu.Cinsiyet = txtCinsiyet.Text;
            yolcu.Yaşlı_Mı = txtYaşlı.Text;
            yolcu.Engelli_Mi = txtEngelli.Text;
            yolcu.Koltuk_No = label8.Text;
            db.TBL_YOLCU.Add(yolcu);
            db.SaveChanges();
            MessageBox.Show("Tamamdır");
        }

        
    }
}
