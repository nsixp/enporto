using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NparkieApp
{
    public partial class Home : Form
    {
        private SqlCommand scmd;
        private DataSet ds;
        private SqlDataAdapter sda;

        double lm, lk, lamaParkir, lp, hp, hargaParkir, tb, kembalian;

        KoneksiDB Konn = new(); 

        void Bersihkan()
        {
            NoKend.Clear();
            JamMas.Clear();
            JamKel.Clear();
            LamPar.Clear();
            HarPar.Clear();
            TotBay.Clear();
            Kemb.Clear();
        }

        public Home()
        {
            InitializeComponent();
        }

        void ListKendaraan()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                scmd = new SqlCommand("Select * from TBL_KENDARAAN", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(scmd);
                sda.Fill(ds, "TBL_KENDARAAN");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_KENDARAAN";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LamPar.Enabled = false;
            HarPar.Enabled = false;
            Kemb.Enabled = false;
            JenKend.Items.Add("Mobil");
            JenKend.Items.Add("Motor");
            JenKend.SelectedIndex = 0;

            ListKendaraan();
            Bersihkan();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new();
            lg.Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void exiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NPARKIE adalah sebuah aplikasi yang dapat mendata kendaraan yang terparkir disuatu tempat dan dapat menghitung berapa jumlah uang yang dikeluarkan untuk membayar parkir, sehingga dapat memudahkan juru parkir dalam mengelola kendaraan disebuah tempat parkir."
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + "Cara menggunakan aplikasi :"
                + Environment.NewLine
                + Environment.NewLine
             + "1. Login/Masuk menggunakan username dan password yang telah dibuat (apabila lupa atau ingin mengatur ulang, pengguna dapat melihat dan mengedit pada kode program aplikasi)."
                + Environment.NewLine
                + Environment.NewLine
             + "2. Masukkan data kendaraan yang terpakir dengan benar dan klik PROSES untuk menampilkannya pada tabel disamping."
                + Environment.NewLine
                + Environment.NewLine
             + "3. Klik NEW pada bagian MENU untuk mengosongkan form dan mengisi data kendaraan yang baru."
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
             + "© Copyright by Naufal Itmam Labibi 2023 All Right Reserved, Indonesia."
             );
        }

        private void HitungBtn_Click(object sender, EventArgs e)
        {
            if (NoKend.Text.Trim() == "" || JamMas.Text.Trim() == "" || JamKel.Text.Trim() == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!");
            }
            else
            {
                // perhitungan lama parkir
                lk = double.Parse(JamKel.Text);
                lm = double.Parse(JamMas.Text);
                lamaParkir = lk - lm;
                LamPar.Text = lamaParkir + "";

                // perhitungan harga parkir
                lp = double.Parse(LamPar.Text);
                hargaParkir = lp * 16;
                HarPar.Text = hargaParkir + "";
            }
        }

        private void ProsesBtn_Click(object sender, EventArgs e)
        {
            if (NoKend.Text.Trim() == "" || JamMas.Text.Trim() == "" || JamKel.Text.Trim() == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!");
            }
            else if(TotBay.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan uang pembayaran terlebih dahulu!");
            }
            else
            {
                hp = double.Parse(HarPar.Text);
                tb = double.Parse(TotBay.Text);

                if(tb < hp)
                {
                    MessageBox.Show("Mohon maaf pembayaran anda kurang.");
                }
                else
                {
                    SqlConnection conn = Konn.GetConn();
                    try
                    {
                        tb = double.Parse(TotBay.Text);
                        kembalian = tb - hargaParkir;
                        Kemb.Text = kembalian + "";

                        scmd = new SqlCommand("insert into TBL_KENDARAAN values ('" + NoKend.Text + "', '" + JenKend.Text + "', '" + JamMas.Text + "', '" + JamKel.Text + "', '" + LamPar.Text + "', '" + HarPar.Text + "', '" + TotBay.Text + "', '" + Kemb.Text + "')", conn);
                        conn.Open();
                        scmd.ExecuteNonQuery();
                        ListKendaraan();
                    }
                    catch (Exception X)
                    {
                        MessageBox.Show(X.ToString());
                    }
                }
            }
        }
    }
}
