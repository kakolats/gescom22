using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gescom22
{
    
    public partial class FrmMenuLivreur : Form
    {
        private User user;
        public FrmMenuLivreur(User user)
        {
            this.user = user;
            InitializeComponent();
        }
    }
}
