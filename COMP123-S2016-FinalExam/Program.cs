﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        public static SplashForm splashscreen;
        public static GenerateNameForm generateNameScreen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            generateNameScreen = new GenerateNameForm();
            splashscreen = new SplashForm();
            
            Application.Run(splashscreen);
        }
    }
}
