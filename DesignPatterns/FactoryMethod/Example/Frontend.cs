namespace Example
{
    public class Frontend : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new React());
            Pages.Add(new Angular());
            Pages.Add(new Vue());
        }
    }
}
