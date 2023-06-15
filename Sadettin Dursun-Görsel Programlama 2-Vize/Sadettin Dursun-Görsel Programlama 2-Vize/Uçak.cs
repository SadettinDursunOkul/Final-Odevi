using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadettin_Dursun_Görsel_Programlama_2_Vize
{
    public partial class Uçak : Form
    {
        public Uçak()
        {
            InitializeComponent();
        }

        UcakEntities db = new UcakEntities();

        Bitmap bmp;

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void Uçak_Load(object sender, EventArgs e)
        {
            dataGridViewUcak.DataSource = (from x in db.TBL_UCAK
                                          select new
                                          {
                                              x.Ucak_Id,
                                              x.Ucak_Ad,
                                              x.Koltuk_Sayısı,
                                          }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBL_UCAK ucak = new TBL_UCAK();
            ucak.Ucak_Ad = txtUcakAd.Text;
            ucak.Koltuk_Sayısı = int.Parse(txtKapasite.Text.ToString());
            db.TBL_UCAK.Add(ucak);
            db.SaveChanges();
            MessageBox.Show("Uçak Eklendi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ucak = db.TBL_UCAK.Find(x);
            ucak.Ucak_Ad = txtUcakAd.Text;
            ucak.Koltuk_Sayısı = int.Parse(txtKapasite.Text.ToString());
            db.SaveChanges();
            MessageBox.Show("Uçak Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ucak = db.TBL_UCAK.Find(x);
            db.TBL_UCAK.Remove(ucak);
            db.SaveChanges();
            MessageBox.Show("Uçak Silindi");
        }

        private void dataGridViewUcak_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewUcak.SelectedCells[0].RowIndex;

            txtId.Text = dataGridViewUcak.Rows[selected].Cells[0].Value.ToString();
            txtUcakAd.Text = dataGridViewUcak.Rows[selected].Cells[1].Value.ToString();
            txtKapasite.Text = dataGridViewUcak.Rows[selected].Cells[2].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewUcak.DataSource = (from x in db.TBL_UCAK
                                           select new
                                           {
                                               x.Ucak_Id,
                                               x.Ucak_Ad,
                                               x.Koltuk_Sayısı,
                                           }).ToList();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int height = dataGridViewUcak.Height;
            dataGridViewUcak.Height = dataGridViewUcak.RowCount * dataGridViewUcak.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridViewUcak.Width, dataGridViewUcak.Height);

            dataGridViewUcak.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewUcak.Width, dataGridViewUcak.Height));
            dataGridViewUcak.Height = height;

            printPreviewDialog1.ShowDialog();
        }
    }
}
