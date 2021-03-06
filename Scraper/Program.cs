﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scraper
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && "autosearch".Equals(args[0]))
            {
                bool isOversee = false;
                if (args.Length > 1 && "oversee".Equals(args[1]))
                    isOversee = true;

                var main = new MainForm();
                main.SearchAndSendMessage(isOversee : isOversee);
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
