﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPoc
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public bool IsNoob { get; set; }
        public int Health { get; set; }
        public List<string> Weapons { get; set; }

        public PlayerCharacter()
        {
            IsNoob = true;
            Name = GenerateName();
            CreateStartingWeapons();
        }

        public void Sleep()
        {
            Health += new Random().Next(1, 101);
        }

        private string GenerateName()
        {
            var names = new[]
            {
                "Danieth",
                "Derick",
                "Shalnorr",
                "Toth",
                "Boldrak"
            };

            return names[new Random().Next(0, names.Length)];
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>
            {
                "Short bow",
                "Long bow",
                "Short sword"
            };
        }
    }
}