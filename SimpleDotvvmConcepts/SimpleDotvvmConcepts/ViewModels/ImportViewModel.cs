using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace SimpleDotvvmConcepts.ViewModels
{
    public class ImportViewModel : MasterPageViewModel
    {
		public string Title { get; set;}
		public ImportViewModel()
		{
			Title = "Hello from DotVVM!";
		}
    }
}
