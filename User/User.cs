using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class User
    {
        public String UserName
        {
            get; set;
        }
        public List<String> friends
        {
            get; private set;
        }
        public User(String UserName, List<String> friends)
        {
            this.UserName = UserName;
            this.friends = friends;

        } public bool AddFriend(String friendsName)  {
            if (friends != null && !friends.Contains(friendsName)) 
                { friends.Add(friendsName);
                Console.WriteLine("Sucsess" );
                return true;
            } return false;
    }
        public bool RemoveFriend(String friendsName)
        {

            if (friends.Remove(friendsName)) {
                Console.WriteLine("sucsess");
                return true; }
            return false;
        
        } 
        public void PrintFriends(string friends)
        {
            for (int i = 0; i < this.friends.Count; i++)
            {
                Console.WriteLine(" this user name friend is " + friends[i]);
                
            }

        }
        public Dictionary<string, List<string>> GetFriendsOfFriends(Dictionary<string, User> network)
        {
            Dictionary<string, List<string>> Myfriends = new Dictionary<string, List<string>>();
            foreach (var friend in friends)
            {
                if (network.ContainsKey(friend))
                    Myfriends.Add(friend, network[friend].friends);
            }
            return Myfriends;
        }

    } }

