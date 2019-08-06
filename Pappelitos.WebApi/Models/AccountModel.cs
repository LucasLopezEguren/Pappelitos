using System;
using System.Collections.Generic;
using System.Linq;
using Pappelitos.Domain;

namespace Pappelitos.WebApi.Models
{
    public class AccountModel : Model <Account, AccountModel>
    {
        public int Id {get; set;}
        public String Username {get; set;}
        public String Password {get; set;}
        public String Mail {get; set;}
        public List<Player> Player {get; set;}
        public List<Match> Matches {get; set;}

        public AccountModel() { }

        public AccountModel(Account entity)
        {
            SetModel(entity);
        }

        public override Account ToEntity() => new Account()
        {
            Id = this.Id,
            Username = this.Username,
            Password = this.Password,
            Mail = this.Mail,
            Players = this.Player,
            Matches = this.Matches

        };

        protected override AccountModel SetModel(Account entity)
        {
            Id = this.Id;
            Username = this.Username;
            Password = this.Password;
            Mail = this.Mail;
            Players = this.Player;
            Matches = this.Matches;
            return this;
        }
    }
}