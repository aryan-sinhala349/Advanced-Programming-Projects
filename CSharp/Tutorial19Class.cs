using System.Windows.Forms;

namespace Sinha
{
    namespace Tutorial19Namespace
    {
        class Tutorial19Class
        {
            public static void ShowMessage(string message, string caption)
            {
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }
    }
}