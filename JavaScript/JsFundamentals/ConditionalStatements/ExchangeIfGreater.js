//1.Exchange if greater

function exchangeIfGreater(input) {
    let aletiable = parseFloat(input[0]);
    let bletiable = parseFloat(input[1]);
    let temp = 0;

    if (aletiable > bletiable) {
        temp = aletiable;
        aletiable = bletiable;
        bletiable = temp;
        console.log(aletiable + ' ' + bletiable)
    }
    else {
        console.log(aletiable + ' ' + bletiable)
    }
}