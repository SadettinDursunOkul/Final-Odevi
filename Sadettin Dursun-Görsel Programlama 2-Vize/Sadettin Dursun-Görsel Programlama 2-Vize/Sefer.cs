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
    public partial class Sefer : Form
    {
        public Sefer()
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

        private void Sefer_Load(object sender, EventArgs e)
        {
            dataGridViewSefer.DataSource = (from x in db.TBL_SEFERLER
                                            join u in db.TBL_UCAK on x.Ucak_Id equals u.Ucak_Id
                                            select new
                                            {
                                                x.Sefer_Id,
                                                x.Kalkış_Yer,
                                                x.Varış_Yer,
                                                x.Kalkış_Tarih,
                                                x.Varış_Tarih,
                                                Ucak_Ad = u.Ucak_Ad, 
                                                x.Ücret,
                                                x.Sefer_Ad
                                            }).ToList();

            cmbUçak.DisplayMember = "Ucak_Ad";
            cmbUçak.ValueMember = "Ucak_Id";

            cmbUçak.DataSource = db.TBL_UCAK.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBL_SEFERLER sefer = new TBL_SEFERLER();
            sefer.Kalkış_Yer = cmbKalkışYer.Text;
            sefer.Varış_Yer = cmbVarışYer.Text;
            sefer.Kalkış_Tarih = kalkışZaman.Value;
            sefer.Varış_Tarih = varışZaman.Value;
            sefer.Ucak_Id = int.Parse(cmbUçak.SelectedValue.ToString());
            sefer.Sefer_Ad = txtSeferAd.Text;
            sefer.Ücret = txtÜcret.Text;
            db.TBL_SEFERLER.Add(sefer);
            db.SaveChanges();
            MessageBox.Show("Sefer Eklendi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var sefer = db.TBL_SEFERLER.Find(x);
            sefer.Kalkış_Yer = cmbKalkışYer.Text;
            sefer.Varış_Yer = cmbVarışYer.Text;
            sefer.Kalkış_Tarih = kalkışZaman.Value;
            sefer.Varış_Tarih = varışZaman.Value;
            sefer.Ucak_Id = int.Parse(cmbUçak.SelectedValue.ToString());
            sefer.Sefer_Ad = txtSeferAd.Text;
            sefer.Ücret = txtÜcret.Text;
            db.SaveChanges();
            MessageBox.Show("Sefer Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var sefer = db.TBL_SEFERLER.Find(x);
            db.TBL_SEFERLER.Remove(sefer);
            db.SaveChanges();
            MessageBox.Show("Sefer Silindi");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewSefer.DataSource = (from x in db.TBL_SEFERLER
                                            join u in db.TBL_UCAK on x.Ucak_Id equals u.Ucak_Id
                                            select new
                                            {
                                                x.Sefer_Id,
                                                x.Kalkış_Yer,
                                                x.Varış_Yer,
                                                x.Kalkış_Tarih,
                                                x.Varış_Tarih,
                                                Ucak_Ad = u.Ucak_Ad,
                                                x.Ücret,
                                                x.Sefer_Ad
                                            }).ToList();

            cmbUçak.DisplayMember = "Ucak_Ad";
            cmbUçak.ValueMember = "Ucak_Id";

            cmbUçak.DataSource = db.TBL_UCAK.ToList();
        }

        private void dataGridViewSefer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewSefer.SelectedCells[0].RowIndex;

            labelId.Text = dataGridViewSefer.Rows[selected].Cells[0].Value.ToString();
            cmbKalkışYer.Text = dataGridViewSefer.Rows[selected].Cells[1].Value.ToString();
            cmbVarışYer.Text = dataGridViewSefer.Rows[selected].Cells[2].Value.ToString();
            kalkışZaman.Text = dataGridViewSefer.Rows[selected].Cells[3].Value.ToString();
            varışZaman.Text = dataGridViewSefer.Rows[selected].Cells[4].Value.ToString();
            cmbUçak.SelectedIndex = cmbUçak.FindStringExact(dataGridViewSefer.Rows[selected].Cells[5].Value.ToString());
            txtÜcret.Text = dataGridViewSefer.Rows[selected].Cells[6].Value.ToString();
            txtSeferAd.Text = dataGridViewSefer.Rows[selected].Cells[7].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = dataGridViewSefer.Height;
            dataGridViewSefer.Height = dataGridViewSefer.RowCount * dataGridViewSefer.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridViewSefer.Width, dataGridViewSefer.Height);

            dataGridViewSefer.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewSefer.Width, dataGridViewSefer.Height));
            dataGridViewSefer.Height = height;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
