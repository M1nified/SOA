﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ObjectManager.Models;
using ObjectManager.LiteDB;

namespace HobbitsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Hobbits : IHobbits
    {
        public int CreatePlayer(string name, string code)
        {
            var repo = new PlayersRepository();
            return repo.Add(new Player()
            {
                Name = name,
                Code = code
            });
        }

        public int GetPlayer(string name, string code)
        {
            throw new NotImplementedException();
        }

        public string GetPlayerName(int id)
        {
            throw new NotImplementedException();
        }

        public Stats GetPlayerStats(string name)
        {
            throw new NotImplementedException();
        }

        public Stats SetPlayerStats(string name, Stats stats)
        {
            throw new NotImplementedException();
        }
    }
}
