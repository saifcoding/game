﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourDBCore
{
    public class ConnectFourDBService
    {

        #region user_authentication
        //returns true if login succes
        //return false if login failed
        public bool CheckIfValidLogin(string username, string password)
        {
            using (var db = new ConnectFourContext())
            {
                if (db.Users.Any(c => c.userName == username && c.password == password))
                {
                    return true;
                }
                return false;
            }


        }

        //return true if registered successfully
        //return false if failed (username or password already exists)
        public bool RegisterUser(string username, string password)
        {
            using (var db = new ConnectFourContext())
            {
                if (db.Users.Any(u => u.userName == username))
                {
                    return false;
                }

                User user = new User
                {
                    userName = username,
                    password = password
                };
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
        }
        #endregion


        #region getters

        public IEnumerable<PlayersDetails> getPlayers()
        {
            using (var db = new ConnectFourContext())
            {
                List<PlayersDetails> players = (from c in db.Users
                                                select new PlayersDetails
                                                {
                                                    username = c.userName,
                                                    numOfGames = c.numberOfGames,
                                                    numOfWins = c.numberOfWins,
                                                    numOfLoses = c.numberOfLoses,
                                                    numOfPoints = c.numberOfPoints
                                                }
                                        ).ToList();
                return players;
            }
        }

        public PlayersDetails getPlayerDetails(string username)
        {
            using (var db = new ConnectFourContext())
            {
                User player = db.Users.SingleOrDefault(user => user.userName == username);
                if (player == null)
                {
                    return null;
                }
                PlayersDetails playerDetails = new PlayersDetails();
                playerDetails.numOfGames = player.numberOfGames;
                playerDetails.numOfLoses = player.numberOfLoses;
                playerDetails.numOfWins = player.numberOfWins;
                playerDetails.numOfPoints = player.numberOfPoints;
                playerDetails.status = player.status;
                return playerDetails;
            }
        }

        public IEnumerable<GameDetails> getGames()
        {
            using (var db = new ConnectFourContext())
            {
                List<GameDetails> games = (from c in db.Games
                                           select new GameDetails
                                           {
                                               Player1 = c.user1.userName,
                                               Player2 = c.user2.userName,
                                               gameTime = c.gameTime,
                                               Winner = c.user1.userId == c.winner ? c.user1.userName : (c.user2.userId == c.winner ? c.user2.userName : "No Winner")

                                           }
                                      ).ToList();
                return games;
            }
        }
        #endregion
        #region game_logic

        public bool addGameWithWinToDB(string player1, string player2, string winnerPlayer, DateTime gameTime)
        {
            using (var db = new ConnectFourContext())
            {
                User player1InDB = db.Users.SingleOrDefault(user => user.userName == player1);
                User player2InDB = db.Users.SingleOrDefault(user => user.userName == player2);
                if (player1InDB == null || player2InDB == null)
                {
                    return false;
                }
                Game g = new Game();
                g.user1 = player1InDB;
                g.user2 = player2InDB;
                g.gameTime = gameTime;
                if (winnerPlayer == player1)
                {
                    g.winner = player1InDB.userId;
                    player1InDB.numberOfPoints += 1;
                    player1InDB.numberOfWins += 1;
                    player2InDB.numberOfLoses += 1;
                }
                else
                {
                    g.winner = player2InDB.userId;
                    player1InDB.numberOfLoses += 1;
                    player2InDB.numberOfWins += 1;
                    player2InDB.numberOfPoints += 1;

                }

                player1InDB.numberOfGames += 1;
                player2InDB.numberOfGames += 1;

                db.Entry(player1InDB).State = System.Data.Entity.EntityState.Modified;
                db.Entry(player2InDB).State = System.Data.Entity.EntityState.Modified;

                db.Games.Add(g);
                db.SaveChanges();
                return true;
            }
        }

        public bool addGameWithDrawToDB(string player1, string player2, DateTime gameTime)
        {
            using (var db = new ConnectFourContext())
            {
                User player1InDB = db.Users.SingleOrDefault(user => user.userName == player1);
                User player2InDB = db.Users.SingleOrDefault(user => user.userName == player2);

                if (player1InDB == null || player2InDB == null)
                {
                    return false;
                }

                Game g = new Game();
                g.user1 = player1InDB;
                g.user2 = player2InDB;
                g.gameTime = gameTime;
                // set winner to 0 that means its draw
                g.winner = 0;

                player1InDB.numberOfGames += 1;
                player2InDB.numberOfGames += 1;

                db.Entry(player1InDB).State = System.Data.Entity.EntityState.Modified;
                db.Entry(player2InDB).State = System.Data.Entity.EntityState.Modified;

                db.Games.Add(g);
                db.SaveChanges();
                return true;
            }
        }


        public void updateUserStatus(string username, USER_STATUS new_status)
        {
            using (var db = new ConnectFourContext())
            {
                User playerInDB = db.Users.SingleOrDefault(user => user.userName == username);
                if(playerInDB == null)
                {
                    return;
                }
                playerInDB.status = new_status;
                db.Entry(playerInDB).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        #endregion
    }
}
