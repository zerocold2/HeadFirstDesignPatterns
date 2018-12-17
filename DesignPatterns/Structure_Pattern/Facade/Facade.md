# Facade Pattern
  Provides a unified interface to a set of interfaces in a subsystem. Defines a high level interface that makes the subsystem easier to use.
  
  
# Use And benefits Of Facade
  With the facade pattern you can take the complex subsystem and make it easier to use, by implementing a facade class that provides one or more reasonable interface 
  Facade don't encapsulate the subsystem classes; they provide a simplified interface to their functionality. The subsystem classes stay remain for client to direct use the specific interfaces
  Facade decouples the client from a subsystem classes of component, it also allow to decouple your client implementation from any of subsystem classes, if you code your client to the facade instead of subsystem classes you prevent any further changes to be affected the client

# Design Principle.
  ## The principle of least knowledge
     The Principle of least knowledge guides us to reduce the interaction between objects to just a close "friends"
	 Talk only to your immediate friends
	 The principle prevent us from creating designs that have a large number of classes coupled together, so the changes in one part of the system cascade to the other parts when you build a lot of dependencies between many classes 
  ## The Principle provide some guidelines.
     Take any object, now from any method from that object the principle told us that we should only invoke methods that belongs to:
	 - The object itself
	 - Object passed in as a parameter in the method 
	 - Any object the method created or instantiates
	 - Any component of the object