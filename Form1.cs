using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wintest3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingManagerBase bm;
        void checkposition()
        {
            if (bm.Position == 0)
            {
                button_first.Enabled = false;
                button_prev.Enabled = false;
                button_next.Enabled = true;
                button_last.Enabled = true;
            }
            else if (bm.Position == bm.Count - 1)
            {
                button_first.Enabled = true;
                button_prev.Enabled = true;
                button_next.Enabled = false;
                button_last.Enabled = false;
            }
            else
            {
                button_first.Enabled = true;
                button_prev.Enabled = true;
                button_next.Enabled = true;
                button_last.Enabled = true;
            }
            lblshow.Text = $"目前在第{bm.Position + 1}筆紀錄,總共有{bm.Count}筆紀錄";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.conn))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from 會員", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "會員");
                DataTable dt = ds.Tables["會員"];
                Binding bindname = new Binding("Text", ds, "會員.姓名");
                Binding bindphone = new Binding("Text", ds, "會員.電話");
                Binding bindsex = new Binding("Text", ds, "會員.性別");
                Binding binddate = new Binding("Text", ds, "會員.入會日期");
                Binding bindmarry = new Binding("Checked", ds, "會員.婚姻狀態");
                textBox_id.DataBindings.Add("Text",ds,"會員.編號");
                textBox_name.DataBindings.Add(bindname);
                textBox_phone.DataBindings.Add(bindphone);
                textBox_sex.DataBindings.Add(bindsex);
                dateTimePicker_member.DataBindings.Add(binddate);
                checkBox_marry.DataBindings.Add(bindmarry);
                bm = BindingContext[ds, "會員"];
            }
        }

        private void button_first_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            checkposition();
        }

        private void button_next_Click(object sender, EventArgs e)
        {

            if (bm.Position < bm.Count)
            {
                bm.Position++;
                checkposition();
            }
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (bm.Position != 0)
            {
                bm.Position--;
                checkposition();
            }
        }

        private void button_last_Click(object sender, EventArgs e)
        {

            bm.Position = bm.Count-1;
            checkposition();

        }
    }
}
