using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gestion_bibliotheque.View
{
    /// <summary>
    /// Interaction logic for AdherentFormUpdate.xaml
    /// </summary>
    public partial class AdherentFormUpdate : Window
    {
        public AdherentFormUpdate()
        {
            InitializeComponent();
        }
        private void close_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
