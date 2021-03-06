﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class PlayerManager
    {
        List<Player> players = new List<Player>() { };
        public void Add(Player player)
        {
            players.Add(player);
            Console.WriteLine("{0} {1}, isimli oyuncu sisteme eklendi.", player.PlayerName, player.PlayerSurname);
        }

        public void Update(Player player, int Id)
        {

        }

        public void Delete(string TcNo)
        {
            foreach (var player in players)
            {
                if (player.TcNo == TcNo)
                {
                    players.Remove(player);
                    Console.WriteLine("{0} {1}, isimli oyuncu sistemden silindi.", player.PlayerName, player.PlayerSurname);
                    break;
                }

                else
                {
                    continue;
                }
            }

        }

        public void ListPlayer()
        {
            int i = 1;
            foreach (var player in players)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0}.Oyuncu\nAd Soyad:{1} {2}\nTc No:{3}\nDoğum Yılı:{4}", i, player.PlayerName, player.PlayerSurname, player.TcNo, player.BirthYear);
                Console.WriteLine("--------------------------");
                i += 1;
            }
        }

        internal void Add(NewPlayer newPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
