var textarea = document.getElementsByTagName('textarea')[0];

function setBackgroundColor() {
    textarea.style.background = document.getElementById('backgroundColor').value;
}

function setFontColor() {
    textarea.style.color = document.getElementById('fontColor').value;
}