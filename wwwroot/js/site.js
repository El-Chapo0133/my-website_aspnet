// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const checkbox = document.getElementById('burger-check');
const leftNav = document.getElementById('left-nav');
const navItems = document.getElementsByClassName('nav-item');

checkbox.addEventListener('change', (event) => {
        if (event.currentTarget.checked) {
                leftNav.style.height = "100vh";
                // Array.prototype.forEach.call(navItems, item => {
                //         item.style.transform = "translate-x(-20px)";
                // });
        } else {
                // Array.prototype.forEach.call(navItems, item => {
                //         item.style.transform = "translate-x(20px)";
                // });
                leftNav.style.height = "4rem";
        }
});