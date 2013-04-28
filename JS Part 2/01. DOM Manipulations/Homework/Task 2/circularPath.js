var radius = 200;

var divs=new Array(); 
divs[0] = new Div("red", 0);
divs[1] = new Div("blue", 1);
divs[2] = new Div("green", 2);
divs[3] = new Div("orange", 3);
divs[4] = new Div("purple", 4);

//Drow the divs
for (var i = 0; i < divs.length; i++) {
    divs[i].drow();
}

moveDivs();

function Div (color, id) {
    this.radians = id; //drow them in a diferent place
    this.id = id;
    this.color = color;
    this.drow = Draw;
}

function Draw() {
    var fragments = document.createDocumentFragment();
    var newDiv = document.createElement("div");
    
    newDiv.id = this.id;
    newDiv.style.backgroundColor = this.color;
    newDiv.style.width = "30px";
    newDiv.style.height = "30px";
    newDiv.style.position = 'absolute';
    newDiv.style.top = (screen.height/2 + (radius * Math.cos(this.radians))) + 'px';
    newDiv.style.left = (screen.width/2 + (radius * Math.sin(this.radians))) + 'px';
    newDiv.style.borderRadius = "50%";
    
    fragments.appendChild(newDiv);
    document.body.appendChild(fragments);
}
    
function moveDivs() {
    for (var i = 0; i < divs.length; i++) {
        var currentDiv = document.getElementById(i);
        currentDiv.style.left = screen.width/2 + radius*Math.cos(divs[i].radians) + 'px';
        currentDiv.style.top = screen.height/2 + radius*Math.sin(divs[i].radians)  + 'px';
        divs[i].radians += 0.05;
    }

    setTimeout(moveDivs, 100);
}