window.renderMathJax = function () {
    if (window.MathJax) {
        MathJax.typesetPromise();
    } else {
        console.error("MathJax is not loaded.");
    }
};