//3.Rectangles

function rectangles(input){
    let width = +input[0];
    let height = +input[1];
    let area = width*height;
    let perimeter = 2 * width + 2 * height;
    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}