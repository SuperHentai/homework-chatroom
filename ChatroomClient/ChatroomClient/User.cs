﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;

namespace ChatroomClient
{
    class User
    {
        public ArrayList users;

        public User()
        {
            this.users = new ArrayList();
        }
        public UserNode AddUser(string UserIP, int UserPort, string UserName)
        {
            UserNode newUser = new UserNode(UserIP, UserPort, UserName);
            this.users.Add(newUser);
            return newUser;
        }
        public UserNode GetUserByID(int id)
        {
            foreach (UserNode tempUser in this.users)
            {
                if (tempUser.UserID == id)
                {
                    return tempUser;
                }
            }
            return null;
        }

    }

    public class UserNode
    {
        public string UserName;
        public int UserID;
        public IPEndPoint UserPoint;
        public static int UserNum;
        public UserNode(string UserIP, int UserPort, string UserName)
        {
            this.UserName = UserName;
            UserNode.UserNum += 1;
            this.UserID = UserNode.UserNum;
            this.UserPoint = new IPEndPoint(IPAddress.Parse(UserIP), UserPort);
        }

        public UserNode()
        {

        }
        public UserNode(int user_id,string user_name)
        {
            this.UserID = user_id;
            this.UserName = user_name;
        }
    }
}
