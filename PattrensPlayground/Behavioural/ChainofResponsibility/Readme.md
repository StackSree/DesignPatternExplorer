Understanding the Chain of Responsibility Pattern
Definition:
The Chain of Responsibility pattern allows multiple handlers to process a request sequentially. Each handler decides either to:

Handle the request or
Pass it to the next handler in the chain.


How This Follows the CoR Pattern
Chain Structure:
UpperString → LowerString → DefaultString
Request Flow:
Each handler decides to process the input or pass it to the next handler.
Extensibility:
You can easily add more handlers without modifying the existing ones.