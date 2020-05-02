// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Скрипты для переключения цвета языка интерфейса UA|RU
function findCookieValue(cookieName) {
    var allcookies = document.cookie;
    var pos = allcookies.indexOf(cookieName + "=");

    // Если cookie с указанным именем найден, извлечь его значения.
    if (pos != -1) {
        var start = pos + cookieName.length + 1;
        var end = allcookies.indexOf(";", start);
        if (end == -1) end = allcookies.length;
        var value = allcookies.substring(start, end);
        value = decodeURIComponent(value);
        return value;
    }
}

let nameCookisLanguageUI = findCookieValue(".AspNetCore.Culture");
let nameLanguageUI = nameCookisLanguageUI.slice(nameCookisLanguageUI.length - 2);

//alert(nameLanguageUI);

if (nameLanguageUI == 'ru') {
    $('#language-ru').css('color', 'white');
    $('#language-ua').css('color', '#80d8ff');
}
else if (nameLanguageUI == 'uk') {
    $('#language-ua').css('color', 'white');
    $('#language-ru').css('color', '#80d8ff');
}
else {
    $('#language-ua').css('color', 'white');
    $('#language-ru').css('color', '#80d8ff');
}

// ----------------------------------------------------

//$('.datepicker').datepicker();
