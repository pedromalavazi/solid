

using DomainModel;

AnemicClient anemicClient = new AnemicClient();
anemicClient.Id = -1;
anemicClient.Name = string.Empty;
anemicClient.Address = "";

Console.WriteLine($"Id: {anemicClient.Id}, Nome: {anemicClient.Name}, Endereço: {anemicClient.Address}.");

Console.WriteLine("_________________________________________________");
Console.WriteLine();

RichClient richClient = new(12, "Pedro", "Pedreira, SP");

Console.WriteLine($"Id: {richClient.Id}, Nome: {richClient.Name}, Endereço: {richClient.Address}.");
