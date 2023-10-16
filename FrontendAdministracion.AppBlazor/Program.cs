using FrontendAdministracion.AppBlazor;
using FrontendAdministracion.AppBlazor.Auth;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7243/api/") });

builder.Services.AddMudServices();

builder.Services.AddScoped<UserAuth>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();  //derle al segundo error para instalar el paquete//
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();


await builder.Build().RunAsync();

