using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.Hosting;
using DotVVM.Framework.ViewModel;
using Newtonsoft.Json;
using SimpleDotvvmConcepts.ViewModels;

namespace SimpleDotvvmConcepts.Services
{
    public class PeopleService
    {
        public string FilePath { get; } = "Data/people.json";

        public async Task<List<Person>> LoadAsync()
        {
            var quotes = await LoadInternalAsync();
            return Sort(quotes);
        }

        [AllowStaticCommand]
        public async Task<PeopleDialogViewModel> LoadDialogAsync()
        {
            var people = await LoadAsync();
            return new PeopleDialogViewModel
            {
                People = people,
                Count = people.Count
            };
        }

        private List<Person> Sort(List<Person> quotes)
        {
            return quotes.OrderBy(s => s.Name).ToList();
        }

        public async Task<List<Person>> LoadInternalAsync()
        {
            var fileText = await File.ReadAllTextAsync(FilePath);
            return JsonConvert.DeserializeObject<List<Person>>(fileText);
        }

        private async Task SaveInternalAsync(List<Person> quotes)
        {
            var json = JsonConvert.SerializeObject(quotes);
            await File.WriteAllTextAsync(FilePath, json);
        }
    }
}
