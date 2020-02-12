"use strict";
// function Display(user:string){
//     console.log("Hello "+user)
// }
// Display(123);
// let x:any=23;
// x="23";
class Employee {
    constructor() {
        this.firstName = "Fred";
        this.lastName = "Belotte";
    }
    fullName() {
        return `${this.firstName} ${this.lastName}`;
    }
}
class Manager {
    constructor() {
        this.firstName = "Fred";
        this.lastName = "Belotte";
        this.middleName = "J";
    }
}
function Greetings(user) {
    return `${user.firstName} ${user.lastName}`;
}
let user = { firstName: "Nick", lastName: "Escalona", middleName: "something" };
var greet = Greetings(user);
console.log(greet);
//var marks=[12,23,133];
var marks = [12, 454, 67, 88];
for (const mark of marks) {
    console.log(mark);
}
