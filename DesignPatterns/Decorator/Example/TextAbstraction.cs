namespace Example
{
    public abstract class TextAbstraction
    {
        public double Size { get; set; }
        public string Font { get; set; }

        public abstract void ShowInformation();
    }
}
