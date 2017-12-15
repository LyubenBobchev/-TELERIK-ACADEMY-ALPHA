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