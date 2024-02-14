Create a Dog Class.
- A dog has a Name, IsGroomed and Age as its public attributes (Name should be readonly)
- A dog has a Groom behavior
- Include: 
  - Add two overloaded constructors: 
     - a default constructor (that gives dog a random name and age of 0 and isgroomed true)
     - a parameterized constructor, that requires Name and Age
  - Make Name readonly
  - Add a finalizer and dispose() which outputs Name + " deceased"
  - Add two overloaded methods for Groom
    - one that takes not params, set IsGroomed true and outputs "Groomed"
    - one that take in a integer for hours, set IsGroomed true and output "Grooming took {x} hours"
- Create an DogExtensions Class that has the extensions
  - IsGood, which outputs all dogs that have names starting with "L"
  - IsGroomed, which output all dogs that has been groomed
- In Program.cs, initialize 10 Dogs using the Object Initializer, then call you various Extensions

Some potential Dog names: Charlie  Buddy Bailey Bella Bear Max Cooper Coco Duke Milo Molly Lucy Leo Jack Rocky Ace Teddy Finn Stella Sadie Scout Bruno


Prof's Solution: https://github.com/tgunness/ProgrammingInDotnet/tree/main/InClassDemoAndExercises/Week%204%20-%20OOP%20Fundamentals%20-%20Classes%20Objects/Week4InClassDemo.DogExercise
