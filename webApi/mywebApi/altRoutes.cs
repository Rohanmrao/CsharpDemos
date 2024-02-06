namespace altRoutes
{
    public static class altRoutesClass 
    {
    public static void MapRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/helloBoss", () => {

                const String helloStr = "Hello Boss !";
                return helloStr;
            });
        }
    }
}
