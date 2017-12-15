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
