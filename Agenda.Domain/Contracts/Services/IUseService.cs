using Agenda.Domain.Models;
using System;

namespace Agenda.Domain.Contracts.Services
{
    public interface IUseService : IDisposable
    {
      //  User Authenticate(string cpf, string nome);
        User GetByEmail(string email);
        User GetByNome(string nome);
        void Register(string name, string email, string cpf, string endereco, string telefone);
        void ChangeInformation(string email, string name, string cpf);
    }
}
