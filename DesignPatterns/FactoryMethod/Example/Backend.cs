namespace Example
{
    public class Backend : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new DotNet());
            Pages.Add(new Java());
            Pages.Add(new Python());
        }
    }
}
