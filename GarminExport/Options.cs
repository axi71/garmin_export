﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarminExport
{
    sealed class Options
    {
        [Option('u', "username", Required = true, HelpText = "Garmin Connect user name.")]
        public string UserName { get; set; }

        [Option('p', "password", Required = true, HelpText = "Garmin Connect password.")]
        public string Password { get; set; }

        [Option('t', "type", Required = false, HelpText = "Sync type: activites, wellness, all", DefaultValue = "activites")]
        public string SyncType { get; set; }

        [Option("origin", Required = false, HelpText ="origin = fit, else gpx", DefaultValue = false)]
        public Boolean Origin { get; set; }

        [Option('o', "output", DefaultValue = "./export")]
        public string OutputPath { get; set; }

        [Option("from-date", Required = false, HelpText = "Format JJJJ-MM-TT")]
        public string FromDate { get; set; }

        [Option("save-activity-result", Required = false, DefaultValue = false, HelpText = "Save the activity json from garmin for each activitx")]
        public bool SaveActivityResult { get; set; }
    }
}
