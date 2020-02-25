using Agenda.Domain.Contracts.Repositories;
using Agenda.Domain.Contracts.Services;
using Agenda.Domain.Models;
using System;

namespace Agenda.Business.Services
{
    public class UserService : IUseService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public void ChangeInformation(string email, string nome, string cpf)
        {
            var user = GetByEmail(email);
            user.ChangeName(nome);
            _repository.Update(user);
        }

        private object GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void Register(string nome, string email, string cpf, string endereco, string telefone)
        {
            var hasUser = GetByNome(nome);
            if (hasUser != null)
                throw new Exception("O contato já existe");
            var user = new User(nome, cpf, telefone, email, endereco);
            _repository.Create(user);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }

        User IUseService.GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public void ChangeName(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
