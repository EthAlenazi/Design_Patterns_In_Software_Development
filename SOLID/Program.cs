namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Name = "Ali" };

            UserRepository repo = new UserRepository();
            repo.Save(user);

            EmailService emailService = new EmailService();
            emailService.Send(user);
        }
    }
}
