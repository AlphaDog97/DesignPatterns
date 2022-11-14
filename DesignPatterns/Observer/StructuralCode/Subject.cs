namespace StructuralCode
{
    public abstract class Subject
    {
        List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detech(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
