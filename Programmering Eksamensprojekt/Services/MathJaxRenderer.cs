//This code was written by ChatGPT
namespace Programmering_Eksamensprojekt.Services
{
    using Microsoft.JSInterop;
    using System.Threading.Tasks;
    public class MathJaxRenderer
    {
        private readonly IJSRuntime _jsRuntime;

        public MathJaxRenderer(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime ?? throw new ArgumentNullException(nameof(jsRuntime));
        }

        public async Task RenderMath()
        {
            if (_jsRuntime == null)
            {
                throw new NullReferenceException("IJSRuntime is null in MathJaxRenderer.");
            }
            await _jsRuntime.InvokeVoidAsync("renderMathJax");
        }
    }
}
