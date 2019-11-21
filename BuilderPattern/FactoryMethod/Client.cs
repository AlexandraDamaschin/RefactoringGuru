using System;

namespace FactoryMethod
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ChildOfCreator1.");
            ClientCode(new ChildOfCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ChildOfCreator2.");
            ClientCode(new ChildOfCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.Operation());
        }
    }
}
