using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAsyncPatterns
{
    public class PerformanceComparison
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task<string> SlowVersionAsync()
        {

            //üç task da UI thread'a dönecek.
            var task1 = _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/comments");
            var task2 = _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            var task3 = _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/albums");


            await Task.Delay(5000);

            await Task.WhenAll(task1, task2, task3); // 3 defa context'i değiştirdiniz (context switch)
            
            return task1.Result + task2.Result + task3.Result;
        }

        public async Task<string> FastVersionAsync()
        {


            var task1 = _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/comments");
            var task2 = _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            var task3 = _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/albums");

            await Task.Delay(5000);


            await Task.WhenAll(task1,task2,task3).ConfigureAwait(false); // Context switch yok!
            return task1.Result + task2.Result + task3.Result;
        }
    }
}
