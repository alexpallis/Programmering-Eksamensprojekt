window.renderMathJax = function (element) {
    if (window.MathJax && window.MathJax.typesetPromise) {
        if (element) {
            // Process only the provided element
            window.MathJax.typesetPromise([element])
                .catch((err) => console.error("MathJax rendering error:", err));
        } else {
            console.warn("renderMathJax called with null or undefined element.");
        }
    } else {
        console.error("MathJax is not loaded!");
    }
};