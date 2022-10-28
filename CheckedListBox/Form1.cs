using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class PruebaCheckedListBox : Form
    {
        public PruebaCheckedListBox()
        {
            InitializeComponent();
        }

        private void Entradacheckedlistbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string elemento = Entradacheckedlistbox.SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
                Mostrarlistbox.Items.Add(elemento);
            else Mostrarlistbox.Items.Remove(elemento);
        }
    }
}
