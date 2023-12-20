using Microsoft.AspNetCore.Mvc;

namespace TestStaticWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ObjectWithStatic mOWS;


        public TestController( ObjectWithStatic ows )
        {
            mOWS = ows;
        }

        [HttpPost]
        [Route("testfunc")]
        public async Task<IActionResult> TestFuncAsync()
        {
            ObjectWithStatic.CurrentContext = HttpContext;
            var res = await mOWS.DoSomeWork();
            return Ok( res );
        }
        

    }
}