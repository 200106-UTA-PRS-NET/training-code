console.log("first  run");


function getDetails(id) {
    debugger;
   // var link = document.querySelector("#" + id);
    var url = "https://localhost:44342/api/Contact/"+ id;
    var request = new XMLHttpRequest();
    request.onerror = function () {
        console.log("Error");
    };
    request.onreadystatechange=function () {
        debugger;
        console.log(`${request.readyState} ${request.status}`);
        if (request.readyState === 4 && request.status === 200) {
            debugger;
            var contact = JSON.parse(request.response);
            var contactDiv = document.querySelector("#contact");
            var p = document.createElement('p');
            p.innerHTML = contact.firstName;
            contactDiv.appendChild(p);
        }
        //else {
        //    debugger;
        //    console.error(request.status);
        //}
    };
    request.open('GET', url);
    request.send();

}