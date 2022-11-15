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
    public partial class Nike : Form
    {
        public Nike()
        {
            InitializeComponent();
        }
        // khởi tạo các biến.
        DataTable dt = new DataTable();
        // tạo constructor với data truyền vào
        public Nike(DataTable _dt)
        {
            InitializeComponent();
            dt = _dt; // lấy data

        }

        private void Initbutton(Button b, Point x, string image)
        {
            b.Location = x;
            b.Size = new Size(270, 170);
            b.BackgroundImageLayout = ImageLayout.Stretch;
            // tim hinh phu` hop..khong biet sao no co dau gach
            // switch cmnl cay vl
            switch (image)
            {
                case "11":
                    b.BackgroundImage = global::TH2.Properties.Resources._11;
                    break;
                case "12":
                    b.BackgroundImage = global::TH2.Properties.Resources._12;
                    break;
                case "13":
                    b.BackgroundImage = global::TH2.Properties.Resources._13;
                    break;
                case "14":
                    b.BackgroundImage = global::TH2.Properties.Resources._14;
                    break;
                case "15":
                    b.BackgroundImage = global::TH2.Properties.Resources._15;
                    break;
                case "16":
                    b.BackgroundImage = global::TH2.Properties.Resources._16;
                    break;
                case "17":
                    b.BackgroundImage = global::TH2.Properties.Resources._17;
                    break;
                case "18":
                    b.BackgroundImage = global::TH2.Properties.Resources._18;
                    break;
                case "19":
                    b.BackgroundImage = global::TH2.Properties.Resources._19;
                    break;
                case "20":
                    b.BackgroundImage = global::TH2.Properties.Resources._20;
                    break;
                default:
                    break;
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
        private void Nike_Load(object sender, EventArgs e)
        {
            // còn nhiều đôi chưa add zô resource. t làm mẩu
            Point locate = new Point(8, 42);
            int hang = 1;
            foreach (DataRow r in dt.Rows)
            {
                // tạo từng button, label cho giày.
                Button b = new Button();
                Label content = new Label();
                Label price = new Label();
                Initbutton(b, locate, r.Field<string>("Image"));
                InitContent(content, b, r.Field<string>("Name"));
                InitPrice(price, b, (r.Field<decimal>("Price") * 1000).ToString() + "đ");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
