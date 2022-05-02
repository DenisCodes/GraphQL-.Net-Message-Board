using Forum;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using Microsoft.Extensions.DependencyInjection;
//using ForumApi;
//using StrawberryShake;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services
    //.AddForum()
    //.ConfigureHttpClient(client => client.BaseAddress = new Uri("https://localhost:5001/"));

await builder.Build().RunAsync();

            //var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //builder.RootComponents.Add<App>("#app");

            //IServiceCollection serviceCollection = new ServiceCollection();

            //serviceCollection
                //.AddForum()
               // .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:5001/api/"));

          //  IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

          //  IForum client = serviceProvider.GetRequiredService<IForum>();

          //  IOperationResult<IGetPostsResult> result = await client.GetPosts.ExecuteAsync();

          //  if (result.IsErrorResult())
          //  {
           //     Console.WriteLine("Failed to get posts");
          //  }
          //  else
           // {
           //     Console.WriteLine(result.Data?.AllPosts);
           // }

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //builder.Services
            // .AddForum()
            // .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://workshop.chillicream.com/graphql"));

            //await builder.Build().RunAsync();

