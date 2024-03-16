namespace OODesign
{
    public class UserBilder
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public UserBilder(string username, string password)
        {
            UserName = username;
            Password = password;
        }


        public UserBilder SetEmail (string email) 
        {
            Email = email;
            return this;
        }
        
        public UserBilder SetAge (int age)
        {
            Age = age;
            return this;
        }

        public User GetBild()
        {
            return new User(this);
        }
    }
}