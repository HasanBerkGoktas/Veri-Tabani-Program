using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        VTContext veriler = new VTContext();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ogrenci yeni_ogr = new Ogrenci();
            yeni_ogr.Okulno = Int32.Parse(textBox1.Text);
            yeni_ogr.Ad = textBox2.Text;
            yeni_ogr.Soyad = textBox3.Text;

            veriler.ogrenciler.Add(yeni_ogr);
            veriler.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.ogrenciler.Load();
            dataGridView1.DataSource = veriler.ogrenciler.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    dataGridView1.Refresh();
                  veriler.SaveChanges();


            }
           

        }
    }
}