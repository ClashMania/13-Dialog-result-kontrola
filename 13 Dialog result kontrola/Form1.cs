using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Dialog_result_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            //korisnik nakon pritiska tipke odlučuje "yes ili no"
            string poruka = "Odaberite Yes / No / Cancel";
            string naslov = "Naslovna linija Dijaloga za poruke";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;

            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            //korisnikova odluka se ispisuje u TextBox
            switch (rez)

            {

                case DialogResult.Yes:

                    textBoxRezultat.Text = "Izabrali ste dugme YES";

                    break;

                case DialogResult.No:

                    textBoxRezultat.Text = "Izabrali ste dugme NO";

                    break;

                case DialogResult.Cancel:

                    textBoxRezultat.Text = "Izabrali ste dugme Cancel";

                    break;
            }
        }
    }
}