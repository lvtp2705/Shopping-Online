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
            dataGridView1.DataSource = dt;
            dt.Columns.Add("Image", typeof(string)); // string not int
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));


            // adidas
            dt.Rows.Add("01", "Adidas", "Sneaker Adidas Ultraboost Dna Guard Core Black", "2.900.000");
            dt.Rows.Add("02", "Adidas", "Sneaker Adidas 4dfwd Pulse Black Sonic", "1.900.000");
            dt.Rows.Add("03", "Adidas", "Sneaker Adidas Alphabounce+ 3.0 Cloud White", "950.000");
            dt.Rows.Add("04", "Adidas", "Sneaker Adidas Ultraboost 1.0 Dna Solar Yello", " 1.450.000");
            dt.Rows.Add("05", "Adidas", "Sneaker Adidas Ultraboost 22 White Solar Yellow", "2.100.000");
            dt.Rows.Add("06", "Adidas", "Sneaker Adidas Vs Pace Tech Indigo", "1.450,000");
            dt.Rows.Add("07", "Adidas", "Sneakers Adidas X9000l4 V2 Cold.Rdy Orbit Green", "2.500.000");
            dt.Rows.Add("08", "Adidas", "Sneaker Adidas Stansmith Mule Green Classic", "1.290.000");
            dt.Rows.Add("09", "Adidas", "Sneaker Adidas Stansmith Vintage Navy", "1.590.000");
            dt.Rows.Add("10", "Adidas", "Sneaker Adidas Adizero Boston 10 Rose Tone", "1.950.000");

            dt.Rows.Add("11", "Nike", "Nike Air Force 1 Celestine Blue", " 2.650.000");
            dt.Rows.Add("12", "Nike", "Nike Air Force Shadow Light Soft Pink", "1.850.000");
            dt.Rows.Add("13", "Nike", "Nike Air Zoom Pegasus 38 W Black White", "1.500.000");
            dt.Rows.Add("14", "Nike", "Nike Air Zoom Pegasus 39 Siren Red", "1.450.000");
            dt.Rows.Add("15", "Nike", "Nike Air Max Alpha Tr 3 Core Black", "1.100.000");
            dt.Rows.Add("16", "Nike", "Nike Air Zoom Pegasus 39 Cargo Khaki", " 1.750.000");
            dt.Rows.Add("17", "Nike", "Nike Court Vision Low White", " 2.100.000");
            dt.Rows.Add("18", "Nike", "Nike Court Vision Low Core Black ", " 1.500.000");
            dt.Rows.Add("19", "Nike", "Nike Air Zoom Pegasus 39 Cargo Khaki", " 2.250.000");
            dt.Rows.Add("20", "Nike", "Nike Precision 4 Black Gold", "2.800,000");

            dt.Rows.Add("21", "MLB", "Mlb Big Ball Chunky A New York Yankees White Gum", "1.450.000");
            dt.Rows.Add("22", "MLB", "Mlb Bigball Chunky A La Dodgers ", "1.900.000");
            dt.Rows.Add("23", "MLB", "Mlb Bigball Chunky New York Yankees Triple Black", "2.250.000");
            dt.Rows.Add("24", "MLB", "Mlb Chunky High New York Yankees", "2.100.000");
            dt.Rows.Add("25", "MLB", "Mlb Playball Mule Monogram Ny White", "1.700.000");
            dt.Rows.Add("26", "MLB", "Mlb Playball Origin Mule New York Yankees White", "1.450.500");
            dt.Rows.Add("27", "MLB", "Mlb Big Ball Chunky A 32shcd111 50i Nyy Block", "1.950.00");
            dt.Rows.Add("28", "MLB", "Mlb Bigball Chunky New York Yankees Triple Black", " 1.700.000");
            dt.Rows.Add("29", "MLB", "Mlb Chunky Liner New York Yankess Off White", "2.900.000");
            dt.Rows.Add("30", "MLB", "Mlb Playball Origins New York Yankees", " 2.100.000");


            dt.Rows.Add("31", "Jordan", "Nike Air Jordan 1 Mid ‘Olive", "2.100.000");
            dt.Rows.Add("32", "Jordan", "Nike Air Jordan 1 Mid Smoke Grey", "1.900.000");
            dt.Rows.Add("33", "Jordan", "Nike Jordan 1 High Comfort Chile Red", "2.500.000");
            dt.Rows.Add("34", "Jordan", "Nike Jordan 1 Mid Amory Navy", "1.600.000");
            dt.Rows.Add("35", "Jordan", "Nike Jordan 1 Mid Gs Signal Blue", "2.650.000");
            dt.Rows.Add("36", "Jordan", "Nike Jordan 1 Mid W Usa", " 1.900.000");
            dt.Rows.Add("37", "Jordan", "Nike Air Jordan 1 Gs Tie Dye", " 2.500.000");
            dt.Rows.Add("38", "Jordan", "Nike Air Jordan 1 Low Grey Navy", "2.500.000");
            dt.Rows.Add("39", "Jordan", "Nike Air Jordan 1 Mid Cream Grey", "2.250.000");
            dt.Rows.Add("40", "Jordan", "Nike Air Jordan 1 Mid Schematic", " 2.500.000");

            dt.Rows.Add("41", "VANS", "VANS X MOCA BRENNA YOUNGBLOOD", "1.790.000");
            dt.Rows.Add("42", "VANS", "VANS CHECKERBOARD SLIP-ON", " 1.900.000");
            dt.Rows.Add("43", "VANS", "VANS CLASSIC SK8-HI ", " 2.000.000");
            dt.Rows.Add("44", "VANS", "VANS FLAME SLIP-ON", "1.900.000");
            dt.Rows.Add("45", "VANS", "VANS OLD SKOOL CLASSIC BLACK", "1.250.000");
            dt.Rows.Add("46", "VANS", "VANS OLD SKOOL CLASSIC", " 1.250.000");
            dt.Rows.Add("47", "VANS", "VANS OLD SKOOL VARSITY CANVAS", "1.750.000");
            dt.Rows.Add("48", "VANS", "VANS CANVAS OLD SKOOL CLASSIC TRUE WHITE", " 1.900.000");
            dt.Rows.Add("49", "VANS", "VANS DALLAS CLAYTON AUTHENTIC RAINBOW TRUE WHITE", "1.900.000");
            dt.Rows.Add("50", "VANS", "VANS OLD SKOOL CLASSIC NAVY", "1.900.000");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Place Holder text...";
        }
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            foreach(DataRow x in dt.Rows)
            {
                x["Image"] = 0;
            }

            richTextBox1.Text = "";
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            
             richTextBox1.Text = "Place Holder text...";
             button1.Focus() ;
            

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void adidasToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Adidas ad = new Adidas(dt); // truyền data zô
                ad.ShowDialog();
                this.Show();

            }
        private void nikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Nike ni = new Nike(dt); // truyền data zô
             ni.ShowDialog();
             this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void dépToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

        private void button12_Click(object sender, EventArgs e)
            {

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Enter(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }

}

