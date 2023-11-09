# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?
A compiler error would occur stating that the variable is outside of the current context
2. Describe the three As of a test:  
A -   Arrange - Creates an instance or gives the necessary data that needs to be passed through the test. Like providing context.
A -   Act - Performs the function you want to test. Writing out the action or calling on the method that needs to be tested.
A -   Assert - This is the final line or lines of a test that compares the expected value and the actual value of the function you're testing.

3. What is the difference between `public` and `private` access modifiers?
Answer: Public means you can grab any information from the code block it defines. Private is used to limit access to within the method.
4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  *****
(B) Return some information about an object  *****
(C) Make changes to an object and return information about the object. *****
(D) None of the Above.  


5. How did you determine what to answer for the question above?
Answer: A method can do all of these. It can exclusively change information or return information about an object. It can also do both, but doing both sometimes won't follow SRP.
## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
