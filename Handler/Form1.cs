using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniqueSymbol;

namespace Handler
{
    public partial class HandlerForm : Form
    {
        public HandlerForm()
        {
            InitializeComponent();
        }

        private void UpdateUniqueSymbol(object sender, EventArgs e)
        {
            TextHandler handler = new TextHandler(textBox1.Text);
            textBox2.Text =
                "Unique character in the text:" +
                Environment.NewLine +
                "[" + handler.GetUniqueCharFromText() + "]";
        }

    }
}
