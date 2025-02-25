using ChallengeApp2;

User user1 = new User("Adam", "sd");
User user2 = new User("Monika", "sd");
User user3 = new User("Zuzia", "sd");
User user4 = new User("Damian", "sd");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);



