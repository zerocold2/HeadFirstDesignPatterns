# Adapter
	Convert interface of classes into another interface classes that client wants.
	Lets classes works together that couldn't otherwise because of incompatible interfaces.

# How client uses Adapter 
  - Client making a request on Adapter, by calling a method on it using the target interface.
  - The Adapter translate that request into one or more calls on the adaptee using the adaptee interface.
  - The client receives the result for the request without knows there's an adapter doing the translation.