namespace Actio.Common
{
    public class CreateUser : Icommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}