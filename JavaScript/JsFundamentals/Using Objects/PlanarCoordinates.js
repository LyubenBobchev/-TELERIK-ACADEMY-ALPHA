//1.Planar coordinates

function planarCooridinates(input) {

    let coordinatesArray = input.map(Number);
    let pointsArray = [];
    let linesArray = [];

    function Point(x, y) {
        this.x = x;
        this.y = y;
    }

    function Line(point1, point2) {
        this.firstPoint = point1;
        this.secondPoint = point2;
        this.length = Math.sqrt(Math.pow((point2.x - point1.x), 2) + Math.pow((point2.y - point1.y), 2));
    }

    for (let i = 0; i < coordinatesArray.length - 1; i += 2) {

        let point = new Point(coordinatesArray[i], coordinatesArray[i + 1])
        pointsArray.push(point);
    }

    for (let k = 0; k < pointsArray.length - 1; k += 2) {
        let line = new Line(pointsArray[k], pointsArray[k + 1])
        linesArray.push(line);
    }

    function canFormTriangle(line1, line2, line3) {
        let compoundLineLength = line1.length + line2.length + line3.length
        var longestLineLength = Math.max(line1.length, line2.length, line3.length);
        let restOfLinesLength = compoundLineLength - longestLineLength;

        if (longestLineLength < restOfLinesLength) {
            return 'Triangle can be built';
        } else {
            return 'Triangle can not be built';
        }


    }

    linesArray.forEach(element => {
        console.log(element.length.toFixed(2))
    });

    console.log(canFormTriangle(linesArray[0], linesArray[1], linesArray[2]));
}
