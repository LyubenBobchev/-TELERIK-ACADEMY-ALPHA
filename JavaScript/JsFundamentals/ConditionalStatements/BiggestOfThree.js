//3.The Biggest of three

function biggestOfThree(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
    
    if (a === b & b === c) {
        console.log(a)
    }
    else if (a >= b && b >= c) {
        console.log(a);
    }
    else if (a >= c && c >= b) {
        console.log(a);
    }
    else if (b >= a && a >= c) {
        console.log(b);
    }
    else if (b >= c && c >= a) {
        console.log(b);
    }
    else if (c >= b && b >= a) {
        console.log(c);
    }
    else if (c >= a && a >= b) {
        console.log(c);
    }
}