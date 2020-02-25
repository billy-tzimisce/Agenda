using Agenda.Domain.Contracts.Repositories;
using Agenda.Domain.Models;
using Agenda.InfraStructure.Repositories;
using System;


namespace Agenda.AgendaAppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(@"Billy",
                "95915362168",
                "62998545514",
                "raziel-tzimisce@hotmail.com",
                "Av das  estradas N1663");
            using (IUserRepository userRep = new UserRepository())
            {
                //userRep.Create(user);
            }
            using (IUserRepository userRep = new UserRepository())
            {
                var usr = userRep.Get("Billy");
                Console.WriteLine(usr.Nome +"\n"+ user.Telefone + "\n" +user.CPF);
            }
            Console.ReadKey();
        }
    }
}
