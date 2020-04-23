using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using SimpleDotvvmConcepts.Services;

namespace SimpleDotvvmConcepts.ViewModels
{
    public class ServicesComparisionViewModel : MasterPageViewModel
    {
        private readonly QuoteService quoteService;

        public List<Quote> Quotes { get; set; }

        public string NewQuote { get; set; }
        public Quote EditQuote { get; set; }

        public bool RefreshQuotes { get; set; }

        public ServicesComparisionViewModel(QuoteService quoteService)
        {
            this.quoteService = quoteService;
        }

        public override async Task PreRender()
        {
            if (!Context.IsPostBack && !RefreshQuotes)
            {
                Quotes = await quoteService.LoadAsync();
            }
        }

        public Task AddAsync(string text)
        {
            RefreshQuotes = true;
            return quoteService.AddAsync(text);
        }
    }
}
