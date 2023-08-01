namespace HelloFactoryMW
{
	public class MyMiddleWare : IMiddleware
	{
		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{

			Console.WriteLine("this is Before.....");


		await	next(context);

			Console.WriteLine("This is After...");


			
		}
	}
}
