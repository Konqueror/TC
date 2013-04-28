if (document.querySelector != true|| document.querySelectorAll != true) { //Idiotic, but it have to be that way
  document.querySelectorAll = function (selector) {
    if(selector.charAt(0) == "#") {
      return document.getElementById(selector.substring(1, selector.length));
    }
    else if(selector.charAt(0) == ".") {
      return document.getElementsByClassName(selector.substring(1, selector.length));
    }
    else {
      return document.getElementsByTagName(selector);
    }     
  }

  document.querySelector = function (selector) {
     if(selector.charAt(0) == "#") {
        return document.getElementById(selector.substring(1, selector.length))[0];
      }
      else if(selector.charAt(0) == "."){ 
        return document.getElementsByClassName(selector.substring(1, selector.length))[0];
      }
      else{
        return document.getElementsByTagName(selector)[0];
     }
  }
}
var el = document.querySelector("p");
alert("The paragraph id is: " + el.id + "\nAnd that must work on IE!");