# AsyncMessaging
A component that can send a string message asynchronously and receive a response to and from a server. This code is written for educational purpose.
# What is implemented
**The server should be able to respond to the following messages:**
- Request: "Hello" Response: "Hi" after a one second delay.
- Request: "Bye" Response: "Bye" The server closes the client connection.
- Request: "Ping" Response "Pong"
- Any other message should be considered invalid and an exception should be raised on the client.

**The client and server must maintain an active connection**

The underlying protocol is of your choice as long as a single stable network connection is used.

**The implementation should be thread safe**

Simultaneous send operations should be completed successfully.