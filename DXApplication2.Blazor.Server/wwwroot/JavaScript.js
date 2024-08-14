function moveCursorToEndByClass(xari) {
    console.log(xari);
    var elements = document.getElementsByClassName(xari);
    if (elements.length > 0) {
        var element = elements[0]; // Select the first element with the specified class
        element.focus();
        var length = element.value.length;
        element.setSelectionRange(length, length);
    }
}

function adjustTextareaHeight(textarea) {
    console.log(textarea);
    var elements = document.getElementsByClassName(textarea);
    if (elements.length > 0) {
        var element = elements[0]; // Select the first element with the specified class
        element.style.height = 'auto';
        element.style.height = element.scrollHeight + 'px';
        element.scrollTop = element.scrollHeight;
    }

  
}