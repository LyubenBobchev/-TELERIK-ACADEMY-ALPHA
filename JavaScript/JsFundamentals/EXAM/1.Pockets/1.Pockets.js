//1.Pockets

function solve(args) {
    let heights = args[0];
    let result = 0;
    let heightsArray = heights.split(' ');
    let objArray = [];

    function HeightsObj(value, isPeak, isPocket) {
        this.value = value;
        this.isPeak = isPeak;
        this.isPocket = isPocket;
    }

    heightsArray.forEach(element => {

        let heightObj = new HeightsObj(+element, false, false)

        objArray.push(heightObj);
    });

    //finding peaks
    for (let i = 1; i < objArray.length - 1; i++) {
        if ((objArray[i].value > objArray[i - 1].value) && (objArray[i].value > objArray[i + 1].value)) {
            objArray[i].isPeak = true;
        }
    }

    //finding pockets
    for (let i = 1; i < objArray.length - 1; i++) {
        if (!objArray[i].isPeak && (objArray[i - 1].isPeak && objArray[i + 1].isPeak)) {
            objArray[i].isPocket = true;
            result += objArray[i].value;
        }

    }
    console.log(result);
}

solve([
    "53 20 1 30 2 40 3 10 1"
])