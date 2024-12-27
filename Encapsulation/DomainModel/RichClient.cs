namespace DomainModel;

public class RichClient
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Address { get; private set; }

    public RichClient(int id, string name, string address)
    {
        DomainExceptionValidation.When(Id < 0, "Id inválido");
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome não pode ser vazio");
        DomainExceptionValidation.When(string.IsNullOrEmpty(address), "Endereço não pode ser vazio");

        Id = id;
        Name = name;
        Address = address;
    }
}
