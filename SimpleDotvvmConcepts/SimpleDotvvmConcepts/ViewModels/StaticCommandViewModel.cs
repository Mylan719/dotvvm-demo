using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace SimpleDotvvmConcepts.ViewModels
{
    public class StaticCommandViewModel : MasterPageViewModel
    {
        public string SealUrl { get; set; }
        public List<string> Quotes { get; set; } = new List<string> { 
        
        }
    }
}
