using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Serialization;

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
                Report = tbReport.Text
            };
            setcbAuthor(cbAuthor.Text);
            setcbName(cbName.Text);
            CarReport carReport = new CarReport();
            carReport.Maker = getMaker();


            Reports.Insert(0, obj);
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

        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        //開く
        private void btOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Reports = (BindingList<CarReport>)formatter.Deserialize(fs);
                        dgvRecode.DataSource = Reports;
                        dgvCarDate_Click(sender, e);

                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private CarReport.CarMaker getMaker(){
            RadioButton selectMaker = Maker.Controls.Cast<RadioButton>().FirstOrDefault();
            return (CarReport.CarMaker)int.Parse(selectMaker.Tag.ToString());
        }

        private void setMaker()
        {

        }

        private void dgvCarDate_Click(object sender, EventArgs e)
        {
            //選択したレコードを取り出す
            /*データグリッドビューで選択した行のインデックスを元に
             * BindingListのデータを取得する
            */
            CarReport selectedCara = Reports[dgvRecode.CurrentRow.Index];
            dtpDate.Value = selectedCara.CreatedDate;
            cbAuthor.Text = selectedCara.Author;
            cbName.Text = selectedCara.Name;
            pbImage.Image = selectedCara.Picture;
            tbReport.Text = selectedCara.Report;
        }
    }
}
