using System;
using System.Windows.Forms;
using FacebookWrapper;

// $G$ RUL-004 (-20) Wrong word name format
// $G$ THE-001 (-14) your grade on diagrams document - 86. please see comments inside the document. 40% of your grade).
// $G$ CSS-999 (-10) StyleCop errors

namespace FacebookWinFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
