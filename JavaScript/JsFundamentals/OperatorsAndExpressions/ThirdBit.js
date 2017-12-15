//5.Thidr Bit

function thirdBit(input) {
    const number = +input[0];
    let thirdBit =number >>> 3;
    if (thirdBit % 2 === 0) {
        console.log('0');
    } else {
        console.log('1')
    }
}