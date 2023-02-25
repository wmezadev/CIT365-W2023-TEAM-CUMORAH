// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function goToWhite(x) {
    let addQuote = document.getElementById('addQuote');
    let Quotes = document.getElementById('quotes');
    let AboutUs = document.getElementById('aboutUs');
    let Privacy = document.getElementById('privacy');

    switch (x) {
        case 1:
            addQuote.src = "../images/AddQuote-White.png";
            break;
        case 2:
            Quotes.src = "../images/Quotes-White.png";
            break;
        case 3:
            AboutUs.src = "../images/AboutUs-White.png";
            break;
        case 4:
            Privacy.src = "../images/Privacy-White.png";
            break;
        default:
            console.log("Error - goToWhite function");
    }
}

function goToBlack(x) {
    let addQuote = document.getElementById('addQuote');
    let Quotes = document.getElementById('quotes');
    let AboutUs = document.getElementById('aboutUs');
    let Privacy = document.getElementById('privacy');

    switch (x) {
        case 1:
            addQuote.src = "../images/AddQuote.png";
            break;
        case 2:
            Quotes.src = "../images/Quotes.png";
            break;
        case 3:
            AboutUs.src = "../images/AboutUs.png";
            break;
        case 4:
            Privacy.src = "../images/Privacy.png";
            break;
        default:
            console.log("Error - goToBlack function");
    }
}


// Creating Desktops

function changeMaterial() {
    let material = document.getElementById("material").value;
    let Desktop = document.getElementById("desktop-material");

    switch (material) {
        case "Pine":
            Desktop.src = "/images/Pine.png";
            break;
        case "Laminate":
            Desktop.src = "/images/Laminate.png";
            break;
        case "Veneer":
            Desktop.src = "/images/Veneer.png";
            break;
        case "Oak":
            Desktop.src = "/images/Oak.png";
            break;
        case "Rosewood":
            Desktop.src = "/images/Rosewood.png";
            break;
        default:
            console.log("Option not found - changeMaterial()");
    }
}

function changeDrawers() {
    let drawers = document.getElementById("drawers").value;
    let Desktop = document.getElementById("desktop-drawers");

    switch (drawers) {
        case "0":
            Desktop.src = "/images/Drawer-0.png";
            break;
        case "1":
            Desktop.src = "/images/Drawer-1.png";
            break;
        case "2":
            Desktop.src = "/images/Drawer-2.png";
            break;
        case "3":
            Desktop.src = "/images/Drawer-3.png";
            break;
        case "4":
            Desktop.src = "/images/Drawer-4.png";
            break;
        case "5":
            Desktop.src = "/images/Drawer-5.png";
            break;
        case "6":
            Desktop.src = "/images/Drawer-6.png";
            break;
        case "7":
            Desktop.src = "/images/Drawer-7.png";
            break;
        default:
            console.log("Option not found - changeDrawers()");
    }
}


//Checks the values of Material and Number of Drawers and execute the function that creates the design
function CheckDesktop() {
    changeMaterial();
    changeDrawers();
    console.log('Desktop Details Checked!')
}
if (window.addEventListener) {
    window.addEventListener('load', CheckDesktop, false);
} else {
    window.attachEvent('onload', CheckDesktop);
}