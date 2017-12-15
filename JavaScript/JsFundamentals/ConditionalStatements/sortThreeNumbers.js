//4.Sort three numbers

function sortThreeNumbers(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
   
    if (a >= b && b >= c ) {
        console.log(`${a} ${b} ${c}`);
    }
    else if (a >= b && c >= b && a >= c) {
        console.log(`${a} ${c} ${b}`);
    }
    else if (b >= a && a >= c) {
        console.log(`${b} ${a} ${c}`);
    }
    else if (b >= a && c >= a && b >= c) {
        console.log(`${b} ${c} ${a}`);
    }
    else if (c >= a && a >= b) { 
        console.log(`${c} ${a} ${b}`);
    }
    else if (c >= a && b >= a && c >= b) {
        console.log(`${c} ${b} ${a}`);
    }
}