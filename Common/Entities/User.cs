using System;

namespace Common.Entities
{
    public interface IUser
    {
        int Id { get; }
        string Username { get;}
        DateTime CreateDate { get; }
    }

    public sealed class User : IUser
    {
        public User(int id, string username, DateTime createDate)
        {
            Id = id;
            Username = username;
            CreateDate = createDate;
        }

        public int Id { get; }
        public string Username { get; }
        public DateTime CreateDate { get; }
    }

    public interface IUserInDb : IUser
    {
        string Password { get; }
    }

    public sealed class UserInDb : IUserInDb
    {
        public UserInDb(int id, string username, string password, DateTime createDate)
        {
            Id = id;
            Username = username;
            Password = password;
            CreateDate = createDate;
        }

        public int Id { get; }
        public string Username { get; }
        public string Password { get; }
        public DateTime CreateDate { get; }
    }
}
