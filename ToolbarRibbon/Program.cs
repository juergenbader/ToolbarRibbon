#region Copyright
// ----------------------------------------------------------------------
// Copyright (c) 2022 Bader CONSILIA
// ----------------------------------------------------------------------
// Project   ToolbarRibbon
// Namespace ToolbarRibbon
// FileName  Program.cs
// ----------------------------------------------------------------------
// Created   27.02.2022, 16:52
// Updated   27.02.2022, 17:39
// Author    Jürgen Bader (Administrator)
// ----------------------------------------------------------------------
#endregion

namespace ToolbarRibbon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}