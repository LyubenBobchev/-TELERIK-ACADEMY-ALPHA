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