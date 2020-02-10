// Arrays 
var x1=[];// empty array
x1=[12, "string val", true, {id:1, name:"Jake"}];
/*for(let i=0; i<x1.length;i++){
    console.log(x1[i]);
}*/

// for in. for of
for (let i of x1) {
    //console.log(i);
}
//console.log(`${x1[3].name} ${x1[3].id}`);

// Objects
/*
Different ways to create objects:
    function constructor -> new function(){}
    JavaScript Object Literal Notation
*/
//old way of creating object
/*var Employee={};// empty object
Employee.firstName="Jake";
Employee.lastName="Dwayne";
Employee.Work=function(){
    console.log("Is a software developer");
}
Employee.Display=(fname,lname)=>{
    Employee.Work();
    return `${lname} ${fname}`;
}*/

var Employee={
    firstName:"Jake",
    lastName:"Dwayne",
    Work:()=>console.log("Is a software Developer"),
    Display:(fname,lname)=>{
        return `${lname} ${fname}`;
    }
}

console.log(Employee.Display("Fred","Belotte"));
// Inheritance 
var Manager={};
Manager.__proto__=Employee; 

Manager.Salary=()=>console.log("Salary is $11000");
Manager.Work();
Manager.Salary();

// ES 6 has classes which helps with inheritance 