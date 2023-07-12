using _01_strategy_simuduck;
using _01_strategy_simuduck.Behaviors;

Console.WriteLine("*** Initializing SimUDuckProgram ***");

ModelDuck modelDuck = new ModelDuck();
modelDuck.Display();
modelDuck.PerformFly();
modelDuck.PerformQuack();
modelDuck.Swim();

MallardDuck mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.PerformFly();
mallardDuck.PerformQuack();
modelDuck.Swim();

DuckBase ruberDuck = new RuberDuck();
ruberDuck.Display();
ruberDuck.PerformFly();
ruberDuck.PerformQuack();
modelDuck.Swim();


//Mudando o comportamento do ModelDuck durante a execução
modelDuck.Display();
modelDuck.SetFlyBehavior(new FlyWithWings());
modelDuck.SetQuackBehavior(new MuteQuack());
modelDuck.PerformFly();
modelDuck.PerformQuack();
modelDuck.Swim();

