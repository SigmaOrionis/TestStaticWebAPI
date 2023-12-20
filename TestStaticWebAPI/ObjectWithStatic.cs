using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TestStaticWebAPI
{
    public class ObjectWithStatic
    {
        //HttpContext mContext;
        private static readonly string stringChars = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890+_=*-?!@#$%^&(){}[]";
        public static HttpContext? CurrentContext { get; set; }

        private List<string> mStringList;

        public ObjectWithStatic( ) 
        { 
            //mContext = httpContext;
            mStringList = new List<string>();
        }     

        public async Task<string> DoSomeWork()
        {
            generateHeapOfData();
            await Task.Delay( 10 );
            return mStringList[0];
        }

        private void generateHeapOfData()
        {
            Random rand = new Random();

            for( int i = 0; i < 1000; i++ ) 
            {
                string genesis = "";

                for( int j = 0; j < 1000; j++ ) 
                {
                    int x = rand.Next(stringChars.Length);
                    genesis += stringChars[x];
                }

                mStringList.Add( genesis );
            }
        }



    }
}
