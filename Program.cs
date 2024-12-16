using Mediator_Pattern;

class Program
{
    static void Main(string[] args)
    {
        ChatMediator chatMediator = new ChatMediator();

        User alice = new User("Alice");
        User bob = new User("Bob");
        User charlie = new User("Charlie");

        chatMediator.AddUser(alice);
        chatMediator.AddUser(bob);
        chatMediator.AddUser(charlie);

        alice.SendMessage("Привет, Боб!", "Bob");
        bob.SendMessage("Привет, Алиса!", "Alice");
        charlie.SendMessage("Привет всем!", "Alice");
        charlie.SendMessage("Как дела, Боб?", "Bob");

        alice.ShowMessageHistory();
        bob.ShowMessageHistory();
        charlie.ShowMessageHistory();
    }
}