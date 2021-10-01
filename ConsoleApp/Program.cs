using Autofac;
using ConsoleApp;

var container = ContainerConfig.Configure();

using var scope = container.BeginLifetimeScope();
var app = scope.Resolve<IApplication>();
app.Run();

Console.ReadLine();

