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