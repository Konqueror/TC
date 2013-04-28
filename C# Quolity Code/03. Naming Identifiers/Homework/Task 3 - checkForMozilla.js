function checkIfBrowserIsMozilla() {
	var browserName  = window.navigator.appCodeName;
	var isMozilla = (browserName == "Mozilla");
	
	if(isMozilla){
		alert("Yes");
	}
	  else{
		alert("No");
	}
}

