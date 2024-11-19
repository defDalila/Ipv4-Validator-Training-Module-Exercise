using Ipv4Validator.Helpers;
using Ipv4Validator.Utils;

Console.Clear();

string[] ipValidos = DataProvider.GetValidIpSamples();
string[] ipInvalidos = DataProvider.GetInvalidIpSamples();

foreach (var ip in ipInvalidos)
{
	DataValidate.ValidateIp(ip);
}

Console.WriteLine("---------------------\n");

foreach (var ip in ipValidos)
{
	DataValidate.ValidateIp(ip);
}

Console.WriteLine("----------------\n");

string[] ipAddresses = DataProvider.GetIpSamples();
foreach (var ip in ipAddresses)
{
	DataValidate.ValidateIp(ip);
}


Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

Console.Clear();