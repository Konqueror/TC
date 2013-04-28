function generateDivs() {
	var divCount = document.getElementById("divCount").value;
  var fragments = document.createDocumentFragment();

  for (var i = 0; i < divCount; i++) {
    var newDiv = document.createElement("div");

    newDiv.style.width = getRandomNumber(20, 100) + "px";
    newDiv.style.height = getRandomNumber(20, 100) + "px";
    newDiv.style.backgroundColor = getRandomColor();
    newDiv.style.color = getRandomColor();
    newDiv.style.position = 'absolute';
    newDiv.style.top = getRandomNumber(0, screen.height - 100)+ "px";
    newDiv.style.left = getRandomNumber(0, screen.width - 100) + 'px';

    newDiv.style.textAlign = "center";
    var newStrong = document.createElement("strong");
    newStrong.textContent = "div";
    newDiv.appendChild(newStrong);
    
    newDiv.style.border = getRandomNumber(1, 20) + "px solid";;
    newDiv.style.borderRadius = getRandomNumber(0, 100) + "px";
    newDiv.style.borderColor = getRandomColor();

    fragments.appendChild(newDiv);
  }
  document.body.appendChild(fragments);
} 

function getRandomNumber(bottom, top) {
	var randomNumber = Math.floor( Math.random() * ( 1 + top - bottom ) ) + bottom;
	
	return randomNumber;
}

//Thank you stackoverflow.com
function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.round(Math.random() * 15)];
    }
    
    return color;
}