window.renderMathJax = function () {
    window.renderMathJax = () => {
        if (window.MathJax) {
            MathJax.typesetPromise();
        }
    };