var specialConsole = (function() {
	var console = document.getElementById('console');

    function format(stringToFormat){
        var masage = stringToFormat[0];
        var numStr;

        for(var i = 1; i < stringToFormat.length; i++) {
            numStr = '{' + parseInt(i-1) + '}';
            masage = masage.replace(numStr, stringToFormat[i]);
        }

        return masage.toString();
    }

    function appendOnConsole(unformatedString, color){
        var stringToDisplay = format(unformatedString);

        var newLine = document.createElement('p');

        newLine.innerHTML = stringToDisplay;
        newLine.style.color = color;

        console.appendChild(newLine);
    }

    function writeLine(){
        appendOnConsole(arguments, '#FFF')
    }

    function writeError(){
        appendOnConsole(arguments, '#C00')
    }

    function writeWarning(){
        appendOnConsole(arguments, '#EDF257')
    }
    
    return {
    	writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning,
    };

})();