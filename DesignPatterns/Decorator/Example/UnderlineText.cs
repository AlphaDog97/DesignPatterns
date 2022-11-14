namespace Example
{
    public class UnderlineText : TextDecorator
    {
        public bool IsUnderline { get; set; } = false;

        public UnderlineText(TextAbstraction component)
        {
            SetComponent(component);
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            ShowIfIsUnderline();
        }

        public void ShowIfIsUnderline()
        {
            Console.WriteLine(IsUnderline ? "Text is underline\n" : "Text isn't underline\n");
        }

        public void ChangeStatusOfUnderline(bool isUnderline)
        {
            IsUnderline = isUnderline;
        }
    }
}
