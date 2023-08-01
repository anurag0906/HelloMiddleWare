namespace ConventionMW
{
	public class MyOldSchoolMiddleWare
	{
		private readonly RequestDelegate _requestDelegate;

		public MyOldSchoolMiddleWare(RequestDelegate requestDelegate)
		{
			_requestDelegate = requestDelegate;
		}

		public async Task Invoke(HttpContext context)
		{
			Console.WriteLine("Before old school.................");

			await _requestDelegate(context);

			Console.WriteLine("After MW ......");
		}
	}
}
