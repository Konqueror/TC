var DOMmodule = (function() {
  //const in js isn't multi browser compatible
  //Lets make it 5 instead of 100 for easier testing
  var MAX_ELEMENTS_IN_BUFFER = 5;

  var selectorBuffer = {};

  function getElement(selector) {
    return document.querySelector(selector);
  }

  function createElement(type, innerHTML) {
      var element = document.createElement(type);
      element.innerHTML = innerHTML;
      
      return element;
  }

  function addChild(selector, type, innerHTML) {
    var parent = getElement(selector);

        var newChild = createElement(type, innerHTML);

    parent.appendChild(newChild)

  }
  
  function removeElement(selector) {
    var elementToRemove =  getElement(selector);
    document.body.removeChild(elementToRemove);
  }

  function attachEvent(selector, eventType, eventHandler) {
  // https://developer.mozilla.org/en/docs/DOM/EventTarget.addEventListener
      var element = getElement(selector);
      element.addEventListener(eventType, eventHandler);
  }

  function addElementToBuffer(selector, type, innerHTML){
    var newElement = createElement(type, innerHTML);

    if (!selectorBuffer[selector]) {
            // if there is no buffer for this selector create one
            selectorBuffer[selector] = document.createDocumentFragment();
        }

    selectorBuffer[selector].appendChild(newElement);

    //try flush the buffer
    if (selectorBuffer[selector].childNodes.length === MAX_ELEMENTS_IN_BUFFER) {
        var parent = getElement(selector);
        parent.appendChild(selectorBuffer[selector]);

        selectorBuffer[selector] = null;
    }
  }

  return {
    getElement: getElement,
    addChild: 		addChild,
    removeElement: 	removeElement,
    attachEvent: 	attachEvent,
    addElementToBuffer: addElementToBuffer,
  };
})();