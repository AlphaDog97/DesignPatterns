namespace Example
{
    public class BoldText : TextDecorator
    {
        public bool IsBold { get; set; } = false;

        public BoldText(TextAbstraction component)
        {
            SetComponent(component);
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            ShowIfIsBold();
        }

        public void ShowIfIsBold()
        {
            Console.WriteLine(IsBold ? "Text is bold\n" : "Text isn't bold\n");
        }

        public void ChangeStatusOfBold(bool isBold)
        {
            IsBold = isBold;
        }
    }
}
