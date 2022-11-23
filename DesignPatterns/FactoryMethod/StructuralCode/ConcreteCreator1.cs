namespace StructuralCode
{
    public class ConcreteCreator1 : Creator
    {
        public override Product factoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
