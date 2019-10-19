// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function onLoginSubmit() {
   
    const password = document.getElementById("passwordHolder").value;
    const passHash = CryptoJS.MD5(password).toString();
    document.getElementById("loginPassHash").value = passHash;
    return true;
}

function onRegistrationSubmit() {

    const password = document.getElementById("password").value;
    const passHash = CryptoJS.MD5(password).toString();
    document.getElementById("registerPassHash").value = passHash;
    return true;
}