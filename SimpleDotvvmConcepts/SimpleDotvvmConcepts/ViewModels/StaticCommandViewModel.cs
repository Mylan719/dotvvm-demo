using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDotvvmConcepts.Services;

namespace SimpleDotvvmConcepts.ViewModels
{
    public class StaticCommandViewModel : MasterPageViewModel
    {
        public bool ToggleWolf { get; set; }
        public string SealUrl { get; set; }
        public string SnailText { get; set; }

        public decimal BeamLength { get; set; }
        public decimal Pieces { get; set; }
        public decimal PieceLenght { get; set; }
    }
}
