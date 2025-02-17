The Adapter Design Pattern is a structural design pattern that allows incompatible interfaces to work together.
It acts as a bridge between two classes, translating the interface of one class into another interface expected by the client.

In C#, the Adapter pattern is commonly implemented in one of two ways: class adapter (using inheritance) or object adapter (using composition). 
Below is an explanation and implementation example for each approach.

1. Class Adapter Example (Using Inheritance)
In this approach, the adapter class inherits from both the interface the client expects and the class being adapted.

Scenario
Suppose we have a legacy system that uses LegacyPrinter but the new system expects IPrinter. We'll use a class adapter to bridge the gap.

Explanation
The PrinterAdapter class inherits from LegacyPrinter and implements IPrinter.
It adapts the OldPrint method of LegacyPrinter to the Print method of IPrinter.


2. Object Adapter Example (Using Composition)
This approach uses composition by holding a reference to an instance of the class being adapted.

Scenario
We achieve the same goal as the class adapter but avoid inheriting from the adaptee.

Explanation
The PrinterAdapter class takes a LegacyPrinter instance in its constructor.
It uses composition to call the OldPrint method of the LegacyPrinter.


When to Use the Adapter Pattern
When you need to integrate a new system with an existing one that uses incompatible interfaces.
To reuse legacy code without modifying it.
When you want to decouple the client code from the implementation details of the adaptee.
Advantages
Promotes code reusability by reusing existing implementations.
Provides a single interface to work with different APIs or legacy code.
Disadvantages
Can increase the complexity of the system if overused.
Class adapters require inheritance, which limits flexibility.
This implementation demonstrates how you can effectively use the Adapter pattern to bridge gaps between incompatible interfaces in C#.
