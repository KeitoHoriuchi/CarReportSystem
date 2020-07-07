using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    
    public partial class Form1 : Form
    {
        BindingList<CarReport> Reports = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvRecode.DataSource = Reports;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //CarReportオブジェクト生成
            CarReport obj = new CarReport
            {
                CreatedDate = dtpDate.Value,
                Author = cbAuthor.Text,
                Name = cbName.Text,
                Report = Report.Text
            };
            var RadioButtonChecked_InGroup = Maker.Controls.OfType<RadioButton>()
        .SingleOrDefault(rb => rb.Checked == true);

            Reports.Insert(0,obj);
        }


        private void setcbAuthor(string Author)
        {
            if (!cbAuthor.Items.Contains(Author))
            {
                //コンボボックスの候補に追加
                cbAuthor.Items.Add(Author);
            }
        }

        private void setcbName(string Name)
        {
            if (!cbName.Items.Contains(Name))
            {
                //コンボボックスの候補に追加
                cbName.Items.Add(Name);
            }
        }

        private void btOpenImage_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }


    }
}
