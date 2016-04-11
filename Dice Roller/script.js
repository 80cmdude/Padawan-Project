function Roll() {
	var numDice = document.getElementById("numDice").value;
	var userInput = document.getElementById("userInput").value;
	var modifier = document.getElementById("modifier").value;
	if (userInput == 0 || numDice == 0) {
		var result = document.getElementById("result");
		result.innerHTML = "I can't roll 0!";
	}
	else if (userInput == 1) {
		var result = document.getElementById("result");
		result.innerHTML = "I couldn't find any double headed coins. Sorry!";
	}
	else {
		for (i = 0; i <= numDice; i++) {
			var result = document.getElementById("result");
			result.innerHTML = Math.floor(((Math.random() * userInput) + 1) + Math.floor(modifier)) * Math.floor(numDice);
			i++;
		}
	};
}