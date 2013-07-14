var movingShapes = (function() {
	window.onload = moveDivs(); //Make all divs move non stop

    var DIV_WIDTH = "50px";
    var DIV_HEIGHT = "50px";
    var DIV_START_POINT_X = 500;
    var DIV_START_POINT_Y = 300;
    var RACTANGULAR_MAX_X = 200;
    var RACTANGULAR_MAX_Y = 200;
    var RADIUS = 250;
    
    var divs = new Array(); 
    var divsCount = 0;
    function add(movementType){
        divs[divsCount] = new Div(movementType, divsCount);
        divs[divsCount].drow();
        divsCount++;
    }

    function Div(movementType, id) {
        this.id = id;
        this.class = movementType;
        this.radians = 0; //For circular moves
        this.x = DIV_START_POINT_X ; //For rectangular moves
        this.y = DIV_START_POINT_Y; 
        this.background = getRandomColor();
        this.border = "5px solid" + getRandomColor();
        this.color = getRandomColor();
        this.drow = Draw;
    }

    function Draw() {
        var fragments = document.createDocumentFragment();
        var newDiv = document.createElement("div");
        
        newDiv.id = this.id;
        newDiv.class = this.class;
        newDiv.style.backgroundColor = this.background;
        newDiv.style.width = DIV_WIDTH;
        newDiv.style.height = DIV_HEIGHT;
        newDiv.style.border = this.border;
        newDiv.style.color = this.color;

        newDiv.style.position = 'absolute';
        newDiv.style.left = DIV_START_POINT_X;
        newDiv.style.top = DIV_START_POINT_Y;
        
        fragments.appendChild(newDiv);
        document.body.appendChild(fragments);
    }

    function moveDivs() {
        for (var i = 0; i < divsCount; i++) {
            var currentDiv = document.getElementById(i);
            
            if(currentDiv.class == "ellipse"){
                currentDiv.style.left = screen.width/2 + RADIUS*Math.cos(divs[i].radians) + 'px';
                currentDiv.style.top = screen.height/2 + RADIUS*Math.sin(divs[i].radians)  + 'px';
                divs[i].radians += 0.05;
            }
            else if(currentDiv.class == "rect"){
                var upperLeft = divs[i].x < DIV_START_POINT_X  + RACTANGULAR_MAX_X && divs[i].y == DIV_START_POINT_Y;
                var upperRight = divs[i].x >= DIV_START_POINT_X  + RACTANGULAR_MAX_X && divs[i].y < DIV_START_POINT_Y + RACTANGULAR_MAX_Y;
                var lowerRight = divs[i].x >= DIV_START_POINT_X  - RACTANGULAR_MAX_X && divs[i].y >= DIV_START_POINT_Y + RACTANGULAR_MAX_Y;
                var lowerLeft = divs[i].x <= DIV_START_POINT_X  - RACTANGULAR_MAX_X && divs[i].y <= DIV_START_POINT_Y + RACTANGULAR_MAX_Y;

                if(upperLeft){
                    //move Right
                    currentDiv.style.left = divs[i].x + 'px';
                    divs[i].x = divs[i].x + 5;
                } 
                else if (upperRight){
                    //Move Down 
                    currentDiv.style.top = divs[i].y + 'px';
                    divs[i].y = divs[i].y + 5;
                }
                else if(lowerRight){
                    //Move Left
                    currentDiv.style.left = divs[i].x + 'px';
                    divs[i].x = divs[i].x - 5;  
                } 
                else if(lowerLeft){
                    //Move Up
                    currentDiv.style.top = divs[i].y + 'px';
                    divs[i].y = divs[i].y - 5;
                }   
            }
        }

        setTimeout(moveDivs, 100);
    }

    
    function getRandomColor() {
        var letters = '0123456789ABCDEF'.split('');
        var color = '#';
        
        for (var i = 0; i < 6; i++ ) {
            color += letters[Math.round(Math.random() * 15)];
        }
        
        return color;
    }

    return {
    	add: add,
    };
})();