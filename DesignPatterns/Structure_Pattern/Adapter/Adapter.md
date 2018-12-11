# Adapter
  Convert interface of classes into another interface classes that client wants.
  Lets classes works together that couldn't otherwise because of incompatible interfaces.

# How client uses Adapter 
  - Client making a request on Adapter, by calling a method on it using the target interface.
  - The Adapter translate that request into one or more calls on the adaptee using the adaptee interface.
  - The client receives the result for the request without knows there's an adapter doing the translation.

# How it works
	By wrapping the object that has incompatible interface with an object that implements the correct one

# Difference between Adapter, Decorator and Facade.
  - Decorator -> * Changes the behaviour of one class by adding another class to add another behaviour
				 * Converts ont interface to another.
  - Adapter   -> * Make classes works together, without changes it's behaviours 
				 * Doesn't alters interfaces but adding responsibility
  - Facade    -> Alters an interface, make and interface simpler