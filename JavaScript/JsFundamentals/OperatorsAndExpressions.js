//1.odd or even
'use strict'
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
    const number = parseInt(input[0]);
    if (number <= 1) {
        return false;
    }
    else if (number === 2) {
        return true;
    }
    else{
        for (var i = 2; i < number; i++) {
           if (number % i === 0) { 
            return false;
           }          
        }
        return true;
    }
}

//.8 Trapeziod

function trapezoid(input) {
    const sideA = parseFloat(input[0]);
    const sideB = parseFloat(input[1]);
    const height = parseFloat(input[2]);
    let area = 0.5 * height * (sideA + sideB);
    console.log(area.toFixed(7));
}

//9. Point in Circle and Rectangle
function pointCircleRectangle(input){ 
    const xPoint = parseFloat(input[0]);
    const yPoint = parseFloat(input[1]);
    const xCircleCenter = 1;
    const yCircleCenter = 1;
    const circleRadius = 1.5;
    
    //numbers(coodrinates of the shapes' limits) for if statement in "isInsideRectangle" 
    //(condition of point) are done previously through grapical representation of the shapes.
    let isInsideRectangle = function calculations() {
            if (xPoint >= -1 && xPoint <= 5) { 
                if (yPoint >= -1 && yPoint <= 1) {
                    return true;
                }
            }   
            else{
                return false;
            }
        }
    
    
    let isInsideCircle = function calculations() {
        let pointDistanceToCenter = Math.sqrt(Math.pow((xPoint - xCircleCenter), 2) + Math.pow((yPoint - yCircleCenter),2));
        if (pointDistanceToCenter <= circleRadius) {
            return true;
        }
        else {
            return false;
        }
    }
   
    if (isInsideCircle()) {                                           // point is in given circle
        if (isInsideRectangle()) {                                    // point is in given rectangle
                console.log('inside circle inside rectangle')
            }
            else {                                                           // point is not in a given rectangle
                console.log('inside circle outside rectangle')
            }
            }
    else {                                                              // point is outside given circle
    if (isInsideRectangle()) {                                   // point is a given rectangle
        console.log('outside circle inside rectangle')
        }
        else {                                                          // point is not in a given rectangle
            console.log('outside circle outside rectangle')
        }
    }
}   