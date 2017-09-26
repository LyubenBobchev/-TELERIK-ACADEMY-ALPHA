//1.odd or even

function oddOrEven(input){
const inputNum = +input;
    if(input % 2 === 0) {
        return('even' + ' ' + inputNum);
    }
    else {
         return('odd' + ' ' + inputNum);
    }
}
//2.Divide by seven and five

function division(input){
    const inputNum = +input[0];
    
    
    if ((inputNum % 5 === 0) && (inputNum % 7 ===0)) {
        let trueNumber = inputNum;
        console.log('true' + ' ' + trueNumber);
    }
    else {
        console.log('false' + ' ' + inputNum)
    }
}

//3.Rectangles

function rectangles(input){
    let width = +input[0];
    let height = +input[1];
    let area = width*height;
    let perimeter = 2 * width + 2 * height;
    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

//4.Third diggit

function thirdDiggit(input){
    let position = Math.floor(input / 100);
    let thirdDiggit = position % 10;
        if (thirdDiggit === 7) {
        console.log('true');
    } else {
        console.log('false'+' '+thirdDiggit);
    }
}

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

//6.Point in a Circle

function pointInACircle(input){ //radius is 2 with center {0,0}
    const xCoord = +input[0];
    const yCoord = +input[1];
    let distanceToCenter = Math.sqrt(Math.pow(xCoord, 2) + Math.pow(yCoord, 2));
    if (distanceToCenter <= 2) {
        console.log('yes' + ' ' + distanceToCenter.toFixed(2));
    } else {
        console.log('no' + ' ' + distanceToCenter.toFixed(2));
    }
}

//7.Prime Check

function primeCheck(input) {
    const number = +(input[0]);
    
}
    

