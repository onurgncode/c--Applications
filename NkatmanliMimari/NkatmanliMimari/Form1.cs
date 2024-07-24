using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
namespace NkatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sil()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtsehir.Text = "";
            txtmaas.Text = "";
            txtgorev.Text = "";
            txtad.Focus();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = Convert.ToInt16( txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtgorev.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            txtid.Enabled = true;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt16(txtid.Text) ;
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = Convert.ToInt16(txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.LLPersonelGuncelle(ent);
            MessageBox.Show("Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt16(txtid.Text);
            LogicPersonel.LLPersonelSil(ent);
            MessageBox.Show("Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil();
        }
    }
}
