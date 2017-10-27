//1.Numbers

function numbers(input) {
    let number = parseInt(input[0]);
    let arrayNums = [];
    
    for (var index = 1; index <= number; index++) {
        arrayNums.push(index);
    }
   console.log(arrayNums.join(' '));
}

//2.MMSA ???

function mmsa(input) {
    let maxValue = Number.MAX_VALUE;
    let minValue = Number.MIN_VALUE;
    let sum = 0;
    let tempMin = 0;
    let tempMax = 0;

    for (var index = 0; index < input.length; index++) {
        let number = parseFloat(input[index]);
        
        sum += number
        if (number > minValue) {
            tempMax = number;
        }
        
        if (number < maxValue) {
            tempMin = number;
        }
        maxValue = tempMax;
        minValue = tempMin;
    }
   
    let average = sum / input.length;
    console.log(`min=${minValue.toFixed(2)}`);
    console.log(`max=${maxValue.toFixed(2)}`);
    console.log(`sum=${sum.toFixed(2)}`);
    console.log(`avg=${average.toFixed(2)}`);
}

//3.Matrix of numbers

function matrixOfNumbers(input) {
    let matrixSize = parseInt(input[0]);
    
    for (var i = 1; i <= matrixSize; i++) {
        let nums = [];
        for (var j = i ; j <= matrixSize + i - 1; j++) {
            nums.push(j);
            
        }
        console.log(nums.join(' '));
    }
}

//4.Hex to decimal

function hexToDecimal(input) {
    // let number = parseInt(input[0], 16);
    // console.log(number)
    let stringNum = input[0].split('');
    let number = 0;
    let sum = 0;
    for (var i = 0; i < stringNum.length; i++) {

        switch (stringNum[i]) {
            case 'A':
            number = 10;
            break;
            case 'B':
            number = 11;
            break;
            case 'C':
            number = 12;
            break;
            case 'D':
            number = 13;
            break;
            case 'E':
            number = 14;
            break;
            case 'F':
            number = 15;
            break;

            default:
            number = parseInt(stringNum[i]);
        }
        let powerOfSixteen = (stringNum.length - 1) - i;
        sum += number * (Math.pow(16,powerOfSixteen));
    }
    console.log(sum);
}

hexToDecimal(['1AE3']);