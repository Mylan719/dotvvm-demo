using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using Newtonsoft.Json;

namespace SimpleDotvvmConcepts.Services
{
    //This should not be facade, this should have facade as dependency
    public class QuoteService
    {
        public string FilePath { get; } = "Data/quotes.json";

        public async Task<List<Quote>> LoadAsync()
        {
            var quotes = await LoadInternalAsync();
            return Sort(quotes);
        }

        [AllowStaticCommand]
        public async Task<List<Quote>> AddAsync(string quoteText)
        {
            var list = await LoadInternalAsync();
            var quote = new Quote
            {
                Id = list.Count + 1,
                Text = quoteText
            };
            list.Add(quote);
            list = Sort(list);
            await SaveInternalAsync(list);
            return list;
        }

        private List<Quote> Sort(List<Quote> quotes)
        {
            return quotes.OrderByDescending(s => s.Id).ToList();
        }

        public async Task<List<Quote>> LoadInternalAsync()
        {
            var fileText = await File.ReadAllTextAsync(FilePath);
            return JsonConvert.DeserializeObject<List<Quote>>(fileText);
        }

        private async Task SaveInternalAsync(List<Quote> quotes)
        {
            var json = JsonConvert.SerializeObject(quotes);
            await File.WriteAllTextAsync(FilePath, json);
        }
    }
}
