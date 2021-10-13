Define an interface for creating an object, but let subclasses decide which class to instantiate.
The Factory Method pattern lets a class defer instantiation to subclasses.

Computer World Example
In an application, you may have different database users. For example, one user may use
Oracle, and the other may use SQL Server. Whenever you need to insert data into your
database, you need to create either a SqlConnection or an OracleConnection and only
then can you proceed. If you put the code into if-else (or switch) statements, you need
to repeat a lot of code, which isn’t easily maintainable. This is because whenever you
need to support a new type of connection, you need to reopen your code and make those
modifications. This type of problem can be resolved using the Factory Method pattern.
Here I’ll provide an abstract creator class (IAnimalFactory) to define the basic structure.
As per the definition, the instantiation process will be carried out through the subclasses
that derive from this abstract class.