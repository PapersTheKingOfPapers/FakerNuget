using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace FakerNuget
{
    class CommandLine
    {
        [Option('i', "interactive", Required = false, HelpText = "--interactive")]
        public bool Interactive { get; set; }

        [Option('c', "personCount", Required = false, HelpText = "--personCount=")]
        public string personCount { get; set; }
    }
}
