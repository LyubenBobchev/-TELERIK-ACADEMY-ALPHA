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
    else if (a > 0 && b < 0 && c < 0) {// a+ b- c-
        console.log('+');
    }
    else if (a > 0 && b > 0 && c < 0) {// a+ b+ c-
        console.log('-');
    }
    else if (a > 0 && b < 0 && c > 0) {// a+ b- c+
        console.log('-');
    }
    else if (a < 0 && b > 0 && c > 0) {// a- b+ c+
        console.log('-');
    }
    else if (a < 0 && b < 0 && c > 0) {// a- b- c+
        console.log('+');
    }
    else if (a < 0 && b > 0 && c < 0 ) {// a- b+ c-
        console.log('+');
    }
}
