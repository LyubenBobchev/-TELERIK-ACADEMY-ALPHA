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