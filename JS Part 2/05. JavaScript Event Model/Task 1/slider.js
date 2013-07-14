var Images = ["1.jpg","2.jpg","3.jpg","4.jpg"]; // constant
var currentImage = 0;

(function() {
	var div = document.createElement("div");
	div.id = "slider"
	div.style.height = "500px";
	div.style.width = "680px";
	div.style.backgroundImage = "url('image/" + Images[currentImage] + "')";
	document.getElementById("wrapper").appendChild(div);
})();

function nextSwide(direction){
	var div = document.getElementById("slider");

	if(direction == "left"){
		currentImage++;
		div.style.backgroundImage = "url('image/" + Images[Math.abs(currentImage % Images.length)] + "')";
	}
	else if(direction == "right"){
		currentImage--;
		div.style.backgroundImage = "url('image/" + Images[Math.	abs(currentImage % Images.length)] + "')";
	}
}