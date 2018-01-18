//2.Task2

function findPrimeNums(minNum, maxNum) {
    let minRange = +minNum;
    let maxRange = +maxNum;

    if (minRange === undefined || maxRange === undefined) {
        throw new Error("Parameters must be two");
    } else if (isNaN(minRange) || isNaN(maxRange)) {
        throw new Error("Parameters must be numbers");
    } else {
        var primeNumbers = [];
          
        for (number = minRange; number <= maxRange; number += 1) {
            if (isPrime(number)) {
                primeNumbers.push(number);
            }
        }
        return primeNumbers;
    }
}

function isPrime(number) {
    let maxDivider = Math.sqrt(number),
        isPrime = true,
        currentDivider;

    if (number < 2) {
        return false;
    }
    for (currentDivider = 2; currentDivider <= maxDivider; currentDivider += 1) {
        if (!(number % currentDivider)) {
            isPrime = false;
            break;
        }
    }
    return isPrime;
}