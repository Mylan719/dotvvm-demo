using System.Collections.Generic;
using DotVVM.Framework.ViewModel;
using SimpleDotvvmConcepts.Services;

namespace SimpleDotvvmConcepts.ViewModels
{
    public class PeopleDialogViewModel : DotvvmViewModelBase
    {
        public List<Person> People { get; set; }
        public int Count { get; set; }
    }
}
