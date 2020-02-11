var btnJoke=document.querySelector("#btnJoke");
var h2=document.querySelector("#jokeArea");
//btnJoke.addEventListener('click',loadJokeWithAjax);
//btnJoke.addEventListener('click',loadJokeWithFetch);
//var url="http://api.icndb.com/jokes/random";


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
        if (request.readyState == 4 && request.status == 200) {
            debugger;
            var contact = JSON.parse(request.response);
           console.log(contact);
        }
    };
    request.open('GET', url);
    request.send();

}
function loadJokeWithFetch(){
    fetch(url)
    .then(response=>response.json()) // fetch returns a promise which can be either success and arrive or failure
    .then(h=>{h2.innerHTML=h.value.joke})
    .catch(err=> {console.log(err)})
}
function loadJokeWithAjax(){
    var xhr=new XMLHttpRequest();// the object to make Ajax request to server
        xhr.onreadystatechange=function(e){
            console.log(`${xhr.readyState} - ${xhr.status} - ${xhr.statusText}`)
        if(xhr.readyState==4 && xhr.status==200){
            var response=xhr.response;
            HandleResponse(response);
        }
        else{
            console.log("Error has occured");
        }
    }
    xhr.open('GET',url);// by default 3rd parameter is true which means request is async
    xhr.send();
}

function HandleResponse(r){
    //JSON.stringify(object)// this is used to serialize the data
    var data=JSON.parse(r);// de-serialize the json 
    h2.innerHTML=data.value.joke
}
