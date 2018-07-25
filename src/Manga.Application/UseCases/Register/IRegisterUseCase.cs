namespace Manga.Application.UseCases.Register
{
    using Manga.Domain.ValueObjects;
    using System.Threading.Tasks;

    public interface IRegisterUseCase
    {
        Task<RegisterOutput> Execute(SSN ssn, Name name, Amount initialAmount);
    }
}
