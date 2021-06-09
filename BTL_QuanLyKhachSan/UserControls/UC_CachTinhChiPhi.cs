using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyKhachSan.UserControls
{
    public partial class UC_CachTinhChiPhi : UserControl
    {
        public UC_CachTinhChiPhi()
        {
            InitializeComponent();

            for (int i=0; i < 3; i++)
            {
                Panel pnl = new Panel();
                pnl.BackColor = Color.Aqua;
                pnl.Margin = new Padding(15);
                pnl.Size = new Size(219, 100);


                Label lbl = new Label();
                pnl.Controls.Add(lbl);
                lbl.BackColor = Color.White;
                lbl.Location = new Point(76, 67);
                lbl.AutoSize = true;
                lbl.Text = "labeeee";

                TextBox txb = new TextBox();
                pnl.Controls.Add(txb);
                txb.Location = new Point(113, 32);
                txb.Size = new Size(100, 20);
                txb.Tag = lbl;

                Button btn = new Button();
                pnl.Controls.Add(btn);
                btn.Location = new Point(13, 30);
                btn.Size = new Size(75, 23);
                btn.Text = "buttonnn";
                btn.Tag = txb;
                btn.Click += Btn_Click;

                FlowLayoutPanel.Controls.Add(pnl);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //((sender as Button).Tag as TextBox).Text = "hahahaaa";
            TextBox txb = (sender as Button).Tag as TextBox;
            Label lbl = ((sender as Button).Tag as TextBox).Tag as Label;
            txb.Text = "haha txb";

            lbl.Text = "LABELLLL";
        }
    }
}
