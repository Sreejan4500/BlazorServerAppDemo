function callMethod() {
	DotNet.invokeMethodAsync("BlazorServerAppDemo", "GetValueFromMethod")
		.then(result =>
		{
			alert("Message from Method: " + result);
		});
}