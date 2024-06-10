using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_12congiap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
string can, chi;
        private void btntim_Click(object sender, EventArgs e)
        {

            
            
            switch (Convert.ToInt32(txtdl.Text) % 10)
            {
                case 0:
                    can = "canh";
                    break;
                    case 1:
                    can = "Tan";
                    break;
                case 2:
                    can = "Nham";
            break;
                case 3:
                    can = "Quy";
                    break;
                case 4:
                    can = "Giap";
                    break;
                case 5:
                    can ="At";
                    break;
                case 6:
                    can ="Binh";
                    break;
                case 7:
                    can = "Dinh";
                    break;
                case 8:
                    can = "Mau";
                    break;
                case 9:
                    can = "Ky";
                    break;
               
            }
          switch (Convert.ToInt32(txtKQ.Text) % 12)
            { 
                case 0:
                    chi = "Thân";
                    break;
                    case 1:
                    chi = "dậu";
                    break;
                case 2:
                    chi = "Tuat";
                    break;
                case 3:
                    chi = "Hoi";
                    break;
                case 4:
                    chi = "Ty";
                    break;
                case 5:
                    chi ="Suu";
                    break;
                case 6:
                    chi = "Dan";
                    break;
                case 7:
                    chi = "Mao";
                    break;
                case 8:
                    chi = "Thin";
                    break;
                case 9:
                    chi = "Ty";
                    break;
                case 10:
                    chi ="Ngo";
                    break;
                case 11:
                    chi ="Mui";
                    break;

            }
            txtdl.Text = can + " " + chi;
        }
    }
}
