namespace StructuralCode
{
    public class ConcreteObserver : Observer
    {
        private readonly string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(
            ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
                name, observerState);
        }
    }
}
