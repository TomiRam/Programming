//Declare string variables
var firstName ="Alan";
var lastName ="Turing";

//only change code below this line

var myFirstName = "Tomi"
var myLastName = "Rämö"
//Escaping literal quotes in strings
var myStr = "I am a\"double quoted\" string inside\"double quotes\"";
console.log(myStr);
//single quotes
var myStr = '<a href ="http://www.example.com" target="_blank">Link</a>';

/****
Code output
\' single quote
\" double quote
\\ backslash
\n new line
\b backspace
\f form feed
****/

var myStr= "FirstLine\n\t\\Secondline\nThridLine"

var ourString = "I come first"+"i come second.";
var myStr ="This is the start. "+"This is the end. ";
console.log(myStr);

//String plus equals operation
var ourStr = "I come first. ";
ourStr += "I come second. ";

var myStr = "This is the first sentence.";
myStr+= "This is the second sentance";
console.log(myStr)

//Constructing string with variables
var ourName = "freeCodeCamp";
var ourStr = "Hello our name is " + ourName+ "how are you";

var myName = "Tomi";
var myStr = "My  name is "+ myName + "and I am well!";
console.log(myStr);

//Appeding Variables to Strings 
var anAdjentive = "awesome!";
var ourStr = "freeCodeCamp is";
ourStr+=anAdjentive;

var someAdjective= "worthwhile";
var myStr = "Learning code is";
myStr+=someAdjective;

//Find length of string
var firstNameLength = 0;
var firstName = "Ada";

firstNameLength = firstName.length;

//setup
var lastNameLength = 0;
var lastName ="Lovelace"

lastNameLength =lastName.length;
console.log(lastNameLength);

//Bracket Notation to Find First Characther in string
var firstLetterOfFirstName = "";
var firstName = "Ada";

firstLetterOfFirstName= firstName[0];

//setup
var firstLetterOfLastName = "";
var lastName ="Lovelace"

firstLetterOfLastName =lastName[0];
console.log(firstLetterOfLastName);
