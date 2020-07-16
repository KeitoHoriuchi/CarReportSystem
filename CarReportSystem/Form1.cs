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
using System.Data;
using System.Net.Http.Headers;

namespace CarReportSystem
{

    public partial class Form1 : Form
    {
        BindingList<CarReport> Reports = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            //dgvRecode.DataSource = Reports;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }
        
        //追加
        private void btAdd_Click(object sender, EventArgs e)
        {



            setMaker(Maker.Text);

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202012DataSet);

            /*
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
            */
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

        //接続
        private void btOpen_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202012DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202012DataSet.CarReport);
            dgvRecode.Columns[0].Visible = false;//IDの非表示

            /*if (ofdOpenData.ShowDialog() == DialogResult.OK)
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
            }*/
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {

        }

        /*
        private CarReport.CarMaker getMaker(){
            RadioButton selectMaker = Maker.Controls.Cast<RadioButton>().FirstOrDefault();
            return (CarReport.CarMaker)int.Parse(selectMaker.Tag.ToString());
        }
        */

        private void setMaker(string maker)
        {
            switch (maker)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGaisya.Checked = true;
                    break;
                default :
                    rbOther.Checked = true;
                    break;
            }
        }

        private void dgvCarDate_Click(object sender, EventArgs e)
        {
            //選択したレコードを取り出す
            /*データグリッドビューで選択した行のインデックスを元に
             * BindingListのデータを取得する
            */

            var maker = dgvRecode.CurrentRow.Cells[3].Value;
            CarReport selectedCara = Reports[dgvRecode.CurrentRow.Index];
            dtpDate.Value = selectedCara.CreatedDate;
            cbAuthor.Text = selectedCara.Author;
            cbName.Text = selectedCara.Name;
            pbImage.Image = selectedCara.Picture;
            tbReport.Text = selectedCara.Report;
            
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202012DataSet);

        }

        private void dgvRecode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }
    }
}
