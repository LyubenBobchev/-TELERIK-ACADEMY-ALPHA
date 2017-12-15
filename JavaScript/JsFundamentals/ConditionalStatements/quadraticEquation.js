//6.Quadratic equation

function quadraticEquation(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
    let d = Math.pow(b, 2) - (4 * a * c);
    
    if (d < 0) {
        console.log('no real roots');
    }
    else if (d === 0) {
        let x = -1*b / (2*a);
        console.log(`x1=x2=${x.toFixed(2)}`);
    }
    else if (d > 0) {
        let x1 = ((-1 * b) - Math.sqrt(d)) / (2 * a);
        let x2 = ((-1 * b) + Math.sqrt(d)) / (2  *a);
        console.log(`x1=${x1.toFixed(2)}; x2=${x2.toFixed(2)}`);
    }
}