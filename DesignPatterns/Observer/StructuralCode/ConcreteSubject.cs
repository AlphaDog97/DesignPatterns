namespace StructuralCode
{
    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get { return subjectState; }
            set 
            {
                if (subjectState != value) 
                {
                    subjectState = value;
                    Notify();
                }
            }
        }
    }
}
