//This Code was written by ChatGPT
window.renderMathJax = function () {
    
    if (window.MathJax) {
        MathJax.typesetPromise();
    } else {
        console.error("MathJax is not loaded.");
    }
};
document.addEventListener("DOMContentLoaded", function () {
    console.log("Re-initializing MathJax after navigation...");
    window.renderMathJax();
});



