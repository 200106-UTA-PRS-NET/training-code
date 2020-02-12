// function Display(user:string){
//     console.log("Hello "+user)
// }
// Display(123);

// let x:any=23;
// x="23";

class Employee{
    firstName:string;
    lastName:string;
    constructor(){
        this.firstName="Fred";
        this.lastName="Belotte"
    }
    fullName(){
        return `${this.firstName} ${this.lastName}`;
    }
}

interface IEmployee{
    firstName:string,
    lastName:string;
}

class Manager implements IEmployee{
   firstName:string;
   lastName:string; 
   constructor(){
       this.firstName="Fred";
       this.lastName="Belotte";
       this.middleName="J"
   }
   middleName:string;
}

function Greetings(user:IEmployee){
    return `${user.firstName} ${user.lastName}`;
}

let user={firstName:"Nick", lastName:"Escalona",middleName:"something"};
var greet=Greetings(user);

console.log(greet);

//var marks=[12,23,133];
var marks: Array<Number>=[12,454,67,88];
for (const mark of marks) {
    console.log(mark);
}


