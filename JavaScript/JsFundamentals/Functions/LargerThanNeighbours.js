//5.Larger than neighbours

function largerThanNeighbours() {

    const arrayLength = +gets();    //input reading for judgeSystem
    const numArray = +gets().split(' ').map(Number);
    let counter = 0;

    for (let i = 1; i < arrayLength - 1; i++) {

        if (numArray[i] > numArray[i - 1] && +numArray[i] > numArray[i + 1]) {
            counter++;
        }
    }

    return counter;
}
