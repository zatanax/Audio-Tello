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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AudioTello
{
    /// <summary>
    /// Interaction logic for LeftRght.xaml
    /// </summary>
    public partial class LeftRght : UserControl
    {
        public LeftRght()
        {
            InitializeComponent();
        }
        public void Set(List<byte> data)
        {
            if (data.Count < 2) return;

            LeftBar.Value = data[0];
            RightBar.Value = data[1];

        }
    }
}
