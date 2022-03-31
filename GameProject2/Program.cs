// See https://aka.ms/new-console-template for more information



using GameProject2;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer { BirthYear = 2001, FirstName = "ÖMER", Id = 13, IdentityNumber = 12345, LastName = "DİDİN" });

