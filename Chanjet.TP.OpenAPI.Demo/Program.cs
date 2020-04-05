using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chanjet.TP.OpenAPI.Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(""));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public enum AccountCharacterEnum
    {
        //工业
        Industry,
        //商业
        Commercy
    }

    public class TestClass
    {
        public void TestMethod(int a)
        {
            throw new ArgumentOutOfRangeException("a");
        }
    }
}
