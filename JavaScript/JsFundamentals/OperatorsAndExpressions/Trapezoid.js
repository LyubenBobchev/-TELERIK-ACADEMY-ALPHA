//.8 Trapeziod

function trapezoid(input) {
    const sideA = parseFloat(input[0]);
    const sideB = parseFloat(input[1]);
    const height = parseFloat(input[2]);
    let area = 0.5 * height * (sideA + sideB);
    console.log(area.toFixed(7));
}
