// Functions - first class JS constructs/ object
//console.log("Check JS is tied properly")
//window.alert("Welcome");
//var name=window.prompt("Enter your name");
//console.log(name);
//let isConfirmed=confirm("Do you want to continue?");
//console.log(isConfirmed);

// Functions in JS are :
//var a=Number(prompt('Enter first number'));
//var b=Number(prompt('Enter second number'));
// Named functions
/*function Add(x,y){
    return x+y;
}*/
//var result=add(a,b);
// Function Expression with anonymous function
/*var addition=function (x,y){
    return x+y;
}
var result=addition(a,b);
console.log(result);
console.log(typeof(result));*/

// Anonymous Functions as IIFE -> Immdiately Invoked Function Expressions
/*(function(a,b){
    console.log(a+b);
    return a+b;
})(a,b);*/

// ES6 introduced  Arrow functions
//(()=>console.log('Hello'))();
//((a,b)=>console.log(a+b))(a,b);

// Callback Functions - a function is passed as a parameter to other function for use in side the function
/*function Show(name){
    return `Welcome ${name}`; // string interpolation in ES6 onwards
}
//              Callback function
//                    vv
function Display(a,b,Show){
    console.log(Show('Jake'));
    return a+ b;
}
Display(10,20,Show);
*/
// Parameters of a function
// Mandatory parameters
// Default parameters
// Rest parameters <-> params in C#
// function Add(a=1,b=2){
//     console.log(a+b);
// }
//var sum=0;// global variable
//const pi=3.14;
Add(1,2);
Add(2,5,3,6);
'use strict'; // will have some strict enforcement to use JS in a proper way
function Add(...a){
    //pi=5;// this will lead to error as const cannot be re-assigned
    //var sum=0; // function scope variable
    {
        const pi=3.14;
        var sum=0;
        //globalval="Test global";
        for(var value of a){
        
            //console.error(sum);
            sum += value;
        }
    }
    //console.log(pi);// this will give error as const is also block scoped
    console.log(sum);// this will give error if let is used as let is block scoped
}
//console.log(sum);
// hoisting of global variables is not recommended by JS in strict mode
//console.log(globalval); // hoisting

// Closures
function A1(a){
    //debugger;
     function B(b){
         function C(c){
            console.log(a+b+c);
            return a+b+c;
        }
        C(30);
    }   
    B(20);
}
//A1(10);
//console.log(A1);
function A2(a){
    return function B(b){
        return function C(c){
            return a+b+c;
        }       
    }   
}
//curry functions is JS
//console.log(A2(10)(20)(30));

// Generator functions - a function * in ES11
function* testGeneratorFunc(){
    yield 'a';
    yield 'b';
    yield 'c';
}

// for(let item of testGeneratorFunc()){
//     console.log(item);
// }
var result= testGeneratorFunc();
// console.log(result.next().value);
// console.log(result.next().value);
// console.log(result.next().value);
// console.log(result.next().value);


