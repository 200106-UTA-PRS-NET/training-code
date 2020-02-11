document.querySelector("#save").addEventListener('click',()=>{
    // window.sessionStorage["user"]=document.querySelector("#inp").value;
    window.localStorage["user"]=document.querySelector("#inp").value;
}
);

document.querySelector("#clear").addEventListener('click',()=>{
    //sessionStorage["user"]="";
    localStorage["user"]="";
    }
);
document.querySelector("#reload").addEventListener('click',()=>{
  //  document.querySelector('inp').textContent=sessionStorage["user"];
    document.querySelector('#inp').value=localStorage["user"];
    }
);