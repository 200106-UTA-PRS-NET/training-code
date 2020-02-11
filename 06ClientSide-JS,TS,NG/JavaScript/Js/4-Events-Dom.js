"use strict";

// Events - user-defined actions . click, mouseover, blur, change,dblclick, keypress
// Event Handlers - they are the functione which handles the event when an event is raised
function Welcome(){
    console.log("Hello World");
}
// Document object offers multiple functions to manipulate DOM:
// querySelector() // in ithis you can use the CSS selectors
// querySelectorAll() // this offers all the matching elements in the form of an array
// getElementById
// getElementByTagName
// getElementByName
// getElementByClassName
var btn1=document.querySelector("#btn1");
//btn1.onclick=display;
btn1.addEventListener('click',display);
function display(){
    var para=document.querySelector('p');
    para.innerHTML="Hello to JavaScript";
}\
//Event Propogation: