using StructuralCode;

var creators = new List<Creator>()
{
    new ConcreteCreator1(),
    new ConcreteCreator2()
};

foreach (var creator in creators)
{
    Product product = creator.factoryMethod();
}