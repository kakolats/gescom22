using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gescom22.utils
{
    public enum Action { ADD, UPDATE, DELETE, UPDEL };
    class FormUtils
    {
        public static void desactiveFields(Button btnAdd, Button btnUp, Button btnDel, Action action)
        {
            btnAdd.Enabled = false;
            btnUp.Enabled = false;
            btnDel.Enabled = false;
            switch (action)
            {
                case Action.ADD:
                    btnAdd.Enabled = true;
                    break;
                default:
                    btnUp.Enabled = true;
                    btnDel.Enabled = true;
                    break;
            }

        }

        public static void clearFieds(GroupBox groupBox)
        {
            foreach (var control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        public static void activeTextBoxes(GroupBox groupBox,Boolean boo)
        {
            foreach (var control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Enabled=boo;
                }
            }
        }

        public static Boolean commandeValide(List<DetailsCommande> details)
        {
            foreach(DetailsCommande det in details)
            {
                if (det.Quantite > det.Produit.Stock)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

