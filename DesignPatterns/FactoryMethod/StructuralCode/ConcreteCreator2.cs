namespace StructuralCode
{
    public class ConcreteCreator2 : Creator
    {
        public override Product factoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
