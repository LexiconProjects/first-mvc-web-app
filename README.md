# My First MVC Web Application - Portfolio website

This is MVC Web Application consisting of the following projects:

## 1. Layout and Views 
Create an MVC Web Application from scratch. Use the ASP.NET Core Web Application project type, and the “Web Application (Model-View-Controller)”template to start with. This will give you the basic structure to build your project from. 

### Required Features: 
* General file structure of a MVC project. 
* A Layout file for your views to use. It should contain: 
   * A header element, containing a page logo and a navigation menu 
   * A container to be filled with each view. 
   * A footer, containing the current date as an object, and your name. 
* A controller with at least three views: 
   * About – Containing information about yourself (CV). 
   * Contact – Containingyour contact information. 
   * Projects – Containing the assignments and projects you have finished. 

### Code Requirements: 
* You must use Razor commands at least to some extent in the layout and the views. 
* You must use a single layout for at least three views. 
* You must have at least one controller and three views. 

### Subjects Covered: 
* MVC Project Structure 
* Controllers 
* Razor Views 
* Layouts 


## 2. Forms and Inputs 
Add a view to the existing page that takes a temperature in number form, checks how high it is, and tells you whether you have a fever or not. Define a custom route to reach it –“/FeverCheck”should redirect to this new page, rather than having to specify a controller and action. 

### Required Features: 
* A form that takes a single numeric value (float or integer) and sends it on to a controller action. 
* The value should be interpreted as a temperature and checked against the thresholds for fever. 
* A message should appear on the page, showing whether you have a fever or not. 

### Code Requirements: 
* The view must have a form that sends the value into the action. 
* If the value is not set, the page should not get a message to display, otherwise it should evaluate it and send back the message. 
* A custom route must be defined for this view. 
* The view can be on a separate controller, or on an existing one –it is your choice. 
* The code checking the value must be in a static method, contained in a separate model class. 

### Optional: 
- [x] Add a check for hypothermia as well as feverand display that as a message if you have a too low temperature. 
- [x] Add radio buttons to allow switching between Fahrenheit and Celsius degrees. 

### Subjects Covered: 
* Models as method libraries


## 3. Guessing Game 
Add a new view containing a number-guessing game. The page should include a form that allows you to input a number. When the page is loaded for the first time, the page should generate a random number between 1 and 100, that it will save when the page is refreshed. When you submit a number into the form, it should compare your number to the one the app generated. If it is the correct one, you should get a message congratulating you on your success, and a new number should be generated. Otherwise, it should tell you whether your guess is either too high or too low, and let you take another guess. 

### Required Features: 
* A randomly generated number, hidden from the user of the page. 
* The ability to guess, through a form, which number was generated. 
* A message displaying how well you did. 
 
### Code Requirements: 
* The guessing game View should be accessible through a custom route, using the “/GuessingGame” pattern, regardless of what the controller is named. 
* The random number, as well as the list of guesses, should be stored in the Session state. 
* Guessing should be handled through overloaded Actions, referring to the same View. 
* When the page is loaded through a GET request (such as through the URL), the app should reset, and start over with a new number. 
* When the page is loaded through a POST request, it should make a guess, unless the value is notprovided or invalid, in which case it should display anerror message. 
 
### Optional: 
- [x] Add a counter for how many times the user has guessed and display it after every failed guess.This should reset when the correct number is guessed. 
- [ ] Add a high score list that is stored in a cookie and displayed on the page

### Subjects Covered: 
* State management. 
* Session 
* Cookies 
* Overloaded actions with GET and POST
