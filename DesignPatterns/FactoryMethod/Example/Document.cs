namespace Example
{
    public abstract class Document
    {
        private List<DocumentPage> _pages = new List<DocumentPage>();
        public List<DocumentPage> Pages
        {
            get { return _pages; }
        }
        public abstract void CreatePages();
        public Document()
        {
            CreatePages();
        }
    }
}
