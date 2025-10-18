using DependencyInjection; // our namespace...
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Configuration;
// left as an excerise to clean this up :-) 

// CRUEL HACK FOR LOG4NET 
System.Text.Encoding.RegisterProvider(
    System.Text.CodePagesEncodingProvider.Instance);

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
// IOC Container 
// Spring IOC 
// pico 
builder.Logging.ClearProviders();
//builder.Logging.AddConsole();
//builder.Logging.AddDebug();
// Will now use our own logging.... 
builder.Logging.AddLog4Net("log4net.config"); 
// builder.Logging.AddConfiguration(Configuration.GetSection("Logging"));
builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<IMessageWriter, DBMessageWriter>();
using IHost host = builder.Build();
host.Run();