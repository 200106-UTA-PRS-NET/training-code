// What is JS?
// Scripting/Programming Language which is typically used for core client side technologies
// It was known as LiveScript -> JavaScript (because Java was popular)->ECMAScript
// ES5(EcmaScript 2009-2011) ,ES6(EcmaScript 2015)..... ES11 (EcmaScript 2020)
// JS is interpreted PL nit compiled
// JS programs are executed on Js Engines (they on browsers - Chakra(IE and Edge), Chrome -> V8, SpiderMonkey-> Firefox, Safari->Nitro)
// JS is not OOP but Object based PL
// JS is Weakly typed language

/* JS can be applied in 3 ways:
    inline
    internal
    External
*/

// External JS
function Welcome(){
    alert('Hello World');
}
//console.log("Hello Kyle");

// 1. Datatypes in JS
    // Variables and constants
        //x="Pushpinder"; // global variable but not recommended way
        //var x="Kaur";//variable of function scoped
        let x="Kalsi";// ES6 onwards this is the most recommended way of creating variables as blocked scoped
      //Numbers - like double, infinity, NaN  
        x=123;
        x= 1/2;
        x=1/0;// infinity
        x='abc'/2;// NaN -> isNan(x)
        x=-Infinity;
        x=NaN;
    // Strings - ' '  or " "
    x = "Jacob's codebase";
    x += ' on git';
    x= +'1' + 1;
    // Boolean
    x = true;
    x= 10>9;
    x=Boolean(0);// Type casting in JS 
    // Based on Boolean conversion all the values can be either Truthy or falsy
    // Falsy - 0, "", null, NaN, false, undefined
    // Truthy are the values which are not falsy
   // Null 
   x =null;
   // undefined - any variable without an unassigned value 
   var y;
   // Object
    y={};// create empty
    y.name="Mark";
    y.age=28;
   // Symbol new in ES6

        //console.log(1+ +'1');
    //    console.log(y);
    //    console.log(Boolean(y));
    //    console.log(typeof(y));
        //console.log(isNaN(x))

// Operators - Arithmatic (+, -, /, *, %), Logical (&&, ||, !), Comparison (>,<,>=,<=), assignment operator (=), 
//equality(==,===), ternary (condition?<true value>:<false value>), Bitwise operators
//==-> this check for the value equality
//===-> strict equality operator it checks for value as well as its type.
var a=1, b='1';
a=false, b=0;
a=undefined,b=null;
a= NaN, b=NaN;
//console.log(a==b);
//console.log(a===b);
// Programming constructs in JS is like C, C++ 
    // if(){

    // }
    // else if(){

    // }
    // else{
        
    // }

    // switch(pattern){
    //     case 1:{}
    //     case 2:{}
    //     case 3:{}
    //     default
    // }

    // for of  in JS=> foreach in C#