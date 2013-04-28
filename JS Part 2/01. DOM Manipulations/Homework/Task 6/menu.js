var liTags = document.getElementsByTagName('li');

for(var i = 0; i < liTags.length; i++) {
	liTags[i].addEventListener('click', displayOrHideSubMenu);
}

function displayOrHideSubMenu(event) {

	if(typeof this.getElementsByTagName('ul')[0] == 'undefined') return 0;

	if(this.getElementsByTagName('ul')[0].style.display == 'block' && this == event.target) {
		this.getElementsByTagName('ul')[0].style.display = 'none';
	}
	else {
		this.getElementsByTagName('ul')[0].style.display = 'block';
	}
}