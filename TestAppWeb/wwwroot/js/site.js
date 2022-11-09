// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('.eyeClass').click(function () {
    $(this).find('i').toggleClass('bi bi-eye-fill').toggleClass('bi bi-eye-slash-fill');
});

function numberOfCharacters(input, limit, indicatore) {
    
    chars = document.getElementById(inputField).value.length;
    document.getElementById(indicatore).innerHTML = limit - chars;
}


function numberOfCharacters(textbox, limit, indicatore) {
    chars = document.getElementById(textbox).value.length;
    document.getElementById(indicatore).innerHTML = limit - chars + " characters";
}

