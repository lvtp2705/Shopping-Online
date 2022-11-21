using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            //dataGridView1.DataSource = dt;
            dt.Columns.Add("Image", typeof(string)); // string not int
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));


            // adidas
            dt.Rows.Add("01", "Adidas", "Sneaker Adidas Ultraboost Dna Guard Core Black", "2900000");
            dt.Rows.Add("02", "Adidas", "Sneaker Adidas 4dfwd Pulse Black Sonic", "1900000");
            dt.Rows.Add("03", "Adidas", "Sneaker Adidas Alphabounce+ 3.0 Cloud White", "950000");
            dt.Rows.Add("04", "Adidas", "Sneaker Adidas Ultraboost 1.0 Dna Solar Yello", " 1450000");
            dt.Rows.Add("05", "Adidas", "Sneaker Adidas Ultraboost 22 White Solar Yellow", "2100000");
            dt.Rows.Add("06", "Adidas", "Sneaker Adidas Vs Pace Tech Indigo", "1450000");
            dt.Rows.Add("07", "Adidas", "Sneakers Adidas X9000l4 V2 Cold.Rdy Orbit Green", "2500000");
            dt.Rows.Add("08", "Adidas", "Sneaker Adidas Stansmith Mule Green Classic", "1290000");
            dt.Rows.Add("09", "Adidas", "Sneaker Adidas Stansmith Vintage Navy", "1590000");
            dt.Rows.Add("10", "Adidas", "Sneaker Adidas Adizero Boston 10 Rose Tone", "1950000");

            dt.Rows.Add("11", "Nike", "Nike Air Force 1 Celestine Blue", " 2650000");
            dt.Rows.Add("12", "Nike", "Nike Air Force Shadow Light Soft Pink", "1850000");
            dt.Rows.Add("13", "Nike", "Nike Air Zoom Pegasus 38 W Black White", "1500000");
            dt.Rows.Add("14", "Nike", "Nike Air Zoom Pegasus 39 Siren Red", "1450000");
            dt.Rows.Add("15", "Nike", "Nike Air Max Alpha Tr 3 Core Black", "1100000");
            dt.Rows.Add("16", "Nike", "Nike Air Zoom Pegasus 39 Cargo Khaki", " 1750000");
            dt.Rows.Add("17", "Nike", "Nike Court Vision Low White", " 2100000");
            dt.Rows.Add("18", "Nike", "Nike Court Vision Low Core Black ", "1500000");
            dt.Rows.Add("19", "Nike", "Nike Air Zoom Pegasus 39 Cargo Khaki", "2250000");
            dt.Rows.Add("20", "Nike", "Nike Precision 4 Black Gold", "2800000");

            dt.Rows.Add("21", "MLB", "MLB Big Ball Chunky A New York Yankees White Gum", "1450000");
            dt.Rows.Add("22", "MLB", "MLB Bigball Chunky A La Dodgers ", "1900000");
            dt.Rows.Add("23", "MLB", "MLB Bigball Chunky New York Yankees Triple Black", "2250000");
            dt.Rows.Add("24", "MLB", "MLB Chunky High New York Yankees", "2100000");
            dt.Rows.Add("25", "MLB", "MLB Playball Mule Monogram Ny White", "1700000");
            dt.Rows.Add("26", "MLB", "MLB Playball Origin Mule New York Yankees White", "1450500");
            dt.Rows.Add("27", "MLB", "MLB Big Ball Chunky A 32shcd111 50i Nyy Block", "195000");
            dt.Rows.Add("28", "MLB", "MLB Bigball Chunky New York Yankees Triple Black", " 1700000");
            dt.Rows.Add("29", "MLB", "MLB Chunky Liner New York Yankess Off White", "2900000");
            dt.Rows.Add("30", "MLB", "MLB Playball Origins New York Yankees", " 2100000");


            dt.Rows.Add("31", "Jordan", "Nike Air Jordan 1 Mid ‘Olive", "2100000");
            dt.Rows.Add("32", "Jordan", "Nike Air Jordan 1 Mid Smoke Grey", "1900000");
            dt.Rows.Add("33", "Jordan", "Nike Jordan 1 High Comfort Chile Red", "2500000");
            dt.Rows.Add("34", "Jordan", "Nike Jordan 1 Mid Amory Navy", "1600000");
            dt.Rows.Add("35", "Jordan", "Nike Jordan 1 Mid Gs Signal Blue", "2650000");
            dt.Rows.Add("36", "Jordan", "Nike Jordan 1 Mid W Usa", " 1900000");
            dt.Rows.Add("37", "Jordan", "Nike Air Jordan 1 Gs Tie Dye", " 2500000");
            dt.Rows.Add("38", "Jordan", "Nike Air Jordan 1 Low Grey Navy", "2500000");
            dt.Rows.Add("39", "Jordan", "Nike Air Jordan 1 Mid Cream Grey", "2250000");
            dt.Rows.Add("40", "Jordan", "Nike Air Jordan 1 Mid Schematic", " 2500000");

            dt.Rows.Add("41", "VANS", "VANS X MOCA BRENNA YOUNGBLOOD", "1790000");
            dt.Rows.Add("42", "VANS", "VANS CHECKERBOARD SLIP-ON", " 1900000");
            dt.Rows.Add("43", "VANS", "VANS CLASSIC SK8-HI ", " 2000000");
            dt.Rows.Add("44", "VANS", "VANS FLAME SLIP-ON", "1900000");
            dt.Rows.Add("45", "VANS", "VANS OLD SKOOL CLASSIC BLACK", "1250000");
            dt.Rows.Add("46", "VANS", "VANS OLD SKOOL CLASSIC", " 1250000");
            dt.Rows.Add("47", "VANS", "VANS OLD SKOOL VARSITY CANVAS", "1750000");
            dt.Rows.Add("48", "VANS", "VANS CANVAS OLD SKOOL CLASSIC TRUE WHITE", " 1900000");
            dt.Rows.Add("49", "VANS", "VANS DALLAS CLAYTON AUTHENTIC RAINBOW TRUE WHITE", "1900000");
            dt.Rows.Add("50", "VANS", "VANS OLD SKOOL CLASSIC NAVY", "1900000");

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category ad = new Category(dt, "Adidas"); // truyền data zô
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }
        private void nikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category ad = new Category(dt, "Nike"); // truyền data zô
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }
        private void mLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category ad = new Category(dt, "MLB"); // truyền data zô
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void vansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category ad = new Category(dt, "VANS"); // truyền data zô
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Category ad = new Category(dt, textBox1.Text);
                this.Hide();
                ad.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category ad = new Category(dt, textBox1.Text);
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cart ct = new Cart();
            this.Hide();
            ct.ShowDialog();
            this.Show();
        }
    }

}

