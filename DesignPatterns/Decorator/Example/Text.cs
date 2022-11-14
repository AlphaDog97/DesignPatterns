namespace Example
{
    public class Text : TextAbstraction
    {
        public Text(string font, double size)
        { 
            Font = font;
            Size = size;
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"The font is {Font}, size is {Size}\n");
        }
    }
}
