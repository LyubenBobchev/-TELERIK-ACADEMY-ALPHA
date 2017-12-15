//3.English digit

function lastDigitToWord(input) {

	function getLastDigit(number) {
		return number % 10;
	}
	function digitToWord(digit) {
		switch (digit) {
			case 1:
				return "one";
				break;
			case 2:
				return 'two';
				break;
			case 3:
				return 'three';
				break;
			case 4:
				return 'four';
				break;
			case 5:
				return 'five';
				break;
			case 6:
				return 'six';
				break;
			case 7:
				return 'seven';
				break;
			case 8:
				return 'eight';
				break;
			case 9:
				return 'nine';
				break;
			case 0:
				return 'zero';
				break;
			default:
				break;
		}
	}
	input = +input;
	let lastDigit = getLastDigit(input);
	return digitToWord(lastDigit);
}