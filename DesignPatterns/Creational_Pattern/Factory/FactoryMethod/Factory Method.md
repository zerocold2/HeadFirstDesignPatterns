﻿# Factory Method Creator
## Type: Creational

# What it is:
	Define an interface for creating an object, but let subclasses decide which class to instantiate. 
	Lets a class defer instantiation to subclasses.

# When it uses.
	When we needs to instantiate an object in run time.
	and it needs a logic to know which object to instantiate, and we only knows that logic in run time.
	usualy we know the type of the object by passing the name of the object in the creator constractor

# Example.
	Interface_Product -> Concrete_Product
	Abstract_Creator [Has GetProduct method from type interface_Product] -> Concrete_Creator [passing the name of the object in constractor]