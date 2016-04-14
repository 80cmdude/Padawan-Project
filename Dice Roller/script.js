function Roll() {
	var numDice = document.getElementById("numDice").value;
	var userInput = document.getElementById("userInput").value;
	var modifier = document.getElementById("modifier").value;
	if (userInput == 0 || numDice == 0) {
		var rolls = document.getElementById("rolls");
		rolls.innerHTML = "I can't roll 0!";
	}
	else if (userInput == 1) {
		var rolls = document.getElementById("rolls");
		rolls.innerHTML = "I couldn't find any double headed coins. Sorry!";
	}
	else {
		var rolls = "";
		var i;
		for (i = 0; i < numDice; i++) {
			rolls += Math.floor(((Math.random() * userInput) + 1)) + " ";
			document.getElementById("rolls").innerHTML = rolls;
		}
	};
}

