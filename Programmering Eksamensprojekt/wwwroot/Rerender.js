window.renderMathJax = function () {
    if (window.MathJax && window.MathJax.typesetPromise) {
        window.MathJax.typesetPromise()
            .catch((err) => console.error("MathJax rendering error:", err));
    } else {
        console.error("MathJax is not loaded!");
    }
};