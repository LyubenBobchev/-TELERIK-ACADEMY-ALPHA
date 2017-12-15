//2. Get largest number

function getLargestNum(input) {

	let nums = (input.split(' '));
	let parsedNums = new Array(3);

	for (var key in nums) {
		parsedNums[key] = parseInt(nums[key]);
	}

	function GetMax(firstParam, secondParam) {
		if (firstParam >= secondParam) {
			console.log(firstParam);
		}
		else {
			console.log(secondParam);
		}
	}

	if (parsedNums[0] >= parsedNums[1] && parsedNums[0] >= parsedNums[2]) {
		if (parsedNums[1] >= parsedNums[2]) {
			GetMax(parsedNums[0], parsedNums[1]);
		}
		else {
			GetMax(parsedNums[0], parsedNums[2])
		}
	}
	else if (parsedNums[1] >= parsedNums[0] && parsedNums[1] >= parsedNums[2]) {
		if (parsedNums[0] >= parsedNums[1]) {
			GetMax(parsedNums[1], parsedNums[0])
		}
		else {
			GetMax(parsedNums[1], parsedNums[2])
		}
	}
	else if (parsedNums[2] >= parsedNums[0] && parsedNums[2] >= parsedNums[1]) {
		if (parsedNums[0] >= parsedNums[1]) {
			GetMax(parsedNums[2], parsedNums[1])
		}
		else {
			GetMax(parsedNums[2], parsedNums[0])
		}
	}
}