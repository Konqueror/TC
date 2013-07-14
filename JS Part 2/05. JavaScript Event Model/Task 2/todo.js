function addTask() {
	var div = document.getElementById("taskList");
	var input = document.getElementById("taskName")
	var newTaskname = input.value;


	if (newTaskname !== "") {
	    div.innerHTML += "<div><input type='checkbox'/>" + newTaskname + "</div>";
	}
	else {
	    input.placeholder = "Please fill out this field";
	}

	input.value = "";
}

function hide() {
	var div = document.getElementById("taskList");
    div.style.display = "none";
	
}

function show() {
	var div = document.getElementById("taskList");
    div.style.display = "block";
}

function deleteChecked() {
	var div = document.getElementById("taskList").children;

	//TODO: Implement this.
}