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

function onChecked() {
    const enabled = document.getElementById('enabled');
    const enabledChs = enabled.getElementsByTagName('input');
    const disabledChs = disabled.getElementsByTagName('input');
    //document.getElementsByTagName('').
    //Change.enabled = enabledChs.some(e => !e.checked) || disabledChs.some(e => e.checked);
    for (let i = 0; i < enabledChs.length; i++)
        if (!enabledChs.item(i).checked /*== "checked"*/) {
            Change.disabled = '';
            return;
        }
    for (let i = 0; i < disabledChs.length; i++)
        if (disabledChs.item(i).checked /*== ''*/) {
            Change.disabled = '';
            return;
        }
    Change.disabled = 'disabled';
}

function selectChecked() {
    const enabled = document.getElementById('enabled');
    const enabledChs = enabled.getElementsByTagName('div');
    const disabledChs = disabled.getElementsByTagName('div');
    const e = enabled.getElementsByTagName('input');
    const d = disabled.getElementsByTagName('input');
    //document.getElementsByTagName('').
    //Change.enabled = enabledChs.some(e => !e.checked) || disabledChs.some(e => e.checked);
    for (let i = 0; i < enabledChs.length; i++)
        if (!(e.item(i).checked) /*== "checked"*/) {
            enabledChs.item(i).innerHTML = '';
        }
    for (let i = 0; i < disabledChs.length; i++)
        if (!(d.item(i).checked) /*== ''*/) {

            disabledChs.item(i).innerHTML = '';
            
        }
    return true;
}

function onDropSubmit() {

    const password = document.getElementById("password").value;
    const passHash = CryptoJS.MD5(password).toString();
    document.getElementById("pass").value = passHash;
    const ans = document.getElementById("ans").value;
    const ansHash = CryptoJS.MD5(ans).toString();
    document.getElementById("answer").value = ansHash;
    return true;
}