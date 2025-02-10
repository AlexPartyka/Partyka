document.addEventListener('DOMContentLoaded', function() {
    const greetingElement = document.getElementById('greeting');
    greetingElement.textContent = 'Welcome to the Hybrid WebView Demo!';
    
    const buttonElement = document.getElementById('actionButton');
    buttonElement.addEventListener('click', function() {
        alert('Button clicked!');
    });
});