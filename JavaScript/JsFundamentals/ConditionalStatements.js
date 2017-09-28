//1.Exchange if greater

function exchangeIfGreater(input) {
    let aVariable = parseFloat(input[0]);
    let bVariable = parseFloat(input[1]);
    let temp = 0;

    if (aVariable > bVariable) {
        temp = aVariable;
        aVariable = bVariable;
        bVariable = temp;
        console.log(aVariable + ' ' + bVariable)
    }
    else {
        console.log(aVariable + ' ' + bVariable)
    }
}

//2.Mutliplication Sign

function multiplicationSign(input) {
    let a = parseInt(input[0]);
    let b = parseInt(input[1]);
    let c = parseInt(input[2]);

    if (a === 0 || b === 0 || c === 0) {
        console.log(0);
    }
    else if (a > 0 && b > 0 && c > 0) {
        console.log('+');
    }
    else if (a < 0 && b < 0 && c < 0) {
        console.log('-');
    }
    else if (a > 0 && b < 0 && c < 0) {
        console.log('+');
    }
    else if (a > 0 && b > 0 && c < 0) {
        console.log('-');
    }
    else if (a > 0 && b < 0 && c > 0) {
        console.log('-');
    }
    else if (a < 0 && b > 0 && c > 0) {
        console.log('-');
    }
    else if (a < 0 && b < 0 && c > 0) {
        console.log('+');
    }
    else if (a < 0 && b > 0 && c < 0 ) {
        console.log('+');
    }
}
multiplicationSign(['-3', '-32', '9']);