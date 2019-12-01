namespace Singleton
{
    class Singleton
    {
        //private to prevent direct construction calls with the `new` operator.
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void someBusinessLogic()
        {
        }
    }
}
