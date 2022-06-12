using System;
namespace fluidXtoresApi.dto
{
	public class userDto
	{
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserRegisterDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}

