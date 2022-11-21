using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH2.Properties;

namespace TH2
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        // khởi tạo các biến.
        DataTable adidas { set; get; }
        string category { set; get; }

        
        
        // tạo constructor với data truyền vào
        public Category(DataTable _dt, string _category)
        {
            InitializeComponent();
            adidas = _dt;
            category = _category;
            //dataGridView1.DataSource = dt;
            if(DBCart.Cart.Columns.Count == 0)
            {
                DBCart.Cart.Columns.Add("Image", typeof(string)); // string not int
                DBCart.Cart.Columns.Add("Category", typeof(string));
                DBCart.Cart.Columns.Add("Name", typeof(string));
                DBCart.Cart.Columns.Add("Price", typeof(decimal));
                DBCart.Cart.Columns.Add("Quantity", typeof(int));
            }


        }
        private void Category_Load(object sender, EventArgs e)
        {
            AddProduct(category);
        }

        private void Initbutton(Button b, Point x, string image)
        {
            b.Location = x;
            b.Size = new Size(330, 190);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.BackColor = Color.Transparent;
            // tim hinh phu` hop..khong biet sao no co dau gach
            // switch cmnl cay vl
            ResourceManager rm = Resources.ResourceManager;
            Image img = (Image)rm.GetObject($"_{image}");
            b.BackgroundImage = img;
            b.Tag = image.ToString();
            b.FlatStyle = FlatStyle.Flat;
            b.Click += ShowProduct;
        }
        private void ShowProduct(object sender, EventArgs e)
        {
            Button b = sender as Button;
            numericUpDown1.Value = 1;
            foreach(DataRow x in adidas.Rows)
            {
                if(x["Image"].ToString() == b.Tag.ToString())
                {
                    show_pic.Image = (Image)Resources.ResourceManager.GetObject($"_{b.Tag.ToString()}");
                    show_pic.Tag = b.Tag;
                    name_txt.Text = x["Name"].ToString();
                    price_txt.Text = x.Field<decimal>("Price").ToString("C0");
                    show_pnl.Visible = true;
                    break;
                }    
            }    
        }

        private void InitContent(Label content, Button b, string name)
        {
            content.Location = new Point(b.Location.X, b.Location.Y + b.Height + 7);
            content.AutoSize = false;
            content.Width = b.Width;
            content.Font = new Font(new FontFamily("Microsoft Sans Serif"), 11);
            content.TextAlign = ContentAlignment.MiddleCenter;
            content.Text = name;
        }
        private void InitPrice(Label l, Button b, string price)
        {
            l.Location = new Point(b.Location.X, b.Location.Y + b.Height + 25);
            l.Width = b.Width;
            l.AutoSize = false;
            l.Font = new Font(new FontFamily("Microsoft Sans Serif"), 11, FontStyle.Bold);
            l.ForeColor = Color.Red;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = price;
        }
        private void Adidas_Load(object sender, EventArgs e)
        {
            AddProduct(category);

        }
        private void AddProduct(string cate)
        {
            adidas_pnl.Controls.Clear();
            Point locate = new Point(20, 42);
            int hang = 1;
            foreach (DataRow x in adidas.Rows)
            {
                if (x["Name"].ToString().ToUpper().Contains(cate.ToUpper()))
                {
                    Button b = new Button();
                    Label content = new Label();
                    Label price = new Label();

                    Initbutton(b, locate, x.Field<string>("Image"));
                    InitContent(content, b, x.Field<string>("Name"));
                    InitPrice(price, b, (x.Field<decimal>("Price")).ToString("C0"));
                    adidas_pnl.Controls.Add(b);
                    adidas_pnl.Controls.Add(content);
                    adidas_pnl.Controls.Add(price);
                    if (hang == 3) // da them 3 cai
                    {
                        hang = 1;
                        locate.X = 20;
                        locate.Y += 100 + b.Height;
                    }
                    else
                    {
                        hang += 1;
                        locate.X += 100 + b.Width;
                    }
                }



            }
        }



        private void adidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "Adidas";
            Adidas_Load(sender, e);
        }

        private void nikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "Nike";
            Adidas_Load(sender, e);
        }

        private void mLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "MLB";
            Adidas_Load(sender, e);
        }

        private void vansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "VANS";
            Adidas_Load(sender, e);
        }

        private void timkiemtheogia(decimal duoi, decimal tren, string cate)
        {
            adidas_pnl.Controls.Clear();
            Point locate = new Point(8, 42);
            int hang = 1;
            foreach (DataRow x in adidas.Rows)
            {
                if (x["Name"].ToString().Contains(cate) && Convert.ToDecimal(x["Price"]) < tren)
                {
                    if (Convert.ToDecimal(x["Price"]) < tren && Convert.ToDecimal(x["Price"]) > duoi)
                    {
                        Button b = new Button();
                        Label content = new Label();
                        Label price = new Label();

                        Initbutton(b, locate, x.Field<string>("Image"));
                        InitContent(content, b, x.Field<string>("Name"));
                        InitPrice(price, b, (x.Field<decimal>("Price")).ToString("C0"));
                        adidas_pnl.Controls.Add(b);
                        adidas_pnl.Controls.Add(content);
                        adidas_pnl.Controls.Add(price);
                        if (hang == 3) // da them 3 cai
                        {
                            hang = 1;
                            locate.X = 8;
                            locate.Y += 100 + b.Height;
                        }
                        else
                        {
                            hang += 1;
                            locate.X += 100 + b.Width;
                        }
                    }

                }



            }
        }
        private void muc1_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtheogia(0, 1000000, category);
        }

        private void muc2_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtheogia(1000000, 1500000, category);
        }

        private void muc3_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtheogia(1500000, 2000000, category);
        }

        private void muc4_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtheogia(2000000, 10000000, category);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            show_pnl.Visible = false;
        }

        private void addcart_Click(object sender, EventArgs e)
        {
            foreach(DataRow x in adidas.Rows)
            {
                if(x["Image"].ToString() == show_pic.Tag.ToString())
                {
                    bool exist = false;
                    foreach(DataRow s in DBCart.Cart.Rows)
                    {
                        if(s["Image"].ToString() == x["Image"].ToString())
                        {
                            exist = true;
                            DialogResult ok = MessageBox.Show("Sản phẩm đã được thêm trước đó\n Bạn có muốn cập nhật số lượng?", "", MessageBoxButtons.YesNo);
                            if(ok == DialogResult.Yes)
                            {                              
                                int sl = Convert.ToInt32(s["Quantity"].ToString()) + Convert.ToInt32(numericUpDown1.Value);
                                s["Quantity"] = sl;
                                MessageBox.Show("Đã Cập Nhật Số Lượng Thành Công");
                                show_pnl.Visible = false;
                                break;
                            }    
                            
                        }    
                    }  
                    if(exist == false)
                    {
                        DBCart.Cart.Rows.Add(x["Image"], x["Category"], x["Name"], x["Price"], numericUpDown1.Value);
                        MessageBox.Show("Đã Thêm Sản Phẩm Vào Giỏ Hàng Thành Công");
                        show_pnl.Visible = false;
                        break;
                    }    
                    
                    
                }    
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart ct = new Cart();
            this.Close();
            ct.ShowDialog();
            this.Show();
        }
    }
}
