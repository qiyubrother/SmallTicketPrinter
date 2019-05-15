using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace SmallTicketPrinter
{
    public partial class FrmPrint : Form
    {
        public FrmPrint()
        {
            InitializeComponent();
            Width = 0;
            Height = 0;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Visible = false;
            Print(Header, LoopBody);
        }

        public Dictionary<string, string> Header = new Dictionary<string, string>();
        public List<Dictionary<string, string>> LoopBody = new List<Dictionary<string, string>>();

        public void SetDefaultPrinter(string printerName) => PrinterAPI.SetDefaultPrinter(printerName);

        public string GetDefaultPrinter() => (new PrinterSettings()).PrinterName;

        public string PrinterName { get; set; }

        public void Print(Dictionary<string, string> header, IEnumerable<Dictionary<string, string>> loopBody)
        {
            var templateContainer = File.ReadAllText($"TemplateContainer.html");
            var template = File.ReadAllText($"template.html");
            var context = templateContainer.Replace("{template}", template);
            #region 处理循环
            var regexStr = @"{{[a-zA-z\S\s]*}}";
            var match = Regex.Match(context, regexStr);
            if (match.Success)
            {
                var resultBody = new StringBuilder();
                var bodyText = match.Value.Substring(2, match.Value.Length - 4);
                foreach (var item in loopBody)
                {
                    var loopItem = bodyText;
                    foreach (var m in item)
                    {
                        var s = "{" + $"{m.Key}" + "}";
                        loopItem = loopItem.Replace(s, m.Value);
                    }
                    resultBody.Append(loopItem);
                }
                context = context.Replace(match.Value, resultBody.ToString());
            }
            #endregion

            foreach (var m in header)
            {
                var s = "{" + $"{m.Key}" + "}";
                context = context.Replace(s, m.Value);
            }
            const string fileName = "temp.html";
            File.WriteAllText(fileName, context);
            webBrowser1.Url = new Uri(Application.StartupPath.ToString() + $"/{fileName}");
            webBrowser1.DocumentCompleted += (s, e)=> webBrowser1.Print();
        }
    }
}
