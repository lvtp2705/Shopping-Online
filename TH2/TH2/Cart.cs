using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH2.Properties;

namespace TH2
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            LoadCart();
            LoadResult();

        }
        private void LoadResult()
        {
            int total = 0;
            int ship = 0;
            int tientra = 0;
            foreach (DataRow x in DBCart.Cart.Rows)
            {
                total += Convert.ToInt32(x["Price"]) * Convert.ToInt32(x["Quantity"]);
                ship += 30000;
            }
            tientra = ship + total;
            tientra_lb.Text = Convert.ToDecimal(tientra).ToString("C0");
            phiship_lb.Text = Convert.ToDecimal(ship).ToString("C0");
            tongtien_lb.Text = Convert.ToDecimal(total).ToString("C0");

        }
        private void LoadCart()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow ct in DBCart.Cart.Rows)
            {
                Panel pn = new Panel();
                PictureBox pc = new PictureBox();
                Label name = new Label();
                Label gia = new Label();
                Label total = new Label();
                NumericUpDown np = new NumericUpDown();

                np.Location = new Point(742, 30);
                np.Size = new Size(150, 26);
                np.Font = new Font("Microsoft Sans Serif", 18);
                np.Value = Convert.ToDecimal(ct["Quantity"].ToString());
                np.Tag = ct["Image"].ToString();
                np.ValueChanged += numericUpDown1_ValueChanged;

                Button bt = new Button();
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 0;
                bt.BackgroundImage = global::TH2.Properties.Resources.delete;
                bt.BackgroundImageLayout = ImageLayout.Zoom;
                bt.Location = new Point(1085, 17);
                bt.Size = new Size(72, 64);
                bt.Tag = ct["Image"].ToString();
                bt.Click += Delete_Cart;

                Initpc(pc, ct["Image"].ToString());
                Initname(name, ct["Name"].ToString());
                Initgia(gia, ct["Price"].ToString());
                Inittotal(total, ct["Price"].ToString(), np.Value);
                pn.Size = new Size(1170, 93);
                pn.Controls.Add(pc);
                pn.Controls.Add(name);
                pn.Controls.Add(gia);
                pn.Controls.Add(np);
                pn.Controls.Add(total);
                pn.Controls.Add(bt);
                flowLayoutPanel1.Controls.Add(pn);

            }
            LoadResult();
        }
        private void Initpc(PictureBox pc, string image)
        {
            pc.Size = new Size(150, 80);
            pc.Location = new Point(3, 3);
            pc.Image = (Image)Resources.ResourceManager.GetObject($"_{image}");
            pc.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Initname(Label name, string na)
        {
            name.Size = new Size(390, 80);
            name.Location = new Point(180, 3);
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Text = na;
            name.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            name.Text.ToUpper();
        }
        private void Initgia(Label gia, string na)
        {
            gia.Size = new Size(130, 80);
            gia.Location = new Point(590, 3);
            gia.TextAlign = ContentAlignment.MiddleLeft;
            gia.Text = Convert.ToDecimal(na).ToString("C0");
            gia.Font = new Font("Microsoft Sans Serif", 16);
        }
        private void Inittotal(Label total,string gia, decimal sl)
        {
            total.Size = new Size(150, 80);
            total.Location = new Point(930, 3);
            total.TextAlign = ContentAlignment.MiddleLeft;
            total.Text = Convert.ToDecimal(Convert.ToDecimal(gia) * sl).ToString("C0");
            total.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown np = sender as NumericUpDown;
            foreach(DataRow x in DBCart.Cart.Rows)
            {
                if(x["Image"].ToString() == np.Tag.ToString())
                {
                    x["Quantity"] = Convert.ToInt32(np.Value);
                }    
            }
            LoadCart();
        }
        private void Delete_Cart(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (DataRow x in DBCart.Cart.Rows)
            {
                if (x["Image"].ToString() == bt.Tag.ToString())
                {
                    DBCart.Cart.Rows.Remove(x);
                    break;
                }
            }
            LoadCart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
