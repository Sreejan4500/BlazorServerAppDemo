﻿function callMethod() {
	DotNet.invokeMethodAsync("BlazorServerAppDemo", "GetValueFromMethod")
		.then(result =>
		{
			alert("Message from Method: " + result);
		});
}

export function callInstanceMethod(instanceObject) {
	instanceObject.invokeMethodAsync("GetValueFromInstance")
		.then(result => {
			alert("Message from Method: " + result);
		});
}