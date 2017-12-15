//4.Appearance count

function countAppearance(input) {

	let inputElements = input.split(', ');
	let arrayLength = +inputElements[0];
	let numsArray = inputElements.slice(1, (arrayLength + 1));
	let numToCount = inputElements.pop();
	
	function count(numToCount, numsArray) {
		let counter = 0;
		numsArray.forEach(element => {
			if (element === numToCount) {
				counter++;
			}
		});
		return counter;
	}

	return count(numToCount, numsArray);
}