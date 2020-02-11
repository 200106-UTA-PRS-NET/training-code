var btnJoke=document.querySelector("#btnJoke");
var h2=document.querySelector("#jokeArea");
btnJoke.addEventListener('click',loadJokeWithAjax);
var url="http://api.icndb.com/jokes/random";

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