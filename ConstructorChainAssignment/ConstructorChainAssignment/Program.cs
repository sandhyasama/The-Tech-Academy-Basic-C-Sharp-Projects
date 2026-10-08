using ConstructorChainAssignment;

const string firstName = "John";
const int age = 30;

//creating an instance of Person class with firstName, lastName and age
Person person = new Person(firstName, "Smith", age);

//creating an instance of Person class with firstName and lastName, chaining it with default age of 42
Person person1 = new Person(firstName, "Johnson");