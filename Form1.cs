using System;
using System.Windows.Forms;
using Utilities;

namespace AtomicListener
{
    public partial class Form1 : Form
    {
        globalKeyboardHook gkh = new globalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.Control);
            gkh.HookedKeys.Add(Keys.A);
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            lstLog.Items.Add("Up\t" + e.KeyCode.ToString());
            Clipboard.SetText("Sistema Bazin informa: Seu preguiçoso, digite e não copie e cole!!");
            e.Handled = true;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            lstLog.Items.Add("Down\t" + e.KeyCode.ToString());
            e.Handled = true;
        }
    }
}