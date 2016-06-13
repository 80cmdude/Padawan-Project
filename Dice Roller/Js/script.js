function Roll() {
	var numDice = document.getElementById("numDice").value;
	var userInput = document.getElementById("userInput").value;
	var modifier = document.getElementById("modifier").value;
	var total = 0;
	if (userInput == 0 || numDice == 0) {
		var array = document.getElementById("array");
		array.innerHTML = "I can't roll 0!";
	}
	else if (userInput == 1) {
		var array = document.getElementById("array");
		array.innerHTML = "I couldn't find any double headed coins. Sorry!";
	}
	else {
		var array = [];
		for (i = 0; i < numDice; i++) {
		    var rolls = Math.floor(((Math.random() * userInput) + 1));
    		array.push(rolls);
    		document.getElementById("array").innerHTML = array;
		}
	};
	for (i = 0; i < array.length; i++) {
    	total += array[i];
	}
	if (numDice == array[i]) {
		alert("crit");
	}
	document.getElementById("total").innerHTML = total;
	var totalMod = Math.floor(total) + Math.floor(modifier);
	document.getElementById("totalMod").innerHTML = totalMod;

}

