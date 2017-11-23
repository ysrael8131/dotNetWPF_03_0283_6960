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

namespace dotNetWPF_03_0283_6960
{
    
    /// <summary>
    /// Interaction logic for PrinterUserControl.xaml
    /// </summary>
    public partial class PrinterUserControl : UserControl
    {
       // EventArgs<PrinterEventArgs> PageMissing;
        //EventArgs<PrinterEventArgs> InkEmpty;

        public PrinterUserControl()
        {
            InitializeComponent();
        }

        private void printerNameLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            printerNameLabel.FontSize = 25;
        }

        private void printerNameLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            printerNameLabel.FontSize = 16;
        }

        private void tooOPEN(object sender, ToolTipEventArgs e)
        {
            MessageBox.Show(inkCountProgressBar.Value.ToString());
        }

        private void tooCLOSE(object sender, ToolTipEventArgs e)
        {

        }
    }
}
