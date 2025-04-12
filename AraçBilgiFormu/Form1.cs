using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçBilgiFormu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string marka = txtmarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapi = txtKapıSayısı.Text;
            string pencere = txtPencereSayısı.Text;
            string yakit = txtYakıt.Text;

            string mesaj = $"🚘 Marka: {marka}\n" +
                           $"📅 Model: {model}\n" +
                           $"🎨 Renk: {renk}\n" +
                           $"🚪 Kapı Sayısı: {kapi}\n" +
                           $"🪟 Pencere Sayısı: {pencere}\n" +
                           $"⛽ 100 km’de Yaktığı Yakıt: {yakit} Litre";

            MessageBox.Show(mesaj, "Araç Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
