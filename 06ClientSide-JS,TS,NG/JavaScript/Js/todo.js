"use strict";

var input=document.querySelector("#inp1");
var btnAdd=document.querySelector("#btnAdd");
var ul=document.querySelector("#ul1");
var body=document.querySelector('body');
var darkbtn=document.querySelector("#changeThemeDark");

btnAdd.addEventListener('click',AddtoList);
// darkbtn.addEventListener('click', function(){
//     body.style.background="Blue";
// });
darkbtn.addEventListener('click',()=>body.setAttribute('class','dark'));
function AddtoList(){ 
       
    var li=document.createElement('li');
    var span=document.createElement('span');
    var btnDelete=document.createElement('button');
    btnDelete.textContent="Delete";
    span.textContent=input.value;
    li.appendChild(span);
    li.appendChild(btnDelete);
    ul.appendChild(li); 

    btnDelete.addEventListener('click', function(){
        ul.removeChild(li);
    })
    input.value="";// CLEAR  the input
    input.focus();   
}
