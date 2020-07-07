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
        public Form1()
        {
            InitializeComponent();
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
    }
}
