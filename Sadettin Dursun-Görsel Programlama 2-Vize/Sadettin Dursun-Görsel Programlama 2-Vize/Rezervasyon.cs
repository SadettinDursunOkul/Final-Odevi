using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sadettin_Dursun_Görsel_Programlama_2_Vize
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        UcakEntities db = new UcakEntities();
        Bitmap bmp;
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        Bitmap memorying;
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            cmbSefer.DisplayMember = "Sefer_Ad";
            cmbSefer.ValueMember = "Sefer_Id";

            cmbSefer.DataSource = db.TBL_SEFERLER.ToList();
        }

        private string koltukNo;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                string koltukNo = btn.Text;
                // Yolcu formunu açın
                Yolcu fr = new Yolcu(koltukNo);
                fr.Show();
            }
        }
        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seferId = Convert.ToInt32(cmbSefer.SelectedValue);
            int uckId = (int)cmbSefer.SelectedValue;
            int koltukSayisi = db.TBL_UCAK.FirstOrDefault(x => x.Ucak_Id == uckId)?.Koltuk_Sayısı ?? 0;
            dataGridViewSeferler.DataSource = (from x in db.TBL_SEFERLER
                                               where x.Sefer_Id == seferId
                                               select new
                                               {
                                                   x.Kalkış_Yer,
                                                   x.Varış_Yer,
                                                   x.Kalkış_Tarih,
                                                   x.Varış_Tarih,
                                                   x.Ücret
                                               }).ToList();

            // Mevcut butonları temizle
            koltuklar.Controls.Clear();

            // Butonları yeniden oluştur
            int koltukGenisligi = 40;
            int koltukYuksekligi = 40;
            int koltukBosluk = 10;
            int siraSayisi = 10;
            char harf = 'A';
            int koltukNo = 1;
            for (int i = 0; i < koltukSayisi; i++)
            {
                Button btn = new Button();
                btn.Click += new EventHandler(btn_Click);
                koltuklar.Controls.Add(btn);
                btn.Name = $"{harf}{koltukNo}";
                btn.Text = $"{harf}{koltukNo}";
                btn.Width = koltukGenisligi;
                btn.Height = koltukYuksekligi;
                int sira = i / siraSayisi;
                int sutun = i % siraSayisi;
                btn.Top = sira * (koltukYuksekligi + koltukBosluk) + 20;
                btn.Left = sutun * (koltukGenisligi + koltukBosluk) + 20;
                btn.BackColor = Color.Green;
                koltuklar.Controls.Add(btn);
                koltukNo++;
                if (koltukNo > 5)
                {
                    koltukNo = 1;
                    harf++;
                }
            }
  
        }




        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBL_YOLCU
                                        select new
                                        {
                                            x.Yolcu_Id,
                                            x.İsim,
                                            x.Yas,
                                            x.Cinsiyet,
                                            x.Yaşlı_Mı,
                                            x.Koltuk_No
                                        }).ToList();

            // Koltukları renklendir
            foreach (Control control in koltuklar.Controls)
            {
                if (control is Button btn)
                {
                    var koltukNo = btn.Text;

                    // TBL_YOLCU tablosunda bu koltuk numarasıyla eşleşen bir kayıt var mı?
                    var yolcu = db.TBL_YOLCU.FirstOrDefault(y => y.Koltuk_No == koltukNo);

                    if (yolcu != null)
                    {
                        btn.BackColor = Color.Red; // Koltuk doluysa kırmızı yap
                    }
                    else
                    {
                        btn.BackColor = Color.Green; // Koltuk boşsa yeşil yap
                    }
                }

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(koltuklar.Width, koltuklar.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            koltuklar.DrawToBitmap(bmp, new Rectangle(0, 0, koltuklar.Width, koltuklar.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = dataGridViewSeferler.Height;
            dataGridViewSeferler.Height = dataGridViewSeferler.RowCount * dataGridViewSeferler.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridViewSeferler.Width, dataGridViewSeferler.Height);

            dataGridViewSeferler.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewSeferler.Width, dataGridViewSeferler.Height));
            dataGridViewSeferler.Height = height;

            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;

            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument Pd = new PrintDocument();

            Pd.PrintPage += this.printDocument1_PrintPage;
            ppd.Document = Pd;
            ppd.ShowDialog();
        }

       
    }
    }


