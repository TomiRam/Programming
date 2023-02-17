//store Multiple values with Arrays 
var ourArray =["John", 30];

var myArray = ["Tom", 28];

//Nested Arrays
var myArray=[["Bulls", 23],["White Sox",45]];

//Access Array Data With indexes
var myArray=[50,60,70];

var myData = myArray[0] 
console.log(myData); //prints  50

//Modify array with indexes
var myArray =[18,64,99];
myArray[0] = 45;
console.log(myArray);

//Access multi dimension Arrays with indexes
var myArray= [[1,2,3],[4,5,6],[7,8,9], [[10,11,12],13,14]];

var myData = myArray[2][1]; //prints 8
console.log(myData);
//push function array
var myArray =[["Tom",28], ["cat",2]];
myArray.push(["dog",3])
//pop function array
var removedFromMyArray= myArray.pop();
console.log(myArray);
//shift function
var removedFromMyArray= myArray.shift();
//unshift function 
myArray.shift();
myArray.unshift(["John",30]);



