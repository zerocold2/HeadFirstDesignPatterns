# Command:
	Encapsulate a request as an object, letting you parameterize clients with different requests
	queue or log requests and support undoable operations.

# Example:
	The waitress take the orders form customers as a request and then pass these orders to the chif and say to him order up, so there're somethings here the waitress, the customers, request and chif 
	Each request has the common function to be invoke that is orderUp() to the chif.

# When to Use Command Pattern:
  - Allawing us to seperate the object that making the request from object that receive and execute those requests.
  - You need a callback functionality.
  - A history of requests is needed.

# How to use:
  - The client create a command object
  - The client call the invoker with the command to store the command object in the invoker
  - later... The client asks the invoker to Execute() the command, once the command is loaded into the invoker it can remain in the invoker to be run many times, and it can discarded by using undo(), by this the client and the invoker decoupled from the receiver.