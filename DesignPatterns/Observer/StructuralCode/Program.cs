using StructuralCode;

ConcreteSubject concreteSubject = new ConcreteSubject();

concreteSubject.SubjectState = "initial state";

concreteSubject.Attach(new ConcreteObserver(concreteSubject, "X"));
concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Y"));
concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Z"));

concreteSubject.SubjectState = "updated state";

Console.ReadKey();