using System;
using WinForms = System.Windows.Forms;
using WebForms = System.Web.UI.WebControls;

namespace Namespace_aliases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(WinForms.Button));
            Console.WriteLine(typeof(WebForms.Button));
        }
    }
}
