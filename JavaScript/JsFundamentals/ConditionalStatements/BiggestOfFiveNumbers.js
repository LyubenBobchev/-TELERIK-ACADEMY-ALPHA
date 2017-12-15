//7.The Biggest of five numbers
function biggestOfFive(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
    let d = parseFloat(input[3]);
    let e = parseFloat(input[4]);
    
    if (a>b && a>c && a>d && a>e)
    {
        console.log(a);
    }
    else if (b>a && b>c && b>d && b>e)
    {
        console.log(b);
    }
    else if (c>a && c>b && c>d && c>e)
    {
        console.log(c);
    }
    else if (d>a && d>c && d>b && d>e)
    {
        console.log(d);
    }
    else
    {
        console.log(e);
    }
}