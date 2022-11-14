namespace Example
{
    public abstract class TextDecorator : TextAbstraction
    {
        protected TextAbstraction component;
        public void SetComponent(TextAbstraction component)
        {
            this.component = component;
        }
        public override void ShowInformation()
        {
            if (component != null) component.ShowInformation();
        }
    }
}
