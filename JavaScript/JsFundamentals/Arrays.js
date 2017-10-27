//1.Allocate Array

function allocateArray(input) {
    let number = parseInt(input[0]); 
    let array = []; 
    
    for (var i = 0; i < number; i++) {
        console.log(i * 5); 
    }
}

//2. Lexicographically comparison

function lexigrpComparison(input) {

    let charArrayA = input[0].split(''); 
    let charArrayB = input[1].split(''); 
    let maxIndex = Math.max(charArrayA.length, charArrayB.length); 
    for (var i = 0; i < maxIndex; i++) {
        if (charArrayA[i] > charArrayB[i]) {
            
            console.log('>'); 
            return; 
        }
        if (charArrayA[i] < charArrayB[i]) {
            
            console.log('<'); 
            return 
        }
        if (charArrayA[i] === charArrayB[i]) {
            continue; 
        }
    }
    if (charArrayA.length > charArrayB.length) {
        console.log('>'); 
    }
    else if (charArrayA.length < charArrayB.length) {
        console.log('<'); 
    }
    else {
        console.log('='); 
    }
}

// 3.Maximal sequence

function maximalSequence(input) {
    let maxSeq = 1;
    let currentMaxSeq = 1;
    for (var i = 0; i < input.length - 1; i++) {
        
        if (parseInt(input[i]) === parseInt(input[i + 1])) {
            currentMaxSeq++;
            if (currentMaxSeq > maxSeq) {
                maxSeq = currentMaxSeq;
            }
        }
        else {
            currentMaxSeq = 1;
        }
    }
    console.log(maxSeq);
}

//4.Maximal increasing sequence

function maxIncrSequence(input) {
    let maxSeq = 1;
    let currentMaxSeq = 1;
    for (var i = 0; i < input.length - 1; i++) {
        
        if (parseInt(input[i]) < parseInt(input[i + 1])) {
            currentMaxSeq++;
            if (currentMaxSeq > maxSeq) {
                maxSeq = currentMaxSeq;
            }
        }
        else {
            currentMaxSeq = 1;
        }
    }
    console.log(maxSeq);
}

//5.Selection sort ???

function selectionSort(array) {
    let input = [];

    for (var key in array) {
        input[key] = parseFloat(array[key])
    }
    for (var i = 0; i < input.length; i++) {
        
        let minNumIndex = i;
        
        for (var j = i; j < input.length; j++) {
            
            if (input[minNumIndex] > input[j]) {
                minNumIndex = j;
            }
        }
        
        let temp = input[i];
        input[i] = input[minNumIndex];
        input[minNumIndex] = temp;
    }

    for (var index = 0; index < input.length - 1; index++) {
        if (input[index] === input[index + 1]) {
            input.splice((index + 1), 1)
        }
    }
    for (var key in input) {
        console.log(input[key]);
    }
}

//6.Frequent number

function frequentNum(input) {
    let numCounter = 0;
    let maxCounter = 0;
    let repeatingNum = 0;
    let array = [];
    for (var key in input) {
        array[key] = parseInt(input[key]);
    }
    for (var i = 0; i < array.length; i++) {
        for (var j = 0; j < array.length; j++) {
            if (array[i] === array[j]) {
                numCounter++;
            }
        }
        if (numCounter > maxCounter) {
            maxCounter = numCounter;
            repeatingNum = array[i];
        }
        numCounter = 0;
    }
    console.log(`${repeatingNum} (${maxCounter} times)`);
}
frequentNum(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);
