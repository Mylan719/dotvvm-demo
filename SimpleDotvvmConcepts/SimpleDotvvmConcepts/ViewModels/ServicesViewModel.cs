using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using SimpleDotvvmConcepts.Services;

namespace SimpleDotvvmConcepts.ViewModels
{
    public class ServicesViewModel : MasterPageViewModel
    {
        private readonly QuoteService quoteService;

        public List<Quote> Quotes { get; set; }

        public string NewQuote { get; set; }
        public Quote EditQuote { get; set; }

        public ServicesViewModel(QuoteService quoteService)
        {
            this.quoteService = quoteService;
        }

        public override async Task PreRender()
        {
            Quotes = await quoteService.LoadAsync();
        }
    }
}
