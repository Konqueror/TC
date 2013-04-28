var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", 
"wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", 
"wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];

generateTagCloud(tags, 17, 42);

function generateTagCloud(tags, minFontSize, maxFontSize){
	tags.sort();
	var productionTags = new Array();
	var productionTagsCount = new Array();

	for (var currentTag = 0; currentTag < tags.length; currentTag++) {
		if(productionTags[productionTags.length - 1] != tags[currentTag].toLowerCase()){
			productionTags[productionTags.length] = tags[currentTag].toLowerCase();
			productionTagsCount[productionTagsCount.length] = 1;
		} 
		else {
			productionTagsCount[productionTagsCount.length-1]++;
		}
	}

	sortByCount(productionTags, productionTagsCount);

 	var fontSizeStep = ((maxFontSize - minFontSize) / 3);
 	// Display the tag cloud
	for (var currentTag = 0; currentTag < productionTags.length; currentTag++) {
		var span = document.createElement("span");
		span.style.fontSize = minFontSize + (fontSizeStep * productionTagsCount[currentTag]) + "px";
		span.style.marginLeft = "10px";
		var tagText = document.createTextNode(productionTags[currentTag]);
		span.appendChild(tagText);

		var element = document.getElementById("tagBox");
		element.appendChild(span);

	}
}


function sortByCount(productionTags, productionTagsCount) {
    var swapped;
    do {
        swapped = false;
        for (var i=0; i < productionTagsCount.length-1; i++) {
            if (productionTagsCount[i] < productionTagsCount[i+1]) {
                var tempCount = productionTagsCount[i];
                var tempTag = productionTags[i];

                productionTagsCount[i] = productionTagsCount[i+1];
                productionTags[i] = productionTags[i+1];

                productionTagsCount[i+1] = tempCount;
                productionTags[i+1] = tempTag;

                swapped = true;
            }
        }
    } while (swapped);
}
